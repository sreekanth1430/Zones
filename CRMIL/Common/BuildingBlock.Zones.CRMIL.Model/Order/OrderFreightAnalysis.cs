using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Order
{
    public class OrderFreightAnalysis
    {
        public string SalesId { get; set; }
        public string DeliveryMode { get; set; }
        public string DeliveryModeName { get; set; }
        public string OverrideCode { get; set; }
        public float ShippingAmt { get; set; }
        public float SuggestedAmt { get; set; }
        public float ShippingCost { get; set; }
        public float LevelWeight { get; set; }
        public string CustFreightAcct { get; set; }
        public string OverrideCodeDesc { get; set; }
        public string AXLevelName { get; set; }
        public float ResidentialChargeProposed { get; set; }
        public float OutOfAreaChargeProposed { get; set; }
    }
}
