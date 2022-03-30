using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Order
{
    public class OrderItem
    {
        internal string Contract;
        //public string ContractId { get; set; }
        public string ItemId { get; set; }
        public string EDPNumber { get; set; }
        public string SKU { get; set; }
        public string MfrPartNumber { get; set; }
        public string MfrName { get; set; }
        public string Description { get; set; }
        public string DestinationIndex { get; set; }
        public string LineNumber { get; set; }
        public decimal DisplayPrice { get; set; }
        public decimal SellPrice { get; set; }
        public double Weight { get; set; }
        public decimal Qty { get; set; }
        public string Status { get; set; }
        public string RecyclingCode { get; set; }
        public string ZonSOLevel { get; set; }
        public string MarkupCode { get; set; }
        public string DestinationInfo { get; set; }
        public int? SequenceNo { get; set; }
        public int? LineComment { get; set; }
        public string MatGroup { get; set; }
        public string Currency { get; set; }
        public bool IsItemNonReturnable { get; set; }
        public int PricingLimitation { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string ShippingContact { get; set; }
        public string DeliveryName { get; set; }
        public decimal? RecyclingValue { get; set; }
        public int? NeedByQualifier { get; set; }
        public DateTime? NeedByDate { get; set; }
        public string CarrierName { get; set; }
        public List<TrackingNumberDetail> TrackingNumber { get; set; }
    }
}
