using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Shipping
{
    public class OrderDetailsForFreightCalc
    {
        private string divisionField;

        private string onyxIdField;

        private ShipToDetails[] shipToDetailsField;

        /// <remarks/>
        
        public string Division
        {
            get
            {
                return this.divisionField;
            }
            set
            {
                this.divisionField = value;
            }
        }

        /// <remarks/>
       
        public string OnyxId
        {
            get
            {
                return this.onyxIdField;
            }
            set
            {
                this.onyxIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ShipToDetails[] ShipToDetails
        {
            get
            {
                return this.shipToDetailsField;
            }
            set
            {
                this.shipToDetailsField = value;
            }
        }
    }
}
