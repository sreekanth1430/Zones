using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Shipping
{
    public class ShipMethodRate
    {
        private AdditionalFreightRate[] additionalFreightRatesField;

        private bool customerOverrideField;

        private bool customerOverrideFieldSpecified;

        private string descriptionField;

        private int displaySeqField;

        private bool displaySeqFieldSpecified;

        private decimal downliftPercentField;

        private bool downliftPercentFieldSpecified;

        private NoYes isOvernightField;

        private bool isOvernightFieldSpecified;

        private bool isUpDownliftappliedField;

        private bool isUpDownliftappliedFieldSpecified;

        private decimal marginCalculationField;

        private bool marginCalculationFieldSpecified;

        private string overrideReasonField;

        private decimal shipBaseRateField;

        private bool shipBaseRateFieldSpecified;

        private string shipMethodField;

        private decimal shipRateField;

        private bool shipRateFieldSpecified;

        private decimal upliftPercentField;

        private bool upliftPercentFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public AdditionalFreightRate[] AdditionalFreightRates
        {
            get
            {
                return this.additionalFreightRatesField;
            }
            set
            {
                this.additionalFreightRatesField = value;
            }
        }

        /// <remarks/>
        public bool CustomerOverride
        {
            get
            {
                return this.customerOverrideField;
            }
            set
            {
                this.customerOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomerOverrideSpecified
        {
            get
            {
                return this.customerOverrideFieldSpecified;
            }
            set
            {
                this.customerOverrideFieldSpecified = value;
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
        public int DisplaySeq
        {
            get
            {
                return this.displaySeqField;
            }
            set
            {
                this.displaySeqField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplaySeqSpecified
        {
            get
            {
                return this.displaySeqFieldSpecified;
            }
            set
            {
                this.displaySeqFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal DownliftPercent
        {
            get
            {
                return this.downliftPercentField;
            }
            set
            {
                this.downliftPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DownliftPercentSpecified
        {
            get
            {
                return this.downliftPercentFieldSpecified;
            }
            set
            {
                this.downliftPercentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public NoYes IsOvernight
        {
            get
            {
                return this.isOvernightField;
            }
            set
            {
                this.isOvernightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsOvernightSpecified
        {
            get
            {
                return this.isOvernightFieldSpecified;
            }
            set
            {
                this.isOvernightFieldSpecified = value;
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
        public decimal MarginCalculation
        {
            get
            {
                return this.marginCalculationField;
            }
            set
            {
                this.marginCalculationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarginCalculationSpecified
        {
            get
            {
                return this.marginCalculationFieldSpecified;
            }
            set
            {
                this.marginCalculationFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string OverrideReason
        {
            get
            {
                return this.overrideReasonField;
            }
            set
            {
                this.overrideReasonField = value;
            }
        }

        /// <remarks/>
        public decimal ShipBaseRate
        {
            get
            {
                return this.shipBaseRateField;
            }
            set
            {
                this.shipBaseRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipBaseRateSpecified
        {
            get
            {
                return this.shipBaseRateFieldSpecified;
            }
            set
            {
                this.shipBaseRateFieldSpecified = value;
            }
        }

        /// <remarks/>
       
        public string ShipMethod
        {
            get
            {
                return this.shipMethodField;
            }
            set
            {
                this.shipMethodField = value;
            }
        }

        /// <remarks/>
        public decimal ShipRate
        {
            get
            {
                return this.shipRateField;
            }
            set
            {
                this.shipRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipRateSpecified
        {
            get
            {
                return this.shipRateFieldSpecified;
            }
            set
            {
                this.shipRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal UpliftPercent
        {
            get
            {
                return this.upliftPercentField;
            }
            set
            {
                this.upliftPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpliftPercentSpecified
        {
            get
            {
                return this.upliftPercentFieldSpecified;
            }
            set
            {
                this.upliftPercentFieldSpecified = value;
            }
        }
    }
}
