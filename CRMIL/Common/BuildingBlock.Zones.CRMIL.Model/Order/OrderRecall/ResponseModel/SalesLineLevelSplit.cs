using BuildingBlock.Core.Model;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.Enum;
using Newtonsoft.Json;

namespace BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel
{
    public partial class SalesLineLevelSplit
    {
        public decimal FreightChargesFiel { get; set; }
        public bool FreightChargesFieldSpecifiedValue { get; set; }

    }

    public partial class SalesLineLevelSplit : BaseResponse, IBaseEntity
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        private decimal FreightChargesField { get; set; }

        private bool FreightChargesFieldSpecified { get; set; }

        private string FreightCodeField { get; set; }

        private decimal FreightCostField { get; set; }

        private bool FreightCostFieldSpecified { get; set; }

        private MarkupCategory freightTypeField { get; set; }

        private bool FreightTypeFieldSpecified { get; set; }

        private int InvoiceCountField { get; set; }

        private bool InvoiceCountFieldSpecified { get; set; }

        private System.DateTime LastShipmentField { get; set; }

        private bool LastShipmentFieldSpecified { get; set; }

        private SalesLevelDetails[] SalesLevelDetailsField { get; set; }

        private string SalesOrderNumberField { get; set; }

        private string SalesPoolNameField { get; set; }

        private int ShipmentCountField { get; set; }

        private bool ShipmentCountFieldSpecified { get; set; }

        private NoYes SuppressInvoiceField { get; set; }

        private bool SuppressInvoiceFieldSpecified { get; set; }

        private string TaxExemptionTypeField { get; set; }

        /// <remarks/>
        public decimal FreightCharges
        {
            get
            {
                return this.FreightChargesField;
            }
            set
            {
                this.FreightChargesField = value;
            }
        }

        /// <remarks/>
        [JsonIgnore]
        public bool FreightChargesSpecified
        {
            get
            {
                return this.FreightChargesFieldSpecified;
            }
            set
            {
                this.FreightChargesFieldSpecified = value;
            }
        }

        /// <remarks/>
       #nullable enable
        public string FreightCode
        {
            get
            {
                return this.FreightCodeField;
            }
            set
            {
                this.FreightCodeField = value;
            }
        }
        #nullable disable
        /// <remarks/>
        public decimal FreightCost
        {
            get
            {
                return this.FreightCostField;
            }
            set
            {
                this.FreightCostField = value;
            }
        }

        /// <remarks/>
       [JsonIgnore]
        public bool FreightCostSpecified
        {
            get
            {
                return this.FreightCostFieldSpecified;
            }
            set
            {
                this.FreightCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public MarkupCategory FreightType
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
        [JsonIgnore]
        public bool FreightTypeSpecified
        {
            get
            {
                return this.FreightTypeFieldSpecified;
            }
            set
            {
                this.FreightTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int InvoiceCount
        {
            get
            {
                return this.InvoiceCountField;
            }
            set
            {
                this.InvoiceCountField = value;
            }
        }

        /// <remarks/>
        [JsonIgnore]
        public bool InvoiceCountSpecified
        {
            get
            {
                return this.InvoiceCountFieldSpecified;
            }
            set
            {
                this.InvoiceCountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime LastShipment
        {
            get
            {
                return this.LastShipmentField;
            }
            set
            {
                this.LastShipmentField = value;
            }
        }

        /// <remarks/>
        [JsonIgnore]
        public bool LastShipmentSpecified
        {
            get
            {
                return this.LastShipmentFieldSpecified;
            }
            set
            {
                this.LastShipmentFieldSpecified = value;
            }
        }

        /// <remarks/>
        #nullable enable
        public SalesLevelDetails?[] SalesLevelDetails
        {
            get
            {
                return this.SalesLevelDetailsField;
            }
            set
            {
                this.SalesLevelDetailsField = value;
            }
        }
       
        /// <remarks/>
        
        public string? SalesOrderNumber
        {
            get
            {
                return this.SalesOrderNumberField;
            }
            set
            {
                this.SalesOrderNumberField = value;
            }
        }

        /// <remarks/>
        
        public string? SalesPoolName
        {
            get
            {
                return this.SalesPoolNameField;
            }
            set
            {
                this.SalesPoolNameField = value;
            }
        }
        #nullable disable
        /// <remarks/>
        public int ShipmentCount
        {
            get
            {
                return this.ShipmentCountField;
            }
            set
            {
                this.ShipmentCountField = value;
            }
        }

        /// <remarks/>
        [JsonIgnore]
        public bool ShipmentCountSpecified
        {
            get
            {
                return this.ShipmentCountFieldSpecified;
            }
            set
            {
                this.ShipmentCountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public NoYes SuppressInvoice
        {
            get
            {
                return this.SuppressInvoiceField;
            }
            set
            {
                this.SuppressInvoiceField = value;
            }
        }

        /// <remarks/>
       [JsonIgnore]
        public bool SuppressInvoiceSpecified
        {
            get
            {
                return this.SuppressInvoiceFieldSpecified;
            }
            set
            {
                this.SuppressInvoiceFieldSpecified = value;
            }
        }

        /// <remarks/>
        #nullable enable
        public string TaxExemptionType
        {
            get
            {
                return this.TaxExemptionTypeField;
            }
            set
            {
                this.TaxExemptionTypeField = value;
            }
        }
        #nullable disable
    }
}
