using BuildingBlock.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel
{
    //public class APIResponse : BaseResponse 
    //{ 
    //    //public List<OrderResponseData> OrderResponseData { get; set; }

    //} 

    public class OrderResponseData
    {
        [JsonProperty("$id")]
        public string Id { get; set; }
        public string SalesPool { get; set; }
        public string CustomerBuyer { get; set; }
        public OrderComment[] Comments { get; set; }
        public string OrderSource { get; set; }
        public long SalesOrderRecId { get; set; }
        public double TotalTaxAmount { get; set; }
        public double FreightCharges { get; set; }
        public string FreightCode { get; set; }
        public double FreightCost { get; set; }
        public int FreightType { get; set; }
        public int InvoiceCount { get; set; }
        public DateTime LastShipment { get; set; }
        public List<SalesLevelDetails> SalesLevelDetails { get; set; }
        public string SalesOrderNumber { get; set; }
        public string SalesPoolName { get; set; }
        public int ShipmentCount { get; set; }
        public int SuppressInvoice { get; set; }
        public string TaxExemptionType { get; set; }
        public string CurrencyCode { get; set; }
    }

}
