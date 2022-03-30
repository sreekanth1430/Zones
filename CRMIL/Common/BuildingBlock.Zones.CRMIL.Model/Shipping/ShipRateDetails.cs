using BuildingBlock.Zones.CRMIL.Model.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Shipping
{
    public class ShipRateDetails
    {
        public bool CustomerOverride { get; set; }
        public int DisplaySeq { get; set; }
        public string Description { get; set; }
        public int IsOvernight { get; set; }
        public decimal MarginCalculation { get; set; }
        public string OverrideReason { get; set; }
        public decimal ShipBaseRate { get; set; }
        public string ShipMethod { get; set; }
        public decimal ShipRate { get; set; }
        public bool IsUpDownliftapplied { get; set; }
        public decimal UpliftPercent { get; set; }
        public decimal DownliftPercent { get; set; }
        //public bool CustOverride { get; set; }
        //public string CustOverrideReason { get; set; }
        public string MethodCode { get; set; }
        //public string MethodTx { get; set; }
        public decimal Rate { get; set; }
        //public decimal Margin { get; set; }
        //public decimal BasicRate { get; set; }
        //public int DisplaySeq { get; set; }
        public int MethodCounts { get; set; }
        //public bool Overnight { get; set; }
        public List<AdditionalFreightRate> AdditionalFreightRates { get; set; }
        //// To calculate Cost get rate before applying Account Level Uplift/Margin to 
        //public decimal Cost
        //{
        //    get
        //    {
        //        //Formula : (100*ValueAfterUplift)/(100+PercentageApplied)
        //        //return Margin == -100 ? 0 : (100 * BasicRate) / (100 + Margin);

        //        return Margin == 0 ? BasicRate : Math.Round((BasicRate) / Margin, 2);
        //    }
        //}
        //public decimal DownliftPercent { get; set; }
        //public bool IsUpDownliftapplied { get; set; }
        //public decimal UpliftPercent { get; set; }
    }
}
