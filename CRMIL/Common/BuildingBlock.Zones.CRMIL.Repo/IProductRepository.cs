using BuildingBlock.Zones.CRMIL.Model.Product.RequestModel;
using BuildingBlock.Zones.CRMIL.Model.Product.ResponseModel;
using BuildingBlock.Zones.Model.Customer.Enum;
using BuildingBlock.Zones.Model.Product.RequestModel;
using BuildingBlock.Zones.Model.Product.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Repo
{
    public interface IProductRepository
    {
        Task<PurchaseAgreementData[]> GetSPADetails(string CustomerAccount,string EDPNumber,Decimal ItemQuantity,string ShippingDate,string _companyId,string _currencyCode);
        Task<ZonOSRRequestContract[]> GetOSRSummary(ZonOSRRequestContract[] OSRDetails, string Customeraccount, string _salesId, string _companyId, string _currencyCode);
        Task<BasicProductDetails[]> getBasicProducts(ProductFnORequest productFnORequest);
    }
}
