using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Shipping
{
    public class ShipLineDetails
    {
        public string ShipFromLocation { get; set; }
        public decimal Weight { get; set; }

        //private bool weightFieldSpecified;

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        //public string ShipFromLocation
        //{
        //    get
        //    {
        //        return this.shipFromLocationField;
        //    }
        //    set
        //    {
        //        this.shipFromLocationField = value;
        //    }
        //}

        ///// <remarks/>
        //public decimal Weight
        //{
        //    get
        //    {
        //        return this.weightField;
        //    }
        //    set
        //    {
        //        this.weightField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool WeightSpecified
        //{
        //    get
        //    {
        //        return this.weightFieldSpecified;
        //    }
        //    set
        //    {
        //        this.weightFieldSpecified = value;
        //    }
        //}
    }
}
