using AutoMapper;
using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Core.Logger;
using BuildingBlock.Core.Model;
using BuildingBlock.Core.WebApi;
using BuildingBlock.Zones.CRMIL.Api.Service;
using BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Command;
using BuildingBlock.Zones.CRMIL.Model.APIResponse;
using BuildingBlock.Zones.CRMIL.Model.Customer;
using BuildingBlock.Zones.CRMIL.Service;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using BuildingBlock.Zones.Model.Customer;
using BuildingBlock.Zones.Model.Customer.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Api.Controllers
{

    /// <summary>
    /// Customers API
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class CustomerController : BaseApiController
    {
        private readonly ICoreLogger<CustomerController> _logger;
        private readonly IApiErrorFactory _apiErrorFactory;
        private readonly IStringLocalizer<CustomerController> _localizer;
        private readonly ICustomerService _CustomerService;
        private readonly IOrderService _orderService;
        private readonly IConfiguration _configuration;
        /// <summary>
        /// Controller - Constructor
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="apiErrorFactory"></param> 
        /// <param name="localizer"></param>
        public CustomerController(ICustomerService CustomerService,ICoreLogger<CustomerController> logger, IApiErrorFactory apiErrorFactory, 
            IStringLocalizer<CustomerController> localizer)
        {
            //IOrderService orderService
            _logger = logger;
            _apiErrorFactory = apiErrorFactory;
            _localizer = localizer;
            _CustomerService = CustomerService;
          //  _orderService = orderService; 

        }
        /// <summary>
        /// Read Account Option
        /// </summary>
        /// <returns></returns>
        
        [HttpGet]
        [Route("ReadAccountOptionAsync")]
        public async Task<IActionResult> ReadAccountOption()
        {
            try
            {
                _logger.Information(LoggingHelper<CustomerController>.GetSucceeded());
                var accountOptions = new AccountOption();
                accountOptions.HttpStatusCode = System.Net.HttpStatusCode.OK;
                accountOptions.Messages.Add(new MessageInfo() { Code = "200", Message = _localizer["Ok"] });
                return Ok(accountOptions);
            }
            catch (Exception e)
            {
                _logger.Information(LoggingHelper<CustomerController>.GetFailed());
                var result = new UnprocessableEntityObjectResult(_localizer[e.Message]);
                return result;
            }
        }
        /// <summary>
        /// Customer Credit Data
        /// </summary>
        /// <param name="creditDataList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetCustomerCreditDataAsync")]
        public async Task<IActionResult> CustomerCreditData([ FromBody] CustomerCreditData customercreditDataList )
        {
            APIResponse apiResponse = new APIResponse();
            if (!String.IsNullOrWhiteSpace(customercreditDataList.companyId))
            {
                _logger.Information(LoggingHelper<CustomerController>.GetAttempt());
                var result = await _CustomerService.GetCustomerCreditData(customercreditDataList.creditdata, customercreditDataList.companyId);
                
                apiResponse.HttpStatusCode = System.Net.HttpStatusCode.OK;
                apiResponse.Messages.Add(new Core.Model.MessageInfo
                {
                    Code = "200",
                    Message = _localizer["Credit has been fetched successfully"],
                    Data = new Dictionary<string, string>() { { "Data", JsonConvert.SerializeObject(result) } }
                });
                return Ok(apiResponse);
            }
            else
            {
                return BadRequest();
            }
           
        }
        /// <summary>
        /// Get Credit info
        /// </summary>
        /// <returns></returns>
        
        [HttpGet]
        [Route("GetCreditCardDataAync")]
        public async Task<IActionResult> GetCreditCard()
        {
            _logger.Information(LoggingHelper<CustomerController>.GetSucceeded());
            var result = _CustomerService.GetCreditDataInfo();
            //return Ok(result);
            return Ok(result);

        }

        /// <summary>
        /// Update Credit Limit
        /// </summary>
        /// <param name="updateCreditLimitCommand">updateCreditLimitCommand</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(bool), StatusCodes.Status400BadRequest)]
        [Route("UpdateCreditLimitAsync")]
        public async Task<IActionResult> UpdateCreditLimitAsync([ FromBody] UpdateCreditLimitCommand updateCreditLimitCommand)  
        {
            if (updateCreditLimitCommand is  null)
            {
                _apiErrorFactory.AddErrorDetail(OrderErrorHelper<Object>.GetOrderFailed(_localizer));
                _logger.Information(OrderLoggingHelper.GetNotFound());
                return BadRequest(_apiErrorFactory.Error);
            }
           _logger.Information(LoggingHelper<CustomerController>.GetAttempt());
            var creditLimitStatus = await _CustomerService.UpdateCreidtLimit(updateCreditLimitCommand);
            _logger.Information(LoggingHelper<CustomerController>.CreateSucceeded());
            return Ok(creditLimitStatus);      
        }
    }
}
