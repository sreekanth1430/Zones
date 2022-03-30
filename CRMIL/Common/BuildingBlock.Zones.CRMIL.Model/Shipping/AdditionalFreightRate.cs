using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Shipping
{
    public class AdditionalFreightRate
    {
        private decimal costField;

        private bool costFieldSpecified;

        private string descriptionField;

        private string dlvModeIdField;

        private string freightCodeField;

        private ZonAddtionalFreightType freightTypeField;

        private bool freightTypeFieldSpecified;

        private bool isRequiredField;

        private bool isRequiredFieldSpecified;

        private bool isUpDownliftappliedField;

        private bool isUpDownliftappliedFieldSpecified;

        private decimal rateField;

        private bool rateFieldSpecified;

        /// <remarks/>
        public decimal Cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CostSpecified
        {
            get
            {
                return this.costFieldSpecified;
            }
            set
            {
                this.costFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        
        public string DlvModeId
        {
            get
            {
                return this.dlvModeIdField;
            }
            set
            {
                this.dlvModeIdField = value;
            }
        }

        /// <remarks/>
        
        public string FreightCode
        {
            get
            {
                return this.freightCodeField;
            }
            set
            {
                this.freightCodeField = value;
            }
        }

        /// <remarks/>
        public ZonAddtionalFreightType FreightType
        {
            get
            {
                return this.freightTypeField;
            }
            set
            {
                this.freightTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FreightTypeSpecified
        {
            get
            {
                return this.freightTypeFieldSpecified;
            }
            set
            {
                this.freightTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsRequired
        {
            get
            {
                return this.isRequiredField;
            }
            set
            {
                this.isRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsRequiredSpecified
        {
            get
            {
                return this.isRequiredFieldSpecified;
            }
            set
            {
                this.isRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsUpDownliftapplied
        {
            get
            {
                return this.isUpDownliftappliedField;
            }
            set
            {
                this.isUpDownliftappliedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsUpDownliftappliedSpecified
        {
            get
            {
                return this.isUpDownliftappliedFieldSpecified;
            }
            set
            {
                this.isUpDownliftappliedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateSpecified
        {
            get
            {
                return this.rateFieldSpecified;
            }
            set
            {
                this.rateFieldSpecified = value;
            }
        }
    }
}
