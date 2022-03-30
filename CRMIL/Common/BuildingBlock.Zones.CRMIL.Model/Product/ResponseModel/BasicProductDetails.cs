using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Product.ResponseModel
{
    public class BasicProductDetails
    {
        [JsonProperty("$id")]
        public string Id { get; set; }
        public string ThumbImageURL { get; set; }
        public double DiscountAmount { get; set; }
        public double WebDiscountAmount { get; set; }
        public string UNSPSC { get; set; }
        public string CurrencyCode { get; set; }
        public int AllCustomizationFieldMandatory { get; set; }
        public string AxProductId { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryManager { get; set; }
        public string Configuration { get; set; }
        public int ConstrainedSKU { get; set; }
        public string Status { get; set; }
        public string CustomizationNotes { get; set; }
        public int CustomizationRequired { get; set; }
        public string Description { get; set; }
        public int DisplayStatus { get; set; }
        public string EDP { get; set; }
        public string MfgrPartNo { get; set; }
        public string Geography { get; set; }
        public int GoGetTheGreen { get; set; }
        public double ShipWeight { get; set; }
        public double QuotePrice { get; set; }
        public string SKU { get; set; }
        public string ItemTaxGroup { get; set; }
        public string ManufacturerName { get; set; }
        public double Margin { get; set; }
        public string MediaCode { get; set; }
        public double OSR { get; set; }
        public DateTime OSRExpirationDate { get; set; }
        public string ProductName { get; set; }
        public double DisplayCost { get; set; }
        public int RecycleFee { get; set; }
        public int Returnable { get; set; }
        public string ReviewQueue { get; set; }
        public double SystemPrice { get; set; }
        public double SellPrice { get; set; }
        public string ShipModeGroup { get; set; }
        public string StockStatusMessage { get; set; }
        public double VPA { get; set; }
        public double WebOSR { get; set; }
        public double WebPrice { get; set; }
        public string SITCProductId { get; set; }
        public int WebStandard { get; set; }
        public double LandedCost { get; set; }
        public double LandedCostPercent { get; set; }
        public double landedCostSystemPrice { get; set; }
        public bool isTSCService { get; set; }
        public bool isFinishedGood { get; set; }
        public bool CoverageGroup { get; set; }
        public int ProductionHorizonDays { get; set; }
        public bool TSCService { get; set; }
        public int TSCHorizonDays { get; set; }
        public bool isBAHConfig { get; set; }
        public bool isWsServiceItem { get; set; }
    }
}
