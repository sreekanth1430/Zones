using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Product
{
    public class OraProduct
    {
        public string PROD_ID { get; set; } //PROD_ID
        public string PreviewImage { get; set; } //PREVIEW_IMAGE
        public string FullImage { get; set; } //FULL_IMAGE

        public string AxProductId { get; set; } //AX_ID
        public string CategoryCode { get; set; } //CAT_CD
        public string Configuration { get; set; } //CONFIGURATION
        public string Description { get; set; } //LONG_NM
        public decimal DisplayCost { get; set; } //COST
        public string ItemTaxGroup { get; set; } //TAX_CD
        public string ManufacturerName { get; set; } //MFR_NM
        public string MfgrPartNo { get; set; } //MFR_PART_NO
        public string ProductName { get; set; } //NAME
        public decimal QuotePrice { get; set; } //MINIMUM_PRICE_CY
        public string SKU { get; set; } //SKU
        public decimal ShipWeight { get; set; } //WEIGHT
        public string Status { get; set; } //STATUS_CD
        public string StockStatusMessage { get; set; } //STOCK_STATUS_TX
        public decimal SystemPrice { get; set; } //PRICE
        public string UNSPSC { get; set; }
        public string BigImage { get; set; }
    }
}
