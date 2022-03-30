using BuildingBlock.Zones.CRMIL.Model.Product;
using BuildingBlock.Zones.Model.Product;
using BuildingBlock.Zones.Model.Product.RequestModel;
using BuildingBlock.Zones.Model.Product.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BuildingBlock.Zones.CRMIL.Model.Product.Enum.ProductEnums;

namespace BuildingBlock.Zones.CRMIL.Service
{
    public interface IProductService
    {
        public Task<PurchaseAgreementData[]> SelectSPADetails(string sAccountNumber, string sEdpNumber, decimal dcQuantity, string dtShippingDate, string sCallContextCompany, string CurrencyCode);
        public Task<ZonOSRRequestContract[]> GetOSRSummaryData( ZonOSRRequestContract[] OSRDetails, string Customeraccount, string SalesId, string CallContextCompany, string CurrencyCcode);
        public Product searchproduct();
        public Task<List<Product>> SelectProductList(ProductSearch ProductSearch);
        public List<OraProduct> SelectProduct(string[] p_Product);
    }
}
