using BuildingBlock.Zones.CRMIL.Model.Product;
using BuildingBlock.Zones.CRMIL.Model.Product.RequestModel;
using BuildingBlock.Zones.CRMIL.Model.Product.ResponseModel;
using BuildingBlock.Zones.CRMIL.Repo;
using BuildingBlock.Zones.CRMIL.Repo.Oracle;
using BuildingBlock.Zones.Model.Customer.Enum;
using BuildingBlock.Zones.Model.Product;
using BuildingBlock.Zones.Model.Product.RequestModel;
using BuildingBlock.Zones.Model.Product.ResponseModel;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BuildingBlock.Zones.CRMIL.Model.Product.Enum.ProductEnums;

namespace BuildingBlock.Zones.CRMIL.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _ProductRepository;

        private readonly IConfiguration _configuration;
        public ProductService(IProductRepository ProductRepository, IConfiguration configuration)
        {
            _ProductRepository = ProductRepository;
            _configuration = configuration;
        }

        public async Task<ZonOSRRequestContract[]> GetOSRSummaryData( ZonOSRRequestContract[] _OSRDetails, string _Customeraccount, string _SalesId, string CompaneyId, string CurrencyCode)
        {
            if (!String.IsNullOrEmpty(_Customeraccount))
            {
                var result = await _ProductRepository.GetOSRSummary(_OSRDetails, _Customeraccount, _SalesId, CompaneyId, CurrencyCode);
                return result;
            }
            else
            {
                return null;
            }
        }

        public Product searchproduct()
        {
            Product product = new Product();
            product.BigImage = "null"; product.PreviewImage = "null"; product.FullImage = "null"; product.UNSPSC = "null"; product.EDP = "null";

            var oraProductSpec = new OraProductSpec();
            oraProductSpec.Header = "null"; oraProductSpec.Id = "null"; oraProductSpec.Section = "null"; oraProductSpec.Value = "null";
            product.Specification = oraProductSpec;

            var summary = new OraProductSummary();
            summary.Body = "null"; summary.Id = "null"; summary.Header = "null";
            product.Summary = summary;

            var additionalSells = new AdditionalSells();
            additionalSells.DISPLAY_ACCESS_NM = "null"; additionalSells.FullImage = "null"; additionalSells.Id = "null"; additionalSells.NAME = "null"; additionalSells.OID = "null"; additionalSells.PreviewImage = "null"; additionalSells.PROD_ID = "null";
            product.RelatedItems = additionalSells;
            

            return product;
        }

        public async Task<PurchaseAgreementData[]> SelectSPADetails(string sAccountNumber, string sEdpNumber, decimal dcQuantity, string dtShippingDate, string sCallContextCompany, string CurrencyCode)
        {
            if (!String.IsNullOrEmpty(sAccountNumber))
            {
                List<string> lstSPAData = new List<string>();
                string dt = (String.IsNullOrEmpty(dtShippingDate) ? (DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day) : dtShippingDate);
                var CompaneyId = sCallContextCompany;
                var arPurchaseData = await _ProductRepository.GetSPADetails(sAccountNumber, sEdpNumber, dcQuantity, dt, CompaneyId, CurrencyCode);
                return arPurchaseData;
            }
            else
            {
                return null;
            }
        }
        public async Task<List<Product>> SelectProductList(ProductSearch ProductSearch)
        {
            NoYes roundoff = (ProductSearch.VPARoundOff is true) ? NoYes.Yes : NoYes.No;
            ProductFnORequest productFnORequest = new ProductFnORequest() 
            {
                sCallContextCompany = ProductSearch.CallContextCompany,
                sEDP = ProductSearch.EDPList,p_VPACode = ProductSearch.VPACode,p_AXAccountNum = ProductSearch.AXAccountNum,
                p_CountryCode = ProductSearch.CountryCode,CurrencyCode = "",p_VPARoundingOff=roundoff
            };

            if (String.IsNullOrEmpty(productFnORequest.p_VPACode))
            {
                productFnORequest.p_VPACode = _configuration.GetSection("CallContextCompany").GetSection("DefaultVPACode").Value;
            }

            Model.Product.ResponseModel.BasicProductDetails[] oArrProduct = new Model.Product.ResponseModel.BasicProductDetails[0];
            oArrProduct = await _ProductRepository.getBasicProducts(productFnORequest);

            //Get information from Oracle for EDPs not in AX
            try
            {
                var edpsNotInAX = productFnORequest.sEDP.Where(e => oArrProduct.Select(p => p.EDP).Contains(e) == false).ToArray();
                if (edpsNotInAX != null && edpsNotInAX.Count() > 0)
                {
                    var axProductsList = oArrProduct.ToList();
                    var oraProductsList = SelectProduct(edpsNotInAX);
                    foreach (var product in oraProductsList)
                    {
                        axProductsList.Add(
                            new Model.Product.ResponseModel.BasicProductDetails
                            {
                                AxProductId = product.AxProductId,
                                CategoryCode = product.CategoryCode,
                                Configuration = product.Configuration,
                                Description = product.Description,
                                DisplayCost = (double)product.DisplayCost,
                                //    DisplayStatus = ZonDisplayStatus.ZACAndWeb,
                                EDP = product.PROD_ID,
                                ItemTaxGroup = product.ItemTaxGroup,
                                ManufacturerName = product.ManufacturerName,
                                MfgrPartNo = product.MfgrPartNo,
                                ProductName = product.ProductName,
                                QuotePrice = (double)product.QuotePrice,
                                SKU = product.SKU,
                                ShipWeight = (double)product.ShipWeight,
                                Status = product.Status,
                                StockStatusMessage = product.StockStatusMessage,
                                SystemPrice = (double)product.SystemPrice
                            }
                        );
                    }
                    oArrProduct = axProductsList.ToArray();
                }
            }
            catch (Exception ex)
            {

            }

            List<Product> lstProduct = new List<Product>();
            Product oProduct = null;

            // Set each object from AX to the custom Product object
            if (oArrProduct != null)
            {
                for (int i = 0; i < oArrProduct.Length; i++)
                {
                    oProduct = new Product(oArrProduct[i]);
                    lstProduct.Add(oProduct);
                }
            }

            // Get the list of products from oracle.
            List<OraProduct> lstOraProduct = null;
            try
            {
                if (productFnORequest.sEDP.Length > 0)
                    lstOraProduct = SelectProduct(productFnORequest.sEDP);
            }
            catch (Exception ex)
            {

            }

            // for each product in the AX list, find a matching oracle object and add it to the product object
            if (lstOraProduct != null)
            {
                if (lstOraProduct.Count > 0)
                {
                    for (int i = 0; i < lstProduct.Count; i++)
                    {
                        oProduct = lstProduct[i];
                        // Add the oracle product to the crm product object.
                        var oMatch = (from oraProduct in lstOraProduct
                                      where (oraProduct.PROD_ID.Equals(oProduct.AXProduct.EDP))
                                      select oraProduct).SingleOrDefault();
                        if (oMatch != null)
                        {
                            oProduct.PreviewImage = oMatch.PreviewImage;
                            oProduct.FullImage = oMatch.FullImage;
                            oProduct.UNSPSC = oMatch.UNSPSC;
                        }
                    }
                }
            }

            return lstProduct;
        }
        public List<OraProduct> SelectProduct(string[] p_Product)
        {
            string IMG_GENERIC = "generic75.jpg";  //constants

            List<OraProduct> lstProduct = new List<OraProduct>();
            string sQueryProduct = "";
            // the oracle procedure requires the EDP numbers in the format 90,002,9891,
            // The comma at the end is required and single quotes are not required
            if (p_Product.Length > 0)
            {
                for (int i = 0; i < p_Product.Length; i++)
                {
                    if (i > 0 && !sQueryProduct.EndsWith(","))
                        sQueryProduct += ",";

                    sQueryProduct += "'" + p_Product[i] + "'";
                }

                Dictionary<string, string> oParameter = new Dictionary<string, string>();
                oParameter.Add("I_PRODUCTS_STRING", sQueryProduct);

                //create object for DataAccessORA class 
                DataAccessORA s = new DataAccessORA();
                DataSet ds = s.Select(PackageName.DB_ORA_PACKAGE_PRODUCT_INFO + "." + ProcedureName.DB_ORA_PROC_GET_PRODUCT, oParameter);

                if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    OraProduct oraProduct = null;
                    string sURL = _configuration.GetSection("CallContextCompany").GetSection("Product_Image_URL").Value;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        oraProduct = new OraProduct();
                        oraProduct.PROD_ID = ds.Tables[0].Rows[i]["PROD_ID"].ToString();
                        oraProduct.AxProductId = ds.Tables[0].Rows[i]["AX_ID"].ToString();
                        oraProduct.SKU = ds.Tables[0].Rows[i]["SKU"].ToString();
                        oraProduct.Configuration = ds.Tables[0].Rows[i]["CONFIGURATION"].ToString();
                        oraProduct.CategoryCode = ds.Tables[0].Rows[i]["CAT_CD"].ToString();
                        oraProduct.ProductName = ds.Tables[0].Rows[i]["NAME"].ToString();
                        oraProduct.Description = ds.Tables[0].Rows[i]["LONG_NM"].ToString();
                        oraProduct.DisplayCost = Convert.ToDecimal(ds.Tables[0].Rows[i]["COST"]);
                        oraProduct.SystemPrice = Convert.ToDecimal(ds.Tables[0].Rows[i]["PRICE"]);
                        oraProduct.QuotePrice = Convert.ToDecimal(ds.Tables[0].Rows[i]["MINIMUM_PRICE_CY"]);
                        oraProduct.ItemTaxGroup = ds.Tables[0].Rows[i]["TAX_CD"].ToString();
                        oraProduct.ManufacturerName = ds.Tables[0].Rows[i]["MFR_NM"].ToString();
                        oraProduct.MfgrPartNo = ds.Tables[0].Rows[i]["MFR_PART_NO"].ToString();
                        oraProduct.ShipWeight = Convert.ToDecimal(ds.Tables[0].Rows[i]["WEIGHT"]);
                        oraProduct.Status = ds.Tables[0].Rows[i]["STATUS_CD"].ToString();
                        oraProduct.StockStatusMessage = ds.Tables[0].Rows[i]["STOCK_STATUS_TX"].ToString();

                        oraProduct.BigImage = sURL + Convert.ToString(ds.Tables[0].Rows[i]["BIG_IMAGE"]);
                        oraProduct.FullImage = sURL + Convert.ToString(ds.Tables[0].Rows[i]["FULL_IMAGE"]);
                        if (ds.Tables[0].Rows[i]["preview_image"] != null)
                        {
                            oraProduct.PreviewImage = sURL + ds.Tables[0].Rows[i]["preview_image"].ToString();
                        }
                        else
                        {
                            oraProduct.PreviewImage = sURL + IMG_GENERIC;
                        }

                        var tUNSPSC = ds.Tables[0].Rows[i]["UNSPSC"];
                        oraProduct.UNSPSC = (tUNSPSC != null && tUNSPSC != DBNull.Value && !string.IsNullOrWhiteSpace(tUNSPSC.ToString())) ? tUNSPSC.ToString() : "";

                        lstProduct.Add(oraProduct);
                    }
                }
            }
            return lstProduct;
        }
    }
}
