using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Core.Logger;
using BuildingBlock.Core.WebApi;
using BuildingBlock.Zones.CRMIL.Api.Service;
using BuildingBlock.Zones.CRMIL.Model.APIResponse;
using BuildingBlock.Zones.CRMIL.Service;
using BuildingBlock.Zones.Model.Product;
using BuildingBlock.Zones.Model.Product.RequestModel;
using BuildingBlock.Zones.Model.Product.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Api.Controllers
{
    /// <summary>
    /// Products API
    /// </summary>
    [ApiVersion("1.0")]
    // For adding a newer version of the API - make sure to use/update the MapToVersion at the method as well
    //[ApiVersion("1.1")]

    [Route("api/[controller]")]
    public class ProductController : BaseApiController
    {

        private readonly ICoreLogger<ProductController> _logger;
        private readonly IApiErrorFactory _apiErrorFactory;
        private readonly IStringLocalizer<ProductController> _localizer;
        private readonly IProductService _ProductService;
        /// <summary>
        /// Controller - Constructor
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="apiErrorFactory"></param> 
        /// <param name="localizer"></param>
        public ProductController(IProductService ProductService, ICoreLogger<ProductController> logger, IApiErrorFactory apiErrorFactory, IStringLocalizer<ProductController> localizer)
        {
            _ProductService = ProductService;
            _logger = logger;
            _apiErrorFactory = apiErrorFactory;
            _localizer = localizer;
        }

        // api/Products/Search
        /// <summary>
        /// Search Product 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("ProductSearchAsync")]
        public async Task<IActionResult> ProductSearch([FromBody]ProductSearch ProductSearch)
        {
            Product result = new Product();

                 result = _ProductService.searchproduct();
                _logger.Information(LoggingHelper<ProductController>.CreateSucceeded());
                return Ok(result);
        }

        /// <summary>
        /// Search ProductDetails
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        // GET api/Orders/ProductDetails
        [Route("ProductDetailsAsync")]
        public async Task<IActionResult> ProductDetails([FromBody]ProductSearch ProductSearch)
        {
            APIResponse apiResponse = new APIResponse();
            if (!String.IsNullOrWhiteSpace(ProductSearch.AXAccountNum))
            {
                var results = await _ProductService.SelectProductList(ProductSearch);
                _logger.Error(LoggingHelper<ProductController>.GetSucceeded());

                apiResponse.HttpStatusCode = System.Net.HttpStatusCode.OK;
                apiResponse.Messages.Add(new Core.Model.MessageInfo
                {
                    Code = "200",
                    Message = _localizer["Product Details has been fetched successfully"],
                    Data = new Dictionary<string, string>() { { "Data", JsonConvert.SerializeObject(results) } }
                });
                return Ok(apiResponse);
            }
            else
            {
                _logger.Error(LoggingHelper<ProductController>.GetFailed());
                return BadRequest();
            }
            
        }

        /// <summary>
        /// Fetch  SPA
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        // GET api/Orders/ProductDetails
        [Route("FetchSPAAsync")]
        public async Task<IActionResult> FetchSPA([FromBody] SPARequest ProductRequest)
        {
            APIResponse apiResponse = new APIResponse();
            if (!String.IsNullOrWhiteSpace(ProductRequest.CustomerAccount))
            {
                _logger.Information(LoggingHelper<ProductController>.GetAttempt());
                var result = await _ProductService.SelectSPADetails(ProductRequest.CustomerAccount, ProductRequest.EDPNumber, Convert.ToDecimal(ProductRequest.ItemQuantity), ProductRequest.ShippingDate, ProductRequest._companyId, ProductRequest._currencyCode);
                apiResponse.HttpStatusCode = System.Net.HttpStatusCode.OK;
                apiResponse.Messages.Add(new Core.Model.MessageInfo
                {
                    Code = "200",
                    Message = _localizer["SPA Details has been fetched successfully"],
                    Data = new Dictionary<string, string>() { { "Data", JsonConvert.SerializeObject(result) } }
                });
                return Ok(apiResponse);
            }
            else
            {
                _logger.Error(LoggingHelper<ProductController>.GetFailed());
                return BadRequest();
            }
        }

        /// <summary>
        /// Fetch OSRSummary
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        // GET api/Orders/ProductDetails
        [Route("GetOSRSummaryAsync")]
        public async Task<IActionResult> GetOSRSummary([ FromBody]OSRSummaryCall osrSummaryCall)
        {
            APIResponse apiResponse = new APIResponse();
            if (!String.IsNullOrWhiteSpace(osrSummaryCall.Customeraccount))
            {
                _logger.Information(LoggingHelper<ProductController>.GetSucceeded());
                var result = await _ProductService.GetOSRSummaryData(osrSummaryCall.OSRDetails, osrSummaryCall.Customeraccount, osrSummaryCall.SalesId, osrSummaryCall.CallContextCompany, osrSummaryCall.CurrencyCode);
                apiResponse.HttpStatusCode = System.Net.HttpStatusCode.OK;
                apiResponse.Messages.Add(new Core.Model.MessageInfo
                {
                    Code = "200",
                    Message = _localizer["SPA Details has been fetched successfully"],
                    Data = new Dictionary<string, string>() { { "Data", JsonConvert.SerializeObject(result) } }
                });
                return Ok(apiResponse);
            }
            else
            {
                _logger.Error(LoggingHelper<ProductController>.GetFailed());
                return BadRequest();
            }

        }
    }
}
