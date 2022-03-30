using BuildingBlock.Core.Model;
using BuildingBlock.Zones.CRMIL.Model.Order.OrderRecall.ResponseModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel
{
    public class SalesLevelDetails
    {
        [JsonProperty("$id")]
        public string Id { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        public string DeliveryContactName { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryMode { get; set; }
        public string DeliveryModeName { get; set; }
        public string DeliveryName { get; set; }
        public string InvoiceDocumentNum { get; set; }
        public string Level { get; set; }
        public List<LevelLineDetails> LevelLineDetails { get; set; }
        public string PackingSlipId { get; set; }
        public DateTime ShipmentCreatedDateTime { get; set; }
        public double TaxAmount { get; set; }
        public string CurrencyCode { get; set; }
        public string TermsOfDelivery { get; set; }
        public string TermsOfDeliveryDescription { get; set; }
        public string CarrierAccountNumber { get; set; }
        public int IsOverNight { get; set; }
        public string DeliveryEmail { get; set; }
        public string DeliveryContact { get; set; }
    }
}
