using BuildingBlock.Zones.CRMIL.Model.Product.Enums;
using BuildingBlock.Zones.CRMIL.Model.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Product
{
    public partial class BasicProductDetail 
    {
        private NoYes allCustomizationFieldMandatoryField;

        private bool allCustomizationFieldMandatoryFieldSpecified;

        private string axProductIdField;

        private string categoryCodeField;

        private string categoryManagerField;

        private string configurationField;

        private NoYes constrainedSKUField;

        private bool constrainedSKUFieldSpecified;

        private bool coverageGroupField;

        private bool coverageGroupFieldSpecified;

        private string customizationNotesField;

        private NoYes customizationRequiredField;

        private bool customizationRequiredFieldSpecified;

        private string descriptionField;

        private decimal discountAmountField;

        private bool discountAmountFieldSpecified;

        private decimal displayCostField;

        private bool displayCostFieldSpecified;

        private ZonDisplayStatus displayStatusField;

        private bool displayStatusFieldSpecified;

        private string eDPField;

        private string geographyField;

        private ZonGGTG goGetTheGreenField;

        private bool goGetTheGreenFieldSpecified;

        private string itemTaxGroupField;

        private decimal landedCostField;

        private bool landedCostFieldSpecified;

        private decimal landedCostPercentField;

        private bool landedCostPercentFieldSpecified;

        private string manufacturerNameField;

        private decimal marginField;

        private bool marginFieldSpecified;

        private string mediaCodeField;

        private string mfgrPartNoField;

        private decimal oSRField;

        private bool oSRFieldSpecified;

        private System.DateTime oSRExpirationDateField;

        private bool oSRExpirationDateFieldSpecified;

        private decimal palletQtyField;

        private bool palletQtyFieldSpecified;

        private string productNameField;

        private int productionHorizonDaysField;

        private bool productionHorizonDaysFieldSpecified;

        private decimal quotePriceField;

        private bool quotePriceFieldSpecified;

        private ZonRecycleFee recycleFeeField;

        private bool recycleFeeFieldSpecified;

        private NoYes returnableField;

        private bool returnableFieldSpecified;

        private string reviewQueueField;

        private string sKUField;

        private decimal sellPriceField;

        private bool sellPriceFieldSpecified;

        private string serviceItemBAHField;

        private string shipModeGroupField;

        private decimal shipWeightField;

        private bool shipWeightFieldSpecified;

        private string statusField;

        private string stockStatusMessageField;

        private decimal systemPriceField;

        private bool systemPriceFieldSpecified;

        private int tSCHorizonDaysField;

        private bool tSCHorizonDaysFieldSpecified;

        private bool tSCServiceField;

        private bool tSCServiceFieldSpecified;

        private decimal vPAField;

        private bool vPAFieldSpecified;

        private decimal webDiscountAmountField;

        private bool webDiscountAmountFieldSpecified;

        private decimal webOSRField;

        private bool webOSRFieldSpecified;

        private decimal webPriceField;

        private bool webPriceFieldSpecified;

        private NoYes webStandardField;

        private bool webStandardFieldSpecified;

        private bool isBAHConfigField;

        private bool isBAHConfigFieldSpecified;

        private bool isFinishedGoodField;

        private bool isFinishedGoodFieldSpecified;

        private bool isTSCServiceField;

        private bool isTSCServiceFieldSpecified;

        private bool isWsServiceItemField;

        private bool isWsServiceItemFieldSpecified;

        private decimal landedCostSystemPriceField;

        private bool landedCostSystemPriceFieldSpecified;

        /// <remarks/>
        public NoYes AllCustomizationFieldMandatory
        {
            get
            {
                return this.allCustomizationFieldMandatoryField;
            }
            set
            {
                this.allCustomizationFieldMandatoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllCustomizationFieldMandatorySpecified
        {
            get
            {
                return this.allCustomizationFieldMandatoryFieldSpecified;
            }
            set
            {
                this.allCustomizationFieldMandatoryFieldSpecified = value;
            }
        }

        /// <remarks/>
       
        public string AxProductId
        {
            get
            {
                return this.axProductIdField;
            }
            set
            {
                this.axProductIdField = value;
            }
        }

        /// <remarks/>
        
        public string CategoryCode
        {
            get
            {
                return this.categoryCodeField;
            }
            set
            {
                this.categoryCodeField = value;
            }
        }

        /// <remarks/>
        
        public string CategoryManager
        {
            get
            {
                return this.categoryManagerField;
            }
            set
            {
                this.categoryManagerField = value;
            }
        }

        /// <remarks/>
        
        public string Configuration
        {
            get
            {
                return this.configurationField;
            }
            set
            {
                this.configurationField = value;
            }
        }

        /// <remarks/>
        public NoYes ConstrainedSKU
        {
            get
            {
                return this.constrainedSKUField;
            }
            set
            {
                this.constrainedSKUField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConstrainedSKUSpecified
        {
            get
            {
                return this.constrainedSKUFieldSpecified;
            }
            set
            {
                this.constrainedSKUFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool CoverageGroup
        {
            get
            {
                return this.coverageGroupField;
            }
            set
            {
                this.coverageGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CoverageGroupSpecified
        {
            get
            {
                return this.coverageGroupFieldSpecified;
            }
            set
            {
                this.coverageGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string CustomizationNotes
        {
            get
            {
                return this.customizationNotesField;
            }
            set
            {
                this.customizationNotesField = value;
            }
        }

        /// <remarks/>
        public NoYes CustomizationRequired
        {
            get
            {
                return this.customizationRequiredField;
            }
            set
            {
                this.customizationRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomizationRequiredSpecified
        {
            get
            {
                return this.customizationRequiredFieldSpecified;
            }
            set
            {
                this.customizationRequiredFieldSpecified = value;
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
        public decimal DiscountAmount
        {
            get
            {
                return this.discountAmountField;
            }
            set
            {
                this.discountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountAmountSpecified
        {
            get
            {
                return this.discountAmountFieldSpecified;
            }
            set
            {
                this.discountAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal DisplayCost
        {
            get
            {
                return this.displayCostField;
            }
            set
            {
                this.displayCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayCostSpecified
        {
            get
            {
                return this.displayCostFieldSpecified;
            }
            set
            {
                this.displayCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ZonDisplayStatus DisplayStatus
        {
            get
            {
                return this.displayStatusField;
            }
            set
            {
                this.displayStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayStatusSpecified
        {
            get
            {
                return this.displayStatusFieldSpecified;
            }
            set
            {
                this.displayStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
       
        public string EDP
        {
            get
            {
                return this.eDPField;
            }
            set
            {
                this.eDPField = value;
            }
        }

        /// <remarks/>
        
        public string Geography
        {
            get
            {
                return this.geographyField;
            }
            set
            {
                this.geographyField = value;
            }
        }

        /// <remarks/>
        public ZonGGTG GoGetTheGreen
        {
            get
            {
                return this.goGetTheGreenField;
            }
            set
            {
                this.goGetTheGreenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GoGetTheGreenSpecified
        {
            get
            {
                return this.goGetTheGreenFieldSpecified;
            }
            set
            {
                this.goGetTheGreenFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string ItemTaxGroup
        {
            get
            {
                return this.itemTaxGroupField;
            }
            set
            {
                this.itemTaxGroupField = value;
            }
        }

        /// <remarks/>
        public decimal LandedCost
        {
            get
            {
                return this.landedCostField;
            }
            set
            {
                this.landedCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LandedCostSpecified
        {
            get
            {
                return this.landedCostFieldSpecified;
            }
            set
            {
                this.landedCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal LandedCostPercent
        {
            get
            {
                return this.landedCostPercentField;
            }
            set
            {
                this.landedCostPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LandedCostPercentSpecified
        {
            get
            {
                return this.landedCostPercentFieldSpecified;
            }
            set
            {
                this.landedCostPercentFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string ManufacturerName
        {
            get
            {
                return this.manufacturerNameField;
            }
            set
            {
                this.manufacturerNameField = value;
            }
        }

        /// <remarks/>
        public decimal Margin
        {
            get
            {
                return this.marginField;
            }
            set
            {
                this.marginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarginSpecified
        {
            get
            {
                return this.marginFieldSpecified;
            }
            set
            {
                this.marginFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string MediaCode
        {
            get
            {
                return this.mediaCodeField;
            }
            set
            {
                this.mediaCodeField = value;
            }
        }

        /// <remarks/>
       
        public string MfgrPartNo
        {
            get
            {
                return this.mfgrPartNoField;
            }
            set
            {
                this.mfgrPartNoField = value;
            }
        }

        /// <remarks/>
        public decimal OSR
        {
            get
            {
                return this.oSRField;
            }
            set
            {
                this.oSRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OSRSpecified
        {
            get
            {
                return this.oSRFieldSpecified;
            }
            set
            {
                this.oSRFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime OSRExpirationDate
        {
            get
            {
                return this.oSRExpirationDateField;
            }
            set
            {
                this.oSRExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OSRExpirationDateSpecified
        {
            get
            {
                return this.oSRExpirationDateFieldSpecified;
            }
            set
            {
                this.oSRExpirationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal PalletQty
        {
            get
            {
                return this.palletQtyField;
            }
            set
            {
                this.palletQtyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PalletQtySpecified
        {
            get
            {
                return this.palletQtyFieldSpecified;
            }
            set
            {
                this.palletQtyFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string ProductName
        {
            get
            {
                return this.productNameField;
            }
            set
            {
                this.productNameField = value;
            }
        }

        /// <remarks/>
        public int ProductionHorizonDays
        {
            get
            {
                return this.productionHorizonDaysField;
            }
            set
            {
                this.productionHorizonDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductionHorizonDaysSpecified
        {
            get
            {
                return this.productionHorizonDaysFieldSpecified;
            }
            set
            {
                this.productionHorizonDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal QuotePrice
        {
            get
            {
                return this.quotePriceField;
            }
            set
            {
                this.quotePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuotePriceSpecified
        {
            get
            {
                return this.quotePriceFieldSpecified;
            }
            set
            {
                this.quotePriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ZonRecycleFee RecycleFee
        {
            get
            {
                return this.recycleFeeField;
            }
            set
            {
                this.recycleFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecycleFeeSpecified
        {
            get
            {
                return this.recycleFeeFieldSpecified;
            }
            set
            {
                this.recycleFeeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public NoYes Returnable
        {
            get
            {
                return this.returnableField;
            }
            set
            {
                this.returnableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnableSpecified
        {
            get
            {
                return this.returnableFieldSpecified;
            }
            set
            {
                this.returnableFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string ReviewQueue
        {
            get
            {
                return this.reviewQueueField;
            }
            set
            {
                this.reviewQueueField = value;
            }
        }

        /// <remarks/>
        
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
            }
        }

        /// <remarks/>
        public decimal SellPrice
        {
            get
            {
                return this.sellPriceField;
            }
            set
            {
                this.sellPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellPriceSpecified
        {
            get
            {
                return this.sellPriceFieldSpecified;
            }
            set
            {
                this.sellPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string ServiceItemBAH
        {
            get
            {
                return this.serviceItemBAHField;
            }
            set
            {
                this.serviceItemBAHField = value;
            }
        }

        /// <remarks/>
        
        public string ShipModeGroup
        {
            get
            {
                return this.shipModeGroupField;
            }
            set
            {
                this.shipModeGroupField = value;
            }
        }

        /// <remarks/>
        public decimal ShipWeight
        {
            get
            {
                return this.shipWeightField;
            }
            set
            {
                this.shipWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipWeightSpecified
        {
            get
            {
                return this.shipWeightFieldSpecified;
            }
            set
            {
                this.shipWeightFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        
        public string StockStatusMessage
        {
            get
            {
                return this.stockStatusMessageField;
            }
            set
            {
                this.stockStatusMessageField = value;
            }
        }

        /// <remarks/>
        public decimal SystemPrice
        {
            get
            {
                return this.systemPriceField;
            }
            set
            {
                this.systemPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SystemPriceSpecified
        {
            get
            {
                return this.systemPriceFieldSpecified;
            }
            set
            {
                this.systemPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int TSCHorizonDays
        {
            get
            {
                return this.tSCHorizonDaysField;
            }
            set
            {
                this.tSCHorizonDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TSCHorizonDaysSpecified
        {
            get
            {
                return this.tSCHorizonDaysFieldSpecified;
            }
            set
            {
                this.tSCHorizonDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool TSCService
        {
            get
            {
                return this.tSCServiceField;
            }
            set
            {
                this.tSCServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TSCServiceSpecified
        {
            get
            {
                return this.tSCServiceFieldSpecified;
            }
            set
            {
                this.tSCServiceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal VPA
        {
            get
            {
                return this.vPAField;
            }
            set
            {
                this.vPAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VPASpecified
        {
            get
            {
                return this.vPAFieldSpecified;
            }
            set
            {
                this.vPAFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal WebDiscountAmount
        {
            get
            {
                return this.webDiscountAmountField;
            }
            set
            {
                this.webDiscountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebDiscountAmountSpecified
        {
            get
            {
                return this.webDiscountAmountFieldSpecified;
            }
            set
            {
                this.webDiscountAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal WebOSR
        {
            get
            {
                return this.webOSRField;
            }
            set
            {
                this.webOSRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebOSRSpecified
        {
            get
            {
                return this.webOSRFieldSpecified;
            }
            set
            {
                this.webOSRFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal WebPrice
        {
            get
            {
                return this.webPriceField;
            }
            set
            {
                this.webPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebPriceSpecified
        {
            get
            {
                return this.webPriceFieldSpecified;
            }
            set
            {
                this.webPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public NoYes WebStandard
        {
            get
            {
                return this.webStandardField;
            }
            set
            {
                this.webStandardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebStandardSpecified
        {
            get
            {
                return this.webStandardFieldSpecified;
            }
            set
            {
                this.webStandardFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isBAHConfig
        {
            get
            {
                return this.isBAHConfigField;
            }
            set
            {
                this.isBAHConfigField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBAHConfigSpecified
        {
            get
            {
                return this.isBAHConfigFieldSpecified;
            }
            set
            {
                this.isBAHConfigFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isFinishedGood
        {
            get
            {
                return this.isFinishedGoodField;
            }
            set
            {
                this.isFinishedGoodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFinishedGoodSpecified
        {
            get
            {
                return this.isFinishedGoodFieldSpecified;
            }
            set
            {
                this.isFinishedGoodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isTSCService
        {
            get
            {
                return this.isTSCServiceField;
            }
            set
            {
                this.isTSCServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTSCServiceSpecified
        {
            get
            {
                return this.isTSCServiceFieldSpecified;
            }
            set
            {
                this.isTSCServiceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isWsServiceItem
        {
            get
            {
                return this.isWsServiceItemField;
            }
            set
            {
                this.isWsServiceItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWsServiceItemSpecified
        {
            get
            {
                return this.isWsServiceItemFieldSpecified;
            }
            set
            {
                this.isWsServiceItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal landedCostSystemPrice
        {
            get
            {
                return this.landedCostSystemPriceField;
            }
            set
            {
                this.landedCostSystemPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool landedCostSystemPriceSpecified
        {
            get
            {
                return this.landedCostSystemPriceFieldSpecified;
            }
            set
            {
                this.landedCostSystemPriceFieldSpecified = value;
            }
        }
    }
}
