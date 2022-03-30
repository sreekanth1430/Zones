using BuildingBlock.Core.Model;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel
{
    public partial class LevelLineDetails
    {
        [JsonProperty("$id")]
        public string Id { get; set; }
        public string WarehouseName { get; set; }
        public double ItemCost { get; set; }
        public string SPA { get; set; }
        public int Complete { get; set; }
        public int ZonModifiable { get; set; }
        public double DiscountAmount { get; set; }
        public string CategoryManager { get; set; }
        public double Cost { get; set; }
        public string Status { get; set; }
        public double CPTPrice { get; set; }
        public string Description { get; set; }
        public string EDP { get; set; }
        public DateTime ETS { get; set; }
        public int HasSerialNum { get; set; }
        public int HasTrackingNum { get; set; }
        public int IsCustomerStandard { get; set; }
        public bool IsSplit { get; set; }
        public string ItemGroup { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public string ItemTaxGroup { get; set; }
        public double LineNumber { get; set; }
        public string LineStatus { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerPartNo { get; set; }
        public string Name { get; set; }
        public double OSR { get; set; }
        public DateTime OSRExpirationDate { get; set; }
        public string PONumber { get; set; }
        public double Quantity { get; set; }
        public object SalesLineRecid { get; set; }
        public string SKU { get; set; }
        public double TotalPrice { get; set; }
        public string CurrencyCode { get; set; }
        public string LineRefId { get; set; }
        public List<object> CustomizationNotes { get; set; }
        public string ExtProductNumber { get; set; }
        public string ExtCustProductNumber { get; set; }
        public string ExtPOLineNumber { get; set; }
        public int Stopped { get; set; }
        public double SystemPrice { get; set; }
    }
}
