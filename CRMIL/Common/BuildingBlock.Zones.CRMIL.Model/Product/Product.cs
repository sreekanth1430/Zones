using BuildingBlock.Core.Model;
using BuildingBlock.Zones.CRMIL.Model.Product.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Product
{
    public class Product : BaseResponse
    {
        public Product()
        {
        }

        public Product(BasicProductDetails p_AXProduct)
        {
            AXProduct = p_AXProduct;
            this.EDP = p_AXProduct.EDP;
            this.SellPrice = (decimal)p_AXProduct.SellPrice;
            this.WebPrice = (decimal)p_AXProduct.WebPrice;
            this.Margin = (decimal)p_AXProduct.Margin;
        }

        public string EDP { get; set; }

        public BasicProductDetails AXProduct { get; set; }

        //public CRMIL.DA.Interfaces.AX.Product.Product AXProductExtended { get; set; }
        public Product AXProductExtended { get; set; }
        public decimal WebPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal Margin { get; set; }
        public string PreviewImage { get; set; }
        public string FullImage { get; set; }
        //public List<OraProductSpec> Specification { get; set; }
        public OraProductSpec Specification { get; set; }
        public OraProductSummary Summary { get; set; }
        //public List<AdditionalSells> RelatedItems { get; set; }
        public AdditionalSells RelatedItems { get; set; }
        public string UNSPSC { get; set; }
        public string BigImage { get; set; }
    }
}
