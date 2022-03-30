
using BuildingBlock.Zones.CRMIL.Model.Product.RequestModel;
using BuildingBlock.Zones.CRMIL.Model.Product.ResponseModel;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using BuildingBlock.Zones.Model.Customer.Enum;
using BuildingBlock.Zones.Model.Product.RequestModel;
using BuildingBlock.Zones.Model.Product.ResponseModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Repo
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration _configuration;
        public ProductRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ZonOSRRequestContract[]> GetOSRSummary(ZonOSRRequestContract[] OSRDetails, string Customeraccount, string SalesId, string CompanyId, string CurrencyCode)
        {
            OSRRequest request = new OSRRequest
            {
                OSRDetails= OSRDetails,  
                Customeraccount = Customeraccount,
                _salesId = SalesId, 
                _companyId = CompanyId, 
                _currencyCode = CurrencyCode
            };

            HTTPClientWrapper<ZonOSRRequestContract[]> hTTPClientWrapper = new HTTPClientWrapper<ZonOSRRequestContract[]>(_configuration);

            var response = await hTTPClientWrapper.PostRequest(_configuration.GetSection("FnoGetOSRSummary").Value, request);

            return response;
        }

        public async Task<PurchaseAgreementData[]> GetSPADetails(string CustomerAccount, string EDPNumber, decimal ItemQuantity, string ShippingDate, string _companyId, string _currencyCode)
        {
            SPARequest request = new SPARequest 
            { 
                CustomerAccount= CustomerAccount,  
                EDPNumber = EDPNumber , 
                ItemQuantity= ItemQuantity,                                 
                ShippingDate= ShippingDate, 
                _companyId = _companyId , 
                _currencyCode= _currencyCode    
            };

            HTTPClientWrapper<PurchaseAgreementData[]> hTTPClientWrapper = new HTTPClientWrapper<PurchaseAgreementData[]>(_configuration);

            var response = await hTTPClientWrapper.PostRequest(_configuration.GetSection("FnoGetSPADetails").Value, request);

            return response;
        }
        public async Task<BasicProductDetails[]> getBasicProducts(ProductFnORequest productRequest)
        {
            int roundoff = (productRequest.p_VPARoundingOff is NoYes.Yes) ? 1 : 0;
            BasicProductReq request = new BasicProductReq
            {
                Country = productRequest.CurrencyCode,
                customerAccount = productRequest.p_AXAccountNum,
                _companyId = productRequest.sCallContextCompany,
                _currencyCode = productRequest.CurrencyCode,
                _edpList = productRequest.sEDP,
                _offerCode = productRequest.p_CountryCode,
                roundOff = roundoff
            };
            HTTPClientWrapper<BasicProductDetails[]> hTTPClientWrapper = new HTTPClientWrapper<BasicProductDetails[]>(_configuration);
            var response = await hTTPClientWrapper.PostRequest(_configuration.GetSection("FnoGetBasicProduct").Value, request);
            return response;
        }
    }
}
