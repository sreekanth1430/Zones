using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Core.Logger;
using BuildingBlock.Core.WebApi;
using BuildingBlock.Zones.Model;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using BuildingBlock.Core.ODataToCosmosTranslator;
using System.Linq;
using BuildingBlock.Zones.CRMIL.Api.Service;
using BuildingBlock.Zones.CRMIL.Model.Shipping;
using BuildingBlock.Zones.CRMIL.Service;
using BuildingBlock.Zones.Model.Shipping;
using BuildingBlock.Zones.CRMIL.Service;
using BuildingBlock.Zones.Model.Shipping;
using BuildingBlock.Zones.CRMIL.Model.Shipping;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using Microsoft.Extensions.Configuration;
using BuildingBlock.Core.Model;

namespace BuildingBlock.Zones.CRMIL.Api.Controllers
{
    /// <summary>
    /// Shipment API
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class FreightController : BaseApiController
    {
        private readonly IOrderService _orderService;
        private readonly ICoreLogger<FreightController> _logger;
        private readonly IApiErrorFactory _apiErrorFactory;
        private readonly IStringLocalizer<FreightController> _localizer;
        private readonly IFreightServices _FreightService;
        /// <summary>
        /// Controller - Constructor
        /// </summary>
        /// <param name="freightService"></param>
        /// <param name="logger"></param>
        /// <param name="apiErrorFactory"></param> 
        /// <param name="localizer"></param>
        public FreightController(IFreightServices FreightService,IOrderService orderService, ICoreLogger<FreightController> logger, IApiErrorFactory apiErrorFactory, IStringLocalizer<FreightController> localizer)
        {
            _FreightService = FreightService;
            _orderService = orderService;
            _logger = logger;
            _apiErrorFactory = apiErrorFactory;
            _localizer = localizer;
        }
        /// <summary>
        /// Get Shipping Rates
        /// </summary>
        /// <param name="shippingRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetShippingRatesAsync")]
        public async Task<IActionResult> GetShippingRates([FromBody] ShippingRequest shippingRequest)
        {
            try
            {
                var shippingResponse = _FreightService.GetShippingRates(shippingRequest).Result;
                if (shippingResponse!= null)
                {
                    _logger.Information(LoggingHelper<FreightController>.CreateSucceeded());
                    return Ok(shippingResponse);
                }
                else
                {
                    _apiErrorFactory.AddErrorDetail(ErrorHelper<FreightController>.ConvertQuoteFailed(_localizer));
                    return BadRequest(_apiErrorFactory.Error);
                }
            }
            catch(Exception ex)
            {
                _logger.Information(LoggingHelper<FreightController>.GetFailed());
                throw ex;
            }
        }

        // api/Freight/IsSurchargeApplicable
        /// <summary> 
        /// Calculate Surcharge
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("IsSurchargeApplicableAsync")]
        public async Task<IActionResult> IsSurchargeApplicable([FromBody]ShippingAddress shippingAddress)
        {
            if (shippingAddress == null)
            {  _logger.Information(LoggingHelper<FreightController>.GetNotFound());
                _apiErrorFactory.AddErrorDetail(ErrorHelper<FreightController>.MethodNotFoundError(_localizer));
                return NotFound(_apiErrorFactory.Error);
            }
            else
            {
                var result = _FreightService.surchargedetails();

                _logger.Information(LoggingHelper<FreightController>.CreateSucceeded());
                return Ok(result);
            }
        }
    }
}
