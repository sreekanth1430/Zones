using System;
using System.Threading.Tasks;
using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Core.Logger;
using BuildingBlock.Core.WebApi;
using BuildingBlock.Zones.CRMIL.Repo;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using BuildingBlock.Core.ODataToCosmosTranslator;
using System.Linq;
using BuildingBlock.Zones.CRMIL.Api.Service;
using BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Queries;
using MediatR;
using System.Collections.Generic;
using Newtonsoft.Json;
using AutoMapper;
using BuildingBlock.Zones.Model.CRMIL;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using Microsoft.Extensions.Configuration;
using BuildingBlock.Zones.Model.OrderModel;
using BuildingBlock.Core.Model;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using BuildingBlock.Zones.CRMIL.Model.Order.OrderRecall.RequestModel;
using CRMIL.DA.Interfaces.AX.SalesOrder;
using BuildingBlock.Zones.CRMIL.Model.Order;
using order1 = BuildingBlock.Zones.Model.OrderModel;
using BuildingBlock.Zones.CRMIL.Model.APIResponse;

namespace BuildingBlock.Zones.CRMIL.Api.Controllers
{
    /// <summary>
    /// Orders API
    /// </summary>
    [ApiVersion("1.0")]

    // For adding a newer version of the API - make sure to use/update the MapToVersion at the method as well
    //[ApiVersion("1.1")]

    [Route("api/[controller]")]
    public class OrderController : BaseApiController
    {
        private readonly IOrderService _orderService;
        private readonly ICoreLogger<OrderController> _logger;
        private readonly IApiErrorFactory _apiErrorFactory;
        private readonly IStringLocalizer<OrderController> _localizer;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        // private readonly IMediator _mediator;
        /// <summary>
        /// Controller - Constructor
        /// </summary>
        /// <param name="orderService"></param>
        /// <param name="logger"></param>
        /// <param name="apiErrorFactory"></param> 
        /// <param name="localizer"></param>
        public OrderController(IOrderService orderService, ICoreLogger<OrderController> logger, IApiErrorFactory apiErrorFactory, IStringLocalizer<OrderController> localizer, IMapper mapper, IConfiguration configuration)
        {
            //IMediator mediator
            _orderService = orderService;
            _logger = logger;
            _apiErrorFactory = apiErrorFactory;
            _localizer = localizer;
            _mapper = mapper;
            _configuration = configuration;
        }

        /// <summary>
        /// Get Order Recall Details based on OrderSearch
        /// </summary>
        /// <param name="orderDetailsRequest">OrderDetailsRequest</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(OrderDetailsRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(OrderDetailsRequest), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(OrderDetailsRequest), StatusCodes.Status404NotFound)]
        [Route("GetOrderDetailsAsync")]
        public async Task<IActionResult> GetOrderDetailsAsync([ FromBody]OrderDetailsRequest orderDetailsRequest)
        {
            APIResponse apiResponse = new APIResponse();
            if (!String.IsNullOrWhiteSpace(orderDetailsRequest.SalesID))
            {

                _logger.Information(OrderLoggingHelper.GetAttempt());
                var order = await _orderService.RecallOrderAsync(orderDetailsRequest);
                if (order.Any())
                {
                   
                    //orderResponse.OrderResponseData = order;

                    apiResponse.HttpStatusCode = System.Net.HttpStatusCode.OK;
                    apiResponse.Messages.Add(new Core.Model.MessageInfo
                    {
                        Code = "200",
                        Message = _localizer["Record has been fetched successfully"],
                        Data = new Dictionary<string, string>() { { "Data", JsonConvert.SerializeObject(order) } }
                    });
                }
                else
                {
                    _logger.Information(OrderLoggingHelper.GetNotFound(Convert.ToInt32(orderDetailsRequest.SalesID)));
                    return NotFound();
                }

                _logger.Information(OrderLoggingHelper.GetSucceeded());
                return Ok(apiResponse);
            }
            else
            {
                _logger.Error(OrderLoggingHelper.GetFailed());
                return BadRequest();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        [HttpPost]
        [Route("CreateOrdersAsync")]
        [ProducesResponseType(typeof(BuildingBlock.Zones.Model.OrderModel.Order), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(OrderDetailsRequest), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(OrderDetailsRequest), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateOrdersAsync([FromBody]BuildingBlock.Zones.Model.OrderModel.Order order)
        {
            AxdEntity_SalesTable[] oArrSales = order.AXSalesTable;

            for (int i = 0; i < oArrSales[0].SalesLine.Length; i++)
            {
                oArrSales[0].SalesLine[i].CurrencyCode = "USD";

                for (int y = 0; y < order.InventDim.Length; y++)
                {
                    if (Convert.ToDecimal(order.InventDim[y].LineNumber) == oArrSales[0].SalesLine[i].LineNum)
                    {
                        AxdEntity_InventDim[] axInventDim = new AxdEntity_InventDim[1];
                        axInventDim[0] = new AxdEntity_InventDim
                        {
                            ConfigId = order.InventDim[y].ConfigId,
                            InventLocationId = order.InventDim[y].InventLocationId
                        };
                        oArrSales[0].SalesLine[i].InventDim = axInventDim;
                    }
                }
            }
            AxdType_DimensionAttributeValue[] oArrDimension =
                    new AxdType_DimensionAttributeValue[]
                        {
                            new AxdType_DimensionAttributeValue
                            {
                                Name = "Department",
                                Value = order.DepartmentCode
                            }
                        };
            if (!string.IsNullOrEmpty(order.BusinessUnit))
            {
                Array.Resize(ref oArrDimension, oArrDimension.Length + 1);
                oArrDimension[oArrDimension.Length - 1] = new AxdType_DimensionAttributeValue
                {
                    Name = "BusinessUnit",
                    Value = order.BusinessUnit
                };
            }
            if (!string.IsNullOrEmpty(order.CostCenter))
            {
                Array.Resize(ref oArrDimension, oArrDimension.Length + 1);
                oArrDimension[oArrDimension.Length - 1] = new AxdType_DimensionAttributeValue
                {
                    Name = "CostCenter",
                    Value = order.CostCenter
                };
            }
            AxdType_DimensionAttributeValueSet oArrtributeSet = new()
            {
                Values = oArrDimension
            };
            oArrSales[0].DefaultDimension = oArrtributeSet;

            #region OrderComments
            var arrComments = new List<AxdEntity_DocuRefHeader>();

            if (order.OrderComment != null || order.POAttachmentFlag.ToLower().Equals("available"))
            {
                if (order.OrderComment != null && order.OrderComment.Length > 0)
                {
                    for (int i = 0; i < order.OrderComment.Length; i++)
                    {
                        var comment = new AxdEntity_DocuRefHeader();
                        comment.ZonAuthorAlias = order.OrderComment[i].User;
                        comment.Notes = order.OrderComment[i].Notes;
                        comment.RestrictionSpecified = true;
                        comment.Restriction = AxdEnum_DocuRestriction.Internal;
                        comment.TypeId = order.OrderComment[i].NoteType;

                        comment.Name = "Comment";

                        AxdExtType_CreatedDateTime cDate = new AxdExtType_CreatedDateTime();
                        cDate.Value = DateTime.UtcNow.Date;
                        comment.ZonCommentDateTime = cDate;

                        AxdExtType_CreatedDateTime sDate = new AxdExtType_CreatedDateTime();
                        sDate.Value = DateTime.UtcNow.Date;
                        comment.CreatedDateTime = sDate;

                        AxdExtType_ModifiedDateTime mDate = new AxdExtType_ModifiedDateTime();
                        sDate.Value = DateTime.UtcNow.Date;
                        comment.ModifiedDateTime = mDate;

                        arrComments.Add(comment);
                    }
                }
                if (order.POAttachmentFlag.ToLower().Equals("available"))
                {
                    for (int i = 0; i < order.POFileName.Length; i++)
                    {
                        var comment = new AxdEntity_DocuRefHeader();
                        comment.ZonAuthorAlias = oArrSales[0].ZonSalesResponsible;
                        comment.Notes = "PO " + order.POFileName[i] + " attached in Crm by " + order.CreatedBy;
                        comment.Name = "Comment";
                        comment.RestrictionSpecified = true;
                        comment.Restriction = AxdEnum_DocuRestriction.Internal;
                        comment.TypeId = AXNoteTypes.Zones;

                        arrComments.Add(comment);
                    }
                }
                oArrSales[0].DocuRefHeader = arrComments.ToArray();
            }

            #endregion OrderComments
            order1.Order oOrder = new(oArrSales)
            {
                LineCustomizationNoteInput = order.LineCustomizationNoteInput,
                POAttachmentFlag = order.POAttachmentFlag,
                SalesID = order.SalesID,
                POFileName = order.POFileName,
                POFolderName = order.POFolderName,
                CreatedBy = order.CreatedBy,
                OrderComment = order.OrderComment,
                SendQuote = order.SendQuote,
                OrderItems = order.OrderItems,
                OrderDocument = order.OrderDocument,
                OrderFreightAnalysiss = order.OrderFreightAnalysiss
            };

            try
            {
                var isSuccess = await _orderService.CreateOrderAsync(oOrder);
                return Ok(order);

            }
            catch (Exception _x)
            {
                
                throw new ApplicationException("Failed to create your order!", _x);
            }
        }       

        // GET api/Orders/RewcycleFeeCodes
        /// <summary>
        /// Get RecycleFeeCodes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRecycleFeeAsync")]
        public async Task<IActionResult> GetRecycleFee()
        {
            try
            {
                var result = _orderService.getrcyclefee();
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.Information(LoggingHelper<OrderController>.GetNotFound());
                var result = new UnprocessableEntityObjectResult(_localizer[e.Message]);
                return result;
            }

        }

        // api/orders/ConvertQuoteToOrder
        /// <summary>
        /// ConvertQuoteToOrder
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("ConvertQuoteToOrderAsync")]
        public async Task<IActionResult> ConvertQuoteToOrder([FromBody]WebQuoteRequest webquote)
        {
            if (webquote is null)
            {
                _apiErrorFactory.AddErrorDetail(ErrorHelper<OrderController>.ConvertQuoteFailed(_localizer));
                return BadRequest(_apiErrorFactory.Error);
            }
            else
            {
                _logger.Information(LoggingHelper<OrderController>.CreateSucceeded());
                return Ok(" Quote {SALES ID} successfully converted to Order in CRM and AX.");

            }
        }

    }

}
