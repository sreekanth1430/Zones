using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMIL.DA.Interfaces.AX.SalesOrder
{    
    public partial class EntityKeyPage
    {

        private EntityKey[] entityKeyListField;

        private DocumentPaging documentPagingField;

        private EntityKeyPageStatus pageStatusField;

        private EntityKeyPageStatusDetails pageStatusDetailsField;
                
        public EntityKey[] EntityKeyList
        {
            get
            {
                return this.entityKeyListField;
            }
            set
            {
                this.entityKeyListField = value;
            }
        }

       
        public DocumentPaging DocumentPaging
        {
            get
            {
                return this.documentPagingField;
            }
            set
            {
                this.documentPagingField = value;
            }
        }

        
        public EntityKeyPageStatus PageStatus
        {
            get
            {
                return this.pageStatusField;
            }
            set
            {
                this.pageStatusField = value;
            }
        }

        
        public EntityKeyPageStatusDetails PageStatusDetails
        {
            get
            {
                return this.pageStatusDetailsField;
            }
            set
            {
                this.pageStatusDetailsField = value;
            }
        }
    }

    
    public partial class EntityKey
    {

        private KeyField[] keyDataField;
        
        public KeyField[] KeyData
        {
            get
            {
                return this.keyDataField;
            }
            set
            {
                this.keyDataField = value;
            }
        }
    }

    
    public partial class KeyField
    {

        private string fieldField;

        private string valueField;

        
        public string Field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }

        
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

   
    public partial class DocumentPaging
    {

        private string bookmarkField;

        private int pageSizeField;
         
        public string Bookmark
        {
            get
            {
                return this.bookmarkField;
            }
            set
            {
                this.bookmarkField = value;
            }
        }

        
        public int PageSize
        {
            get
            {
                return this.pageSizeField;
            }
            set
            {
                this.pageSizeField = value;
            }
        }
    }

   
    public enum EntityKeyPageStatus
    {

        
        Success,

        
        Failure,
    }
    
    public enum EntityKeyPageStatusDetails
    {

        
        None,

        
        DocumentFiltersChanged,

        
        ChangeTrackingDisabled,

        
        ChangedDateTimeOutOfRange,
    }

    
    public partial class CriteriaElement
    {

        private string dataSourceNameField;

        private string fieldNameField;

        private Operator operatorField;

        private string value1Field;

        private string value2Field;

        
        public string DataSourceName
        {
            get
            {
                return this.dataSourceNameField;
            }
            set
            {
                this.dataSourceNameField = value;
            }
        }

        
        public string FieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }

        
        public Operator Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }

        
        public string Value1
        {
            get
            {
                return this.value1Field;
            }
            set
            {
                this.value1Field = value;
            }
        }

        
        public string Value2
        {
            get
            {
                return this.value2Field;
            }
            set
            {
                this.value2Field = value;
            }
        }
    }

    
    public enum Operator
    {

        
        Equal,

        
        NotEqual,

        
        Greater,

        
        GreaterOrEqual,

        
        Less,

        
        LessOrEqual,

        
        Range,
    }

   
    public partial class AxdEntity_ZonSalesTableExtension
    {

        private System.Nullable<long> cIMSCustomerIdField;

        private bool cIMSCustomerIdFieldSpecified;

        private string cIMSProjectCodeField;

        private System.Nullable<long> cIMSProjectIdField;

        private bool cIMSProjectIdFieldSpecified;

        private string cIMSProjectNameField;

        private string costToField;

        private System.Nullable<AxdEnum_NoYes> includedForCommissionField;

        private bool includedForCommissionFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> isFreightCostLockedField;

        private bool isFreightCostLockedFieldSpecified;

        private string lastFourDigitCreditCardNumberField;

        private string lOBCostcenterField;

        private string lOBDepartmentField;

        private string miscData1Field;

        private string miscData2Field;

        private string miscData3Field;

        private string miscData4Field;

        private string miscData5Field;

        private string pORequestIDField;

        private string projectIdField;

        private string projectTypeField;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private string versionField;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_ZonSalesTableExtension()
        {
            this.classField = "entity";
        }

       
        public System.Nullable<long> CIMSCustomerId
        {
            get
            {
                return this.cIMSCustomerIdField;
            }
            set
            {
                this.cIMSCustomerIdField = value;
            }
        }

        
        public bool CIMSCustomerIdSpecified
        {
            get
            {
                return this.cIMSCustomerIdFieldSpecified;
            }
            set
            {
                this.cIMSCustomerIdFieldSpecified = value;
            }
        }

        
        public string CIMSProjectCode
        {
            get
            {
                return this.cIMSProjectCodeField;
            }
            set
            {
                this.cIMSProjectCodeField = value;
            }
        }

       
        public System.Nullable<long> CIMSProjectId
        {
            get
            {
                return this.cIMSProjectIdField;
            }
            set
            {
                this.cIMSProjectIdField = value;
            }
        }

        
        public bool CIMSProjectIdSpecified
        {
            get
            {
                return this.cIMSProjectIdFieldSpecified;
            }
            set
            {
                this.cIMSProjectIdFieldSpecified = value;
            }
        }

        
        public string CIMSProjectName
        {
            get
            {
                return this.cIMSProjectNameField;
            }
            set
            {
                this.cIMSProjectNameField = value;
            }
        }

        
        public string CostTo
        {
            get
            {
                return this.costToField;
            }
            set
            {
                this.costToField = value;
            }
        }

         
        public System.Nullable<AxdEnum_NoYes> IncludedForCommission
        {
            get
            {
                return this.includedForCommissionField;
            }
            set
            {
                this.includedForCommissionField = value;
            }
        }

         
        public bool IncludedForCommissionSpecified
        {
            get
            {
                return this.includedForCommissionFieldSpecified;
            }
            set
            {
                this.includedForCommissionFieldSpecified = value;
            }
        }

         
        public System.Nullable<AxdEnum_NoYes> IsFreightCostLocked
        {
            get
            {
                return this.isFreightCostLockedField;
            }
            set
            {
                this.isFreightCostLockedField = value;
            }
        }

         
        public bool IsFreightCostLockedSpecified
        {
            get
            {
                return this.isFreightCostLockedFieldSpecified;
            }
            set
            {
                this.isFreightCostLockedFieldSpecified = value;
            }
        }

         
        public string LastFourDigitCreditCardNumber
        {
            get
            {
                return this.lastFourDigitCreditCardNumberField;
            }
            set
            {
                this.lastFourDigitCreditCardNumberField = value;
            }
        }

         
        public string LOBCostcenter
        {
            get
            {
                return this.lOBCostcenterField;
            }
            set
            {
                this.lOBCostcenterField = value;
            }
        }

         
        public string LOBDepartment
        {
            get
            {
                return this.lOBDepartmentField;
            }
            set
            {
                this.lOBDepartmentField = value;
            }
        }

         
        public string MiscData1
        {
            get
            {
                return this.miscData1Field;
            }
            set
            {
                this.miscData1Field = value;
            }
        }

        
        public string MiscData2
        {
            get
            {
                return this.miscData2Field;
            }
            set
            {
                this.miscData2Field = value;
            }
        }

         
        public string MiscData3
        {
            get
            {
                return this.miscData3Field;
            }
            set
            {
                this.miscData3Field = value;
            }
        }

         
        public string MiscData4
        {
            get
            {
                return this.miscData4Field;
            }
            set
            {
                this.miscData4Field = value;
            }
        }

         
        public string MiscData5
        {
            get
            {
                return this.miscData5Field;
            }
            set
            {
                this.miscData5Field = value;
            }
        }

         
        public string PORequestID
        {
            get
            {
                return this.pORequestIDField;
            }
            set
            {
                this.pORequestIDField = value;
            }
        }

         
        public string ProjectId
        {
            get
            {
                return this.projectIdField;
            }
            set
            {
                this.projectIdField = value;
            }
        }

         
        public string ProjectType
        {
            get
            {
                return this.projectTypeField;
            }
            set
            {
                this.projectTypeField = value;
            }
        }

         
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

         
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

         
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

         
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

         
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

         
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

         
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

     
    public enum AxdEnum_NoYes
    {

        
        No,

        
        Yes,
    }

     
    public enum AxdEnum_AxdEntityAction
    {

        
        create,

        
        update,

        
        replace,

        
        delete,
    }

     
    public partial class AxdEntity_ZonCustAddlCreditCards
    {

        private System.Nullable<decimal> amountField;

        private bool amountFieldSpecified;

        private System.Nullable<decimal> amount1Field;

        private bool amount1FieldSpecified;

        private System.Nullable<decimal> amount2Field;

        private bool amount2FieldSpecified;

        private System.Nullable<AxdEnum_ZonCardType> cardTypeField;

        private bool cardTypeFieldSpecified;

        private System.Nullable<AxdEnum_ZonCardType> cardType1Field;

        private bool cardType1FieldSpecified;

        private System.Nullable<AxdEnum_ZonCardType> cardType2Field;

        private bool cardType2FieldSpecified;

        private string creditCardNumberField;

        private string creditCardNumber1Field;

        private string creditCardNumber2Field;

        private string custAccountField;

        private string expiryDateField;

        private string expiryDate1Field;

        private string expiryDate2Field;

        private System.Nullable<AxdExtType_NoYesId> isCreditCardActiveField;

        private bool isCreditCardActiveFieldSpecified;

        private System.Nullable<AxdExtType_NoYesId> isCreditCardActive1Field;

        private bool isCreditCardActive1FieldSpecified;

        private System.Nullable<AxdExtType_NoYesId> isCreditCardActive2Field;

        private bool isCreditCardActive2FieldSpecified;

        private string notesField;

        private string notes1Field;

        private string notes2Field;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_ZonCustAddlCreditCards()
        {
            this.classField = "entity";
        }

         
        public System.Nullable<decimal> Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

         
        public bool AmountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }

         
        public System.Nullable<decimal> Amount1
        {
            get
            {
                return this.amount1Field;
            }
            set
            {
                this.amount1Field = value;
            }
        }

         
        public bool Amount1Specified
        {
            get
            {
                return this.amount1FieldSpecified;
            }
            set
            {
                this.amount1FieldSpecified = value;
            }
        }

         
        public System.Nullable<decimal> Amount2
        {
            get
            {
                return this.amount2Field;
            }
            set
            {
                this.amount2Field = value;
            }
        }

         
        public bool Amount2Specified
        {
            get
            {
                return this.amount2FieldSpecified;
            }
            set
            {
                this.amount2FieldSpecified = value;
            }
        }

         
        public System.Nullable<AxdEnum_ZonCardType> CardType
        {
            get
            {
                return this.cardTypeField;
            }
            set
            {
                this.cardTypeField = value;
            }
        }
 
        public bool CardTypeSpecified
        {
            get
            {
                return this.cardTypeFieldSpecified;
            }
            set
            {
                this.cardTypeFieldSpecified = value;
            }
        }
 
        public System.Nullable<AxdEnum_ZonCardType> CardType1
        {
            get
            {
                return this.cardType1Field;
            }
            set
            {
                this.cardType1Field = value;
            }
        }

        
        public bool CardType1Specified
        {
            get
            {
                return this.cardType1FieldSpecified;
            }
            set
            {
                this.cardType1FieldSpecified = value;
            }
        }

         
        public System.Nullable<AxdEnum_ZonCardType> CardType2
        {
            get
            {
                return this.cardType2Field;
            }
            set
            {
                this.cardType2Field = value;
            }
        }

         
        public bool CardType2Specified
        {
            get
            {
                return this.cardType2FieldSpecified;
            }
            set
            {
                this.cardType2FieldSpecified = value;
            }
        }

         
        public string CreditCardNumber
        {
            get
            {
                return this.creditCardNumberField;
            }
            set
            {
                this.creditCardNumberField = value;
            }
        }

         
        public string CreditCardNumber1
        {
            get
            {
                return this.creditCardNumber1Field;
            }
            set
            {
                this.creditCardNumber1Field = value;
            }
        }

         
        public string CreditCardNumber2
        {
            get
            {
                return this.creditCardNumber2Field;
            }
            set
            {
                this.creditCardNumber2Field = value;
            }
        }

         
        public string CustAccount
        {
            get
            {
                return this.custAccountField;
            }
            set
            {
                this.custAccountField = value;
            }
        }

         
        public string ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }

        
        public string ExpiryDate1
        {
            get
            {
                return this.expiryDate1Field;
            }
            set
            {
                this.expiryDate1Field = value;
            }
        }

        
        public string ExpiryDate2
        {
            get
            {
                return this.expiryDate2Field;
            }
            set
            {
                this.expiryDate2Field = value;
            }
        }

        public System.Nullable<AxdExtType_NoYesId> IsCreditCardActive
        {
            get
            {
                return this.isCreditCardActiveField;
            }
            set
            {
                this.isCreditCardActiveField = value;
            }
        }

        
        public bool IsCreditCardActiveSpecified
        {
            get
            {
                return this.isCreditCardActiveFieldSpecified;
            }
            set
            {
                this.isCreditCardActiveFieldSpecified = value;
            }
        }

        
        public System.Nullable<AxdExtType_NoYesId> IsCreditCardActive1
        {
            get
            {
                return this.isCreditCardActive1Field;
            }
            set
            {
                this.isCreditCardActive1Field = value;
            }
        }

        
        public bool IsCreditCardActive1Specified
        {
            get
            {
                return this.isCreditCardActive1FieldSpecified;
            }
            set
            {
                this.isCreditCardActive1FieldSpecified = value;
            }
        }

        
        public System.Nullable<AxdExtType_NoYesId> IsCreditCardActive2
        {
            get
            {
                return this.isCreditCardActive2Field;
            }
            set
            {
                this.isCreditCardActive2Field = value;
            }
        }

       
        public bool IsCreditCardActive2Specified
        {
            get
            {
                return this.isCreditCardActive2FieldSpecified;
            }
            set
            {
                this.isCreditCardActive2FieldSpecified = value;
            }
        }

      
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

         
        public string Notes1
        {
            get
            {
                return this.notes1Field;
            }
            set
            {
                this.notes1Field = value;
            }
        }

         
        public string Notes2
        {
            get
            {
                return this.notes2Field;
            }
            set
            {
                this.notes2Field = value;
            }
        }

         
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

         
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

         
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

         
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

         
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

         
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

         
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

     
    public enum AxdEnum_ZonCardType
    {

        
        None,

        
        Visa,

        
        MasterCard,

        
        AmericanExpress,

        
        Discover,
    }

     
    public enum AxdExtType_NoYesId
    {

        
        No,

        
        Yes,
    }

     
    public partial class AxdEntity_MarkupTransHeader
    {

        private System.Nullable<AxdExtType_MarkupKeep> keepField;

        private bool keepFieldSpecified;

        private string markupCodeField;

        private System.Nullable<AxdExtType_MarkupModuleCategory> moduleCategoryField;

        private bool moduleCategoryFieldSpecified;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private System.Nullable<decimal> valueField;

        private bool valueFieldSpecified;

        private System.Nullable<decimal> zonCommissionableCostField;

        private bool zonCommissionableCostFieldSpecified;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_MarkupTransHeader()
        {
            this.classField = "entity";
        }

         
        public System.Nullable<AxdExtType_MarkupKeep> Keep
        {
            get
            {
                return this.keepField;
            }
            set
            {
                this.keepField = value;
            }
        }

        
        public bool KeepSpecified
        {
            get
            {
                return this.keepFieldSpecified;
            }
            set
            {
                this.keepFieldSpecified = value;
            }
        }

        
        public string MarkupCode
        {
            get
            {
                return this.markupCodeField;
            }
            set
            {
                this.markupCodeField = value;
            }
        }

         
        public System.Nullable<AxdExtType_MarkupModuleCategory> ModuleCategory
        {
            get
            {
                return this.moduleCategoryField;
            }
            set
            {
                this.moduleCategoryField = value;
            }
        }

        
        public bool ModuleCategorySpecified
        {
            get
            {
                return this.moduleCategoryFieldSpecified;
            }
            set
            {
                this.moduleCategoryFieldSpecified = value;
            }
        }

         
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

        
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

        
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

         
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

        
        public System.Nullable<decimal> Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

         
        public bool ValueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }

        
        public System.Nullable<decimal> ZonCommissionableCost
        {
            get
            {
                return this.zonCommissionableCostField;
            }
            set
            {
                this.zonCommissionableCostField = value;
            }
        }

         
        public bool ZonCommissionableCostSpecified
        {
            get
            {
                return this.zonCommissionableCostFieldSpecified;
            }
            set
            {
                this.zonCommissionableCostFieldSpecified = value;
            }
        }

         
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

         
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

         
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

    
    public enum AxdExtType_MarkupKeep
    {

        
        No,

        
        Yes,
    }

     
    public enum AxdExtType_MarkupModuleCategory
    {

        
        Heading,

        
        Linie,
    }

     
    public partial class AxdEntity_DocuRefHeader
    {

        private string authorField;

        private AxdExtType_CreatedDateTime createdDateTimeField;

        private AxdExtType_ModifiedDateTime modifiedDateTimeField;

        private string nameField;

        private string notesField;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private System.Nullable<AxdEnum_DocuRestriction> restrictionField;

        private bool restrictionFieldSpecified;

        private string typeIdField;

        private string zonAuthorAliasField;

        private AxdExtType_CreatedDateTime zonCommentDateTimeField;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_DocuRefHeader()
        {
            this.classField = "entity";
        }

        
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        
        public AxdExtType_CreatedDateTime CreatedDateTime
        {
            get
            {
                return this.createdDateTimeField;
            }
            set
            {
                this.createdDateTimeField = value;
            }
        }

         
        public AxdExtType_ModifiedDateTime ModifiedDateTime
        {
            get
            {
                return this.modifiedDateTimeField;
            }
            set
            {
                this.modifiedDateTimeField = value;
            }
        }

         
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

         
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

         
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

        
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

         
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }
 
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

        
        public System.Nullable<AxdEnum_DocuRestriction> Restriction
        {
            get
            {
                return this.restrictionField;
            }
            set
            {
                this.restrictionField = value;
            }
        }

         
        public bool RestrictionSpecified
        {
            get
            {
                return this.restrictionFieldSpecified;
            }
            set
            {
                this.restrictionFieldSpecified = value;
            }
        }

         
        public string TypeId
        {
            get
            {
                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

         
        public string ZonAuthorAlias
        {
            get
            {
                return this.zonAuthorAliasField;
            }
            set
            {
                this.zonAuthorAliasField = value;
            }
        }

         
        public AxdExtType_CreatedDateTime ZonCommentDateTime
        {
            get
            {
                return this.zonCommentDateTimeField;
            }
            set
            {
                this.zonCommentDateTimeField = value;
            }
        }

         
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

         
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

         
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

    
    public partial class AxdExtType_CreatedDateTime : AxdType_DateTime
    {
    }

   
    public partial class AxdType_DateTime
    {

        private System.DateTime localDateTimeField;

        private bool localDateTimeFieldSpecified;

        private AxdEnum_Timezone timezoneField;

        private bool timezoneFieldSpecified;

        private System.DateTime valueField;

        
        public System.DateTime localDateTime
        {
            get
            {
                return this.localDateTimeField;
            }
            set
            {
                this.localDateTimeField = value;
            }
        }

        
        public bool localDateTimeSpecified
        {
            get
            {
                return this.localDateTimeFieldSpecified;
            }
            set
            {
                this.localDateTimeFieldSpecified = value;
            }
        }

        
        public AxdEnum_Timezone timezone
        {
            get
            {
                return this.timezoneField;
            }
            set
            {
                this.timezoneField = value;
            }
        }

        
        public bool timezoneSpecified
        {
            get
            {
                return this.timezoneFieldSpecified;
            }
            set
            {
                this.timezoneFieldSpecified = value;
            }
        }

        
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

     
    public enum AxdEnum_Timezone
    {

        
        GMTMINUS1200INTERNATIONALDATELINEWEST,

        
        GMTMINUS1100COORDINATEDUNIVERSALTIME,

        
        GMTMINUS1000HAWAII,

        
        GMTMINUS0900ALASKA,

        
        GMTMINUS0800PACIFICTIME,

        
        GMTMINUS0800TIJUANA_BAJACALIFORNIA,

        
        GMTMINUS0700ARIZONA,

        
        GMTMINUS0700MOUNTAINTIME,

        
        GMTMINUS0700CHIHUAHUA_LAPAZ_MAZATLAN,

        
        GMTMINUS0600CENTRALAMERICA,

        
        GMTMINUS0600CENTRALTIME,

        
        GMTMINUS0600GUADALAJARA_MEXICOCITY,

        
        GMTMINUS0600SASKATCHEWAN,

        
        GMTMINUS0500BOGOTA_LIMA_QUITO_RIOBRANCO,

        
        GMTMINUS0500EASTERNTIME_MEXICO,

        
        GMTMINUS0500EASTERNTIME,

        
        GMTMINUS0500INDIANA,

        
        GMTMINUS0430CARACAS,

        
        GMTMINUS0400ASUNCION,

        
        GMTMINUS0400ATLANTICTIME,

        
        GMTMINUS0400LAPAZ,

        
        GMTMINUS0400MANAUS,

        
        GMTMINUS0330NEWFOUNDLAND,

        
        GMTMINUS0300BRASILIA,

        
        GMTMINUS0300BUENOSAIRES,

        
        GMTMINUS0300BUENOSAIRES_GEORGETOWN,

        
        GMTMINUS0300GREENLAND,

        
        GMTMINUS0300MONTEVIDEO,

        
        GMTMINUS0300_SALVADOR,

        
        GMTMINUS0300SANTIAGO,

        
        GMTMINUS0200MIDATLANTIC,

        
        GMTMINUS0100AZORES,

        
        GMTMINUS0100CAPEVERDIS,

        
        GMT_CASABLANCA,

        
        GMT_COORDINATEDUNIVERSALTIME,

        
        GMT_CASABLANCA_MONTROVIA_REYKJAVIK,

        
        GMT_DUBLIN_EDINBURGH_LISBON_LONDON,

        
        GMTPLUS0100_AMSTERDAM_BERLIN_BERN_ROME,

        
        GMTPLUS0100BELGRADE_BRATISLAVA_BUDAPEST,

        
        GMTPLUS0100BRUSSELS_COPENHAGEN_MADRID,

        
        GMTPLUS0100SARAJEVO_SKOPJE_WARSAW_ZAGREB,

        
        GMTPLUS0100TRIPOLI,

        
        GMTPLUS0100WESTCENTRALAFRICA,

        
        GMTPLUS0200AMMAN,

        
        GMTPLUS0200ATHENS_BUCHAREST_ISTANBUL,

        
        GMTPLUS0200BEIRUT,

        
        GMTPLUS0200MINSK,

        
        GMTPLUS0200CAIRO,

        
        GMTPLUS0200_DAMASCUS,

        
        GMTPLUS0200HARARE_PRETORIA,

        
        GMTPLUS0200HELSINKI_KYIV_RIGA_VILNIUS,

        
        GMTPLUS0200JERUSALEM,

        
        GMTPLUS0200WINDHOEK,

        
        GMTPLUS0300_ISTANBUL,

        
        GMT_PLUS0300KALININGRAD_MINSK,

        
        GMTPLUS0300BAGHDAD,

        
        GMTPLUS0300KUWAIT_RIYADH,

        
        GMTPLUS0300MOSCOW_STPETERSBURG_VOLGOGRAD,

        
        GMTPLUS0400PORTLOUIS,

        
        GMTPLUS0300NAIROBI,

        
        GMTPLUS0300TBILISI,

        
        GMTPLUS0330TEHRAN,

        
        GMTPLUS0400ABUDHABI_MUSCAT,

        
        GMTPLUS0400BAKU,

        
        GMTPLUS0400IZHEVSK_SAMARA,

        
        GMTPLUS0400CAUCASUSSTANDARDTIME,

        
        GMTPLUS0400YEREVAN,

        
        GMTPLUS0430KABUL,

        
        GMTPLUS0500EKATERINBURG,

        
        GMTPLUS0500ISLAMABAD_KARACHI,

        
        GMTPLUS0500ISLAMABAD_KARACHI_TASHKENT,

        
        GMTPLUS0530CHENNAI_KOLKATA_MUMBAI,

        
        GMTPLUS0530SRIJAYAWARDENEPURA,

        
        GMTPLUS0545KATHMANDU,

        
        GMTPLUS0600ASTANA_DHAKA,

        
        GMTPLUS0600DHAKA,

        
        GMTPLUS0600ALMATY_NOVOSIBIRSK,

        
        GMTPLUS0630_YANGON,

        
        GMTPLUS0700_BANGKOK_HANOI_JAKARTA,

        
        GMTPLUS0700KRASNOYARSK,

        
        GMTPLUS0800BEIJING_CHONGQING_HONGKONG,

        
        GMTPLUS0800IRKUTSK_ULAANBATAAR,

        
        GMTPLUS0800_ULAANBAATAR,

        
        GMTPLUS0800KUALALUMPUR_SINGAPORE,

        
        GMTPLUS0800PERTH,

        
        GMTPLUS0800TAIPEI,

        
        GMTPLUS0900OSAKA_SAPPORO_TOKYO,

        
        GMTPLUS0900SEOUL,

        
        GMTPLUS0900YAKUTSK,

        
        GMTPLUS0930ADELAIDE,

        
        GMTPLUS0930DARWIN,

        
        GMTPLUS1000BRISBANE,

        
        GMTPLUS1000CANBERRA_MELBOURNE_SYDNEY,

        
        GMTPLUS1000GUAM_PORTMORESBY,

        
        GMTPLUS1000HOBART,

        
        GMTPLUS1000VLADIVOSTOK,

        
        GMTPLUS1100CHOKURDAKH,

        
        GMTPLUS1100MAGADAN_SOLOMONIS,

        
        GMTPLUS0600MAGADAN,

        
        GMTPLUS1200ANADYR_PETRO_KAMCHATSKY,

        
        GMTPLUS1200AUCKLAND_WELLINGTON,

        
        GMTPLUS1200COORDINATEDUNIVERSALTIME,

        
        GMTPLUS1200FIJI_KAMCHATKA_MARSHALLIS,

        
        GMTMINUS1100MIDWAYISLAND_SAMOA,

        
        GMTPLUS1300NUKU_ALOFA,
    }

    
    public partial class AxdExtType_VendBankAccountExpiryDate : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_VendBankAccountActiveDate : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_TrvDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_SMARepairFinishDateTime : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_SMASignOffDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_SMAPreferredServiceDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_PurchReqSubmittedDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_VersioningTimeStamp : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_ZonOSRDateTimeStamp : AxdType_DateTime
    {
    }

    public partial class AxdExtType_ActivationDateTime : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_HcmEmploymentSeniorityDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_HcmEmploymentStartDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_HcmEmploymentValidTo : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_HcmEmploymentValidFrom : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_ValidFromDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_ValidToDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_ToDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_FromDateTime : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_DateTimeExecuted : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_DOCommonLastSyncDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_StartDateTime : AxdType_DateTime
    {
    }
 
    public partial class AxdExtType_EndDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_smmDateTimeLastEdit : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_UTCTimestamp : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_JournalSessionLoginDateTime : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_JournalPostedDateTime : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_InvoiceReleaseDate : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_ModifiedDateTime : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_PostReleaseDate : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_ExpirationDateTime : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_EffectiveDateTime : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_AttributeValueDateTime : AxdType_DateTime
    {
    }

   
    public partial class AxdExtType_SMALatestCompletionDateTime : AxdType_DateTime
    {
    }

     
    public partial class AxdExtType_ClosedDateTime : AxdType_DateTime
    {
    }

    
    public partial class AxdExtType_BankStmtISODateTime : AxdType_DateTime
    {
    }

    
    public enum AxdEnum_DocuRestriction
    {

        
        Internal,

        
        External,
    }

    
    public partial class AxdEntity_ZonSalesLineExtension
    {

        private string activityIdField;

        private string bHConfigItemField;

        private System.Nullable<decimal> commissionableCostField;

        private bool commissionableCostFieldSpecified;

        private System.Nullable<decimal> contractSalesPriceField;

        private bool contractSalesPriceFieldSpecified;

        private System.Nullable<decimal> cPTPriceField;

        private bool cPTPriceFieldSpecified;

        private string customerContractIdField;

        private string customerOrderTypeField;

        private string extCustProductNumberField;

        private string externalInvoiceNumberField;

        private string extPOLineNumberField;

        private string extProductNumberField;

        private System.Nullable<decimal> extPurchPriceField;

        private bool extPurchPriceFieldSpecified;

        private System.Nullable<decimal> extPurchQtyField;

        private bool extPurchQtyFieldSpecified;

        private System.Nullable<int> extStateField;

        private bool extStateFieldSpecified;

        private string extUOMField;

        private string extVendItemNoField;

        private System.Nullable<AxdEnum_NoYes> isCustomerStandardField;

        private bool isCustomerStandardFieldSpecified;

        private System.Nullable<AxdEnum_boolean> isFinishedGoodField;

        private bool isFinishedGoodFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> isInsideDeliveryField;

        private bool isInsideDeliveryFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> isLiftGateDeliveryField;

        private bool isLiftGateDeliveryFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> isProofRequireSignatureAdultField;

        private bool isProofRequireSignatureAdultFieldSpecified;

        private System.Nullable<AxdEnum_boolean> isTSCServiceField;

        private bool isTSCServiceFieldSpecified;

        private System.Nullable<decimal> landedCostField;

        private bool landedCostFieldSpecified;

        private string lineIdField;

        private string lineRefIdField;

        private string mSCustomerIdField;

        private System.Nullable<System.DateTime> needByDateField;

        private bool needByDateFieldSpecified;

        private System.Nullable<decimal> palletQtyField;

        private bool palletQtyFieldSpecified;

        private System.Nullable<decimal> palletRateField;

        private bool palletRateFieldSpecified;

        private System.Nullable<System.DateTime> palletShipOutDateField;

        private bool palletShipOutDateFieldSpecified;

        private System.Nullable<AxdEnum_ZonCustomerContractPricingLimitation> pricingLimitationField;

        private bool pricingLimitationFieldSpecified;

        private System.Nullable<AxdEnum_ZonNeedbyQualifier> qualifierField;

        private bool qualifierFieldSpecified;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private System.Nullable<decimal> systemPriceField;

        private bool systemPriceFieldSpecified;

        private string vendorField;

        private string vendSubscriptionIdField;

        private string wYLineRefIdField;

        private System.Nullable<AxdEnum_ZonWarrantyType> wYTypeField;

        private bool wYTypeFieldSpecified;

        private string zCPOrderNumberField;

        private string zCPSubscriptionIdField;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_ZonSalesLineExtension()
        {
            this.classField = "entity";
        }

        
        public string ActivityId
        {
            get
            {
                return this.activityIdField;
            }
            set
            {
                this.activityIdField = value;
            }
        }

        
        public string BHConfigItem
        {
            get
            {
                return this.bHConfigItemField;
            }
            set
            {
                this.bHConfigItemField = value;
            }
        }

        
        public System.Nullable<decimal> CommissionableCost
        {
            get
            {
                return this.commissionableCostField;
            }
            set
            {
                this.commissionableCostField = value;
            }
        }

        
        public bool CommissionableCostSpecified
        {
            get
            {
                return this.commissionableCostFieldSpecified;
            }
            set
            {
                this.commissionableCostFieldSpecified = value;
            }
        }

        
        public System.Nullable<decimal> ContractSalesPrice
        {
            get
            {
                return this.contractSalesPriceField;
            }
            set
            {
                this.contractSalesPriceField = value;
            }
        }

        
        public bool ContractSalesPriceSpecified
        {
            get
            {
                return this.contractSalesPriceFieldSpecified;
            }
            set
            {
                this.contractSalesPriceFieldSpecified = value;
            }
        }

        
        public System.Nullable<decimal> CPTPrice
        {
            get
            {
                return this.cPTPriceField;
            }
            set
            {
                this.cPTPriceField = value;
            }
        }

        
        public bool CPTPriceSpecified
        {
            get
            {
                return this.cPTPriceFieldSpecified;
            }
            set
            {
                this.cPTPriceFieldSpecified = value;
            }
        }

        
        public string CustomerContractId
        {
            get
            {
                return this.customerContractIdField;
            }
            set
            {
                this.customerContractIdField = value;
            }
        }

        
        public string CustomerOrderType
        {
            get
            {
                return this.customerOrderTypeField;
            }
            set
            {
                this.customerOrderTypeField = value;
            }
        }

        
        public string ExtCustProductNumber
        {
            get
            {
                return this.extCustProductNumberField;
            }
            set
            {
                this.extCustProductNumberField = value;
            }
        }

        
        public string ExternalInvoiceNumber
        {
            get
            {
                return this.externalInvoiceNumberField;
            }
            set
            {
                this.externalInvoiceNumberField = value;
            }
        }

        
        public string ExtPOLineNumber
        {
            get
            {
                return this.extPOLineNumberField;
            }
            set
            {
                this.extPOLineNumberField = value;
            }
        }

        
        public string ExtProductNumber
        {
            get
            {
                return this.extProductNumberField;
            }
            set
            {
                this.extProductNumberField = value;
            }
        }

        
        public System.Nullable<decimal> ExtPurchPrice
        {
            get
            {
                return this.extPurchPriceField;
            }
            set
            {
                this.extPurchPriceField = value;
            }
        }

       
        public bool ExtPurchPriceSpecified
        {
            get
            {
                return this.extPurchPriceFieldSpecified;
            }
            set
            {
                this.extPurchPriceFieldSpecified = value;
            }
        }

        
        public System.Nullable<decimal> ExtPurchQty
        {
            get
            {
                return this.extPurchQtyField;
            }
            set
            {
                this.extPurchQtyField = value;
            }
        }

        
        public bool ExtPurchQtySpecified
        {
            get
            {
                return this.extPurchQtyFieldSpecified;
            }
            set
            {
                this.extPurchQtyFieldSpecified = value;
            }
        }

        
        public System.Nullable<int> ExtState
        {
            get
            {
                return this.extStateField;
            }
            set
            {
                this.extStateField = value;
            }
        }

        
        public bool ExtStateSpecified
        {
            get
            {
                return this.extStateFieldSpecified;
            }
            set
            {
                this.extStateFieldSpecified = value;
            }
        }

        
        public string ExtUOM
        {
            get
            {
                return this.extUOMField;
            }
            set
            {
                this.extUOMField = value;
            }
        }

        
        public string ExtVendItemNo
        {
            get
            {
                return this.extVendItemNoField;
            }
            set
            {
                this.extVendItemNoField = value;
            }
        }

        
        public System.Nullable<AxdEnum_NoYes> IsCustomerStandard
        {
            get
            {
                return this.isCustomerStandardField;
            }
            set
            {
                this.isCustomerStandardField = value;
            }
        }

        
        public bool IsCustomerStandardSpecified
        {
            get
            {
                return this.isCustomerStandardFieldSpecified;
            }
            set
            {
                this.isCustomerStandardFieldSpecified = value;
            }
        }

        
        public System.Nullable<AxdEnum_boolean> IsFinishedGood
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

        
        public bool IsFinishedGoodSpecified
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

       
        public System.Nullable<AxdEnum_NoYes> IsInsideDelivery
        {
            get
            {
                return this.isInsideDeliveryField;
            }
            set
            {
                this.isInsideDeliveryField = value;
            }
        }

        
        public bool IsInsideDeliverySpecified
        {
            get
            {
                return this.isInsideDeliveryFieldSpecified;
            }
            set
            {
                this.isInsideDeliveryFieldSpecified = value;
            }
        }

        
        public System.Nullable<AxdEnum_NoYes> IsLiftGateDelivery
        {
            get
            {
                return this.isLiftGateDeliveryField;
            }
            set
            {
                this.isLiftGateDeliveryField = value;
            }
        }

        
        public bool IsLiftGateDeliverySpecified
        {
            get
            {
                return this.isLiftGateDeliveryFieldSpecified;
            }
            set
            {
                this.isLiftGateDeliveryFieldSpecified = value;
            }
        }

         
        public System.Nullable<AxdEnum_NoYes> IsProofRequireSignatureAdult
        {
            get
            {
                return this.isProofRequireSignatureAdultField;
            }
            set
            {
                this.isProofRequireSignatureAdultField = value;
            }
        }

         
        public bool IsProofRequireSignatureAdultSpecified
        {
            get
            {
                return this.isProofRequireSignatureAdultFieldSpecified;
            }
            set
            {
                this.isProofRequireSignatureAdultFieldSpecified = value;
            }
        }

         
        public System.Nullable<AxdEnum_boolean> IsTSCService
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

         
        public bool IsTSCServiceSpecified
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

         
        public System.Nullable<decimal> LandedCost
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

        
        public string LineId
        {
            get
            {
                return this.lineIdField;
            }
            set
            {
                this.lineIdField = value;
            }
        }

        
        public string LineRefId
        {
            get
            {
                return this.lineRefIdField;
            }
            set
            {
                this.lineRefIdField = value;
            }
        }

        
        public string MSCustomerId
        {
            get
            {
                return this.mSCustomerIdField;
            }
            set
            {
                this.mSCustomerIdField = value;
            }
        }

        
        public System.Nullable<System.DateTime> NeedByDate
        {
            get
            {
                return this.needByDateField;
            }
            set
            {
                this.needByDateField = value;
            }
        }

        
        public bool NeedByDateSpecified
        {
            get
            {
                return this.needByDateFieldSpecified;
            }
            set
            {
                this.needByDateFieldSpecified = value;
            }
        }

        
        public System.Nullable<decimal> PalletQty
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

        
        public System.Nullable<decimal> PalletRate
        {
            get
            {
                return this.palletRateField;
            }
            set
            {
                this.palletRateField = value;
            }
        }

        
        public bool PalletRateSpecified
        {
            get
            {
                return this.palletRateFieldSpecified;
            }
            set
            {
                this.palletRateFieldSpecified = value;
            }
        }

        
        public System.Nullable<System.DateTime> PalletShipOutDate
        {
            get
            {
                return this.palletShipOutDateField;
            }
            set
            {
                this.palletShipOutDateField = value;
            }
        }

        
        public bool PalletShipOutDateSpecified
        {
            get
            {
                return this.palletShipOutDateFieldSpecified;
            }
            set
            {
                this.palletShipOutDateFieldSpecified = value;
            }
        }

        
        public System.Nullable<AxdEnum_ZonCustomerContractPricingLimitation> PricingLimitation
        {
            get
            {
                return this.pricingLimitationField;
            }
            set
            {
                this.pricingLimitationField = value;
            }
        }

        
        public bool PricingLimitationSpecified
        {
            get
            {
                return this.pricingLimitationFieldSpecified;
            }
            set
            {
                this.pricingLimitationFieldSpecified = value;
            }
        }

        
        public System.Nullable<AxdEnum_ZonNeedbyQualifier> Qualifier
        {
            get
            {
                return this.qualifierField;
            }
            set
            {
                this.qualifierField = value;
            }
        }

        
        public bool QualifierSpecified
        {
            get
            {
                return this.qualifierFieldSpecified;
            }
            set
            {
                this.qualifierFieldSpecified = value;
            }
        }

        
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

       
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

        
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

        
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

        
        public System.Nullable<decimal> SystemPrice
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

        
        public string Vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }

         
        public string VendSubscriptionId
        {
            get
            {
                return this.vendSubscriptionIdField;
            }
            set
            {
                this.vendSubscriptionIdField = value;
            }
        }

       
        public string WYLineRefId
        {
            get
            {
                return this.wYLineRefIdField;
            }
            set
            {
                this.wYLineRefIdField = value;
            }
        }

        
        public System.Nullable<AxdEnum_ZonWarrantyType> WYType
        {
            get
            {
                return this.wYTypeField;
            }
            set
            {
                this.wYTypeField = value;
            }
        }

         
        public bool WYTypeSpecified
        {
            get
            {
                return this.wYTypeFieldSpecified;
            }
            set
            {
                this.wYTypeFieldSpecified = value;
            }
        }

       
        public string ZCPOrderNumber
        {
            get
            {
                return this.zCPOrderNumberField;
            }
            set
            {
                this.zCPOrderNumberField = value;
            }
        }

        
        public string ZCPSubscriptionId
        {
            get
            {
                return this.zCPSubscriptionIdField;
            }
            set
            {
                this.zCPSubscriptionIdField = value;
            }
        }

         
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

         
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

         
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

   
    public enum AxdEnum_boolean
    {

        
        @false,

        
        @true,
    }

   
    public enum AxdEnum_ZonCustomerContractPricingLimitation
    {

        
        CannotExceed,

        
        CannotVary,
    }

   
    public enum AxdEnum_ZonNeedbyQualifier
    {

        
        FirstAvailable,

        
        NeedOn,

        
        NeedBefore,

        
        NeedAfter,
    }

   
    public enum AxdEnum_ZonWarrantyType
    {

        
        None,

        
        SameOrder,

        
        DifferentOrder,

        
        NonZoneOrder,
    }

   
    public partial class AxdEntity_ZonSalesLineInfo
    {

        private string agreementField;

        private string codeField;

        private string contactEmailField;

        private string contactNameField;

        private string contactPhoneField;

        private string costField;

        private string descriptionField;

        private string descriptionLabelField;

        private System.Nullable<System.DateTime> expirationDateField;

        private bool expirationDateFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> insideDeliveryField;

        private bool insideDeliveryFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> liftGateRequiredField;

        private bool liftGateRequiredFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> loadingDockField;

        private bool loadingDockFieldSpecified;

        private string mfrPartNumberField;

        private string pCNField;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private string salesRepEmailField;

        private string specialInstructionsField;

        private System.Nullable<System.DateTime> startDateField;

        private bool startDateFieldSpecified;

        private string weightField;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_ZonSalesLineInfo()
        {
            this.classField = "entity";
        }

       
        public string Agreement
        {
            get
            {
                return this.agreementField;
            }
            set
            {
                this.agreementField = value;
            }
        }

        
        
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        
        
        public string ContactEmail
        {
            get
            {
                return this.contactEmailField;
            }
            set
            {
                this.contactEmailField = value;
            }
        }

        
        
        public string ContactName
        {
            get
            {
                return this.contactNameField;
            }
            set
            {
                this.contactNameField = value;
            }
        }

        
        
        public string ContactPhone
        {
            get
            {
                return this.contactPhoneField;
            }
            set
            {
                this.contactPhoneField = value;
            }
        }

        
        
        public string Cost
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

        
        
        public string DescriptionLabel
        {
            get
            {
                return this.descriptionLabelField;
            }
            set
            {
                this.descriptionLabelField = value;
            }
        }

        
       
        public System.Nullable<System.DateTime> ExpirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }

        
        
        public bool ExpirationDateSpecified
        {
            get
            {
                return this.expirationDateFieldSpecified;
            }
            set
            {
                this.expirationDateFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_NoYes> InsideDelivery
        {
            get
            {
                return this.insideDeliveryField;
            }
            set
            {
                this.insideDeliveryField = value;
            }
        }

        
        
        public bool InsideDeliverySpecified
        {
            get
            {
                return this.insideDeliveryFieldSpecified;
            }
            set
            {
                this.insideDeliveryFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_NoYes> LiftGateRequired
        {
            get
            {
                return this.liftGateRequiredField;
            }
            set
            {
                this.liftGateRequiredField = value;
            }
        }

        
        
        public bool LiftGateRequiredSpecified
        {
            get
            {
                return this.liftGateRequiredFieldSpecified;
            }
            set
            {
                this.liftGateRequiredFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_NoYes> LoadingDock
        {
            get
            {
                return this.loadingDockField;
            }
            set
            {
                this.loadingDockField = value;
            }
        }

        
        
        public bool LoadingDockSpecified
        {
            get
            {
                return this.loadingDockFieldSpecified;
            }
            set
            {
                this.loadingDockFieldSpecified = value;
            }
        }

        
        
        public string MfrPartNumber
        {
            get
            {
                return this.mfrPartNumberField;
            }
            set
            {
                this.mfrPartNumberField = value;
            }
        }

        
        
        public string PCN
        {
            get
            {
                return this.pCNField;
            }
            set
            {
                this.pCNField = value;
            }
        }

        
        
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

        
        
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

        
        
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

        
        
        public string SalesRepEmail
        {
            get
            {
                return this.salesRepEmailField;
            }
            set
            {
                this.salesRepEmailField = value;
            }
        }

        
        
        public string SpecialInstructions
        {
            get
            {
                return this.specialInstructionsField;
            }
            set
            {
                this.specialInstructionsField = value;
            }
        }

        
        
        public System.Nullable<System.DateTime> StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        
        
        public bool StartDateSpecified
        {
            get
            {
                return this.startDateFieldSpecified;
            }
            set
            {
                this.startDateFieldSpecified = value;
            }
        }

        
        
        public string Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        
        
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        
        
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        
        
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/SalesOrder")]
    public partial class AxdEntity_MarkupTransLine
    {

        private System.Nullable<AxdExtType_MarkupKeep> keepField;

        private bool keepFieldSpecified;

        private System.Nullable<decimal> lineNumField;

        private bool lineNumFieldSpecified;

        private System.Nullable<AxdExtType_MarkupCategoryType> markupCategoryField;

        private bool markupCategoryFieldSpecified;

        private string markupCodeField;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private System.Nullable<decimal> valueField;

        private bool valueFieldSpecified;

        private System.Nullable<decimal> zonCommissionableCostField;

        private bool zonCommissionableCostFieldSpecified;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_MarkupTransLine()
        {
            this.classField = "entity";
        }

        
        
        public System.Nullable<AxdExtType_MarkupKeep> Keep
        {
            get
            {
                return this.keepField;
            }
            set
            {
                this.keepField = value;
            }
        }

        
        
        public bool KeepSpecified
        {
            get
            {
                return this.keepFieldSpecified;
            }
            set
            {
                this.keepFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> LineNum
        {
            get
            {
                return this.lineNumField;
            }
            set
            {
                this.lineNumField = value;
            }
        }

        
        
        public bool LineNumSpecified
        {
            get
            {
                return this.lineNumFieldSpecified;
            }
            set
            {
                this.lineNumFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdExtType_MarkupCategoryType> MarkupCategory
        {
            get
            {
                return this.markupCategoryField;
            }
            set
            {
                this.markupCategoryField = value;
            }
        }

        
        
        public bool MarkupCategorySpecified
        {
            get
            {
                return this.markupCategoryFieldSpecified;
            }
            set
            {
                this.markupCategoryFieldSpecified = value;
            }
        }

        
        public string MarkupCode
        {
            get
            {
                return this.markupCodeField;
            }
            set
            {
                this.markupCodeField = value;
            }
        }

        
        
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

        
        
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

        
        
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        
        
        public bool ValueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> ZonCommissionableCost
        {
            get
            {
                return this.zonCommissionableCostField;
            }
            set
            {
                this.zonCommissionableCostField = value;
            }
        }

        
        
        public bool ZonCommissionableCostSpecified
        {
            get
            {
                return this.zonCommissionableCostFieldSpecified;
            }
            set
            {
                this.zonCommissionableCostFieldSpecified = value;
            }
        }

        
        
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        
        
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        
        
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

    
     
    public enum AxdExtType_MarkupCategoryType
    {

        
        Fixed,

        
        Pcs,

        
        Percent,

        
        InterCompanyPercent,
    }

    
    
    public partial class AxdEntity_DocuRefLine
    {

        private string authorField;

        private AxdExtType_CreatedDateTime createdDateTimeField;

        private AxdExtType_ModifiedDateTime modifiedDateTimeField;

        private string nameField;

        private string notesField;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private System.Nullable<AxdEnum_DocuRestriction> restrictionField;

        private bool restrictionFieldSpecified;

        private string typeIdField;

        private string zonAuthorAliasField;

        private AxdExtType_CreatedDateTime zonCommentDateTimeField;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_DocuRefLine()
        {
            this.classField = "entity";
        }

        
        
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        
        
        public AxdExtType_CreatedDateTime CreatedDateTime
        {
            get
            {
                return this.createdDateTimeField;
            }
            set
            {
                this.createdDateTimeField = value;
            }
        }

        
        
        public AxdExtType_ModifiedDateTime ModifiedDateTime
        {
            get
            {
                return this.modifiedDateTimeField;
            }
            set
            {
                this.modifiedDateTimeField = value;
            }
        }

        
        
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        
        
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        
        
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

        
        
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

        
        
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_DocuRestriction> Restriction
        {
            get
            {
                return this.restrictionField;
            }
            set
            {
                this.restrictionField = value;
            }
        }

        
        
        public bool RestrictionSpecified
        {
            get
            {
                return this.restrictionFieldSpecified;
            }
            set
            {
                this.restrictionFieldSpecified = value;
            }
        }

        
        
        public string TypeId
        {
            get
            {
                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }

        
        
        public string ZonAuthorAlias
        {
            get
            {
                return this.zonAuthorAliasField;
            }
            set
            {
                this.zonAuthorAliasField = value;
            }
        }

        
        
        public AxdExtType_CreatedDateTime ZonCommentDateTime
        {
            get
            {
                return this.zonCommentDateTimeField;
            }
            set
            {
                this.zonCommentDateTimeField = value;
            }
        }

        
        
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        
        
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        
        
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

    
     
    public partial class AxdEntity_InventDim
    {

        private string configIdField;

        private string inventLocationIdField;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private string zonLocationNameField;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_InventDim()
        {
            this.classField = "entity";
        }

        
        
        public string ConfigId
        {
            get
            {
                return this.configIdField;
            }
            set
            {
                this.configIdField = value;
            }
        }

        
        
        public string InventLocationId
        {
            get
            {
                return this.inventLocationIdField;
            }
            set
            {
                this.inventLocationIdField = value;
            }
        }

        
        
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

        
        
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

        
        
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

        
        
        public string ZonLocationName
        {
            get
            {
                return this.zonLocationNameField;
            }
            set
            {
                this.zonLocationNameField = value;
            }
        }

        
        
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        
        
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        
        
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

    
  
    public partial class AxdEntity_LineDlvAddr
    {

        private string addressField;

        private string buildingComplimentField;

        private string cityField;

        private string countryRegionIdField;

        private string locationNameField;

        private System.Nullable<long> postalAddressField;

        private bool postalAddressFieldSpecified;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private string stateField;

        private string streetField;

        private string streetNumberField;

        private System.Nullable<AxdEnum_Timezone> timeZoneField;

        private bool timeZoneFieldSpecified;

        private AxdExtType_EffectiveDateTime validFromField;

        private AxdExtType_ExpirationDateTime validToField;

        private string zipCodeField;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_LineDlvAddr()
        {
            this.classField = "entity";
        }

        
        
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        
        
        public string BuildingCompliment
        {
            get
            {
                return this.buildingComplimentField;
            }
            set
            {
                this.buildingComplimentField = value;
            }
        }

        
        
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        
        
        public string CountryRegionId
        {
            get
            {
                return this.countryRegionIdField;
            }
            set
            {
                this.countryRegionIdField = value;
            }
        }

        
        
        public string LocationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;
            }
        }

        
        
        public System.Nullable<long> PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                this.postalAddressField = value;
            }
        }

        
        
        public bool PostalAddressSpecified
        {
            get
            {
                return this.postalAddressFieldSpecified;
            }
            set
            {
                this.postalAddressFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

        
        
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

        
        
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

        
        
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        
        
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        
        
        public string StreetNumber
        {
            get
            {
                return this.streetNumberField;
            }
            set
            {
                this.streetNumberField = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_Timezone> TimeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }

        
        
        public bool TimeZoneSpecified
        {
            get
            {
                return this.timeZoneFieldSpecified;
            }
            set
            {
                this.timeZoneFieldSpecified = value;
            }
        }

        
        
        public AxdExtType_EffectiveDateTime ValidFrom
        {
            get
            {
                return this.validFromField;
            }
            set
            {
                this.validFromField = value;
            }
        }

        
        
        public AxdExtType_ExpirationDateTime ValidTo
        {
            get
            {
                return this.validToField;
            }
            set
            {
                this.validToField = value;
            }
        }

        
        
        public string ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }

        
        
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        
        
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        
        
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

    
   
    public partial class AxdEntityKey_AgreementLine
    {
    }

    
     
    public partial class AxdType_LedgerAccount
    {

        private string displayValueField;

        private string mainAccountField;

        private AxdType_DimensionAttributeValue[] valuesField;

        
        public string DisplayValue
        {
            get
            {
                return this.displayValueField;
            }
            set
            {
                this.displayValueField = value;
            }
        }

        
        public string MainAccount
        {
            get
            {
                return this.mainAccountField;
            }
            set
            {
                this.mainAccountField = value;
            }
        }

        
         
        public AxdType_DimensionAttributeValue[] Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
    }

    
    
    public partial class AxdType_DimensionAttributeValue
    {

        private string nameField;

        private string valueField;

        
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    
     
    public partial class AxdEntity_SalesLine
    {

        private System.Nullable<AxdExtType_LineStopped> blockedField;

        private bool blockedFieldSpecified;

        private System.Nullable<AxdExtType_LineComplete> completeField;

        private bool completeFieldSpecified;

        private System.Nullable<System.DateTime> confirmedDlvField;

        private bool confirmedDlvFieldSpecified;

        private System.Nullable<decimal> costPriceField;

        private bool costPriceFieldSpecified;

        private string currencyCodeField;

        private string custAccountField;

        private string customerRefField;

        private AxdType_DimensionAttributeValueSet defaultDimensionField;

        private string deliveryNameField;

        private AxdEntityKey_LogisticsPostalAddress deliveryPostalAddressField;

        private System.Nullable<AxdExtType_TradeLineDlvTypeId> deliveryTypeField;

        private bool deliveryTypeFieldSpecified;

        private string dlvModeField;

        private System.Nullable<decimal> expectedRetQtyField;

        private bool expectedRetQtyFieldSpecified;

        private string inventRefIdField;

        private string inventRefTransIdField;

        private System.Nullable<AxdEnum_InventRefType> inventRefTypeField;

        private bool inventRefTypeFieldSpecified;

        private string itemIdField;

        private string itemNameField;

        private AxdType_LedgerAccount ledgerDimensionField;

        private System.Nullable<decimal> lineAmountField;

        private bool lineAmountFieldSpecified;

        private System.Nullable<decimal> lineDiscField;

        private bool lineDiscFieldSpecified;

        private System.Nullable<decimal> lineNumField;

        private bool lineNumFieldSpecified;

        private System.Nullable<decimal> linePercentField;

        private bool linePercentFieldSpecified;

        private AxdEntityKey_AgreementLine matchingAgreementLineField;

        private string nameField;

        private System.Nullable<decimal> overDeliveryPctField;

        private bool overDeliveryPctFieldSpecified;

        private System.Nullable<decimal> priceUnitField;

        private bool priceUnitFieldSpecified;

        private string purchorderFormNumField;

        private System.Nullable<decimal> qtyOrderedField;

        private bool qtyOrderedFieldSpecified;

        private System.Nullable<System.DateTime> receiptDateConfirmedField;

        private bool receiptDateConfirmedFieldSpecified;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private System.Nullable<AxdEnum_ReturnStatusLine> returnStatusField;

        private bool returnStatusFieldSpecified;

        private string salesGroupField;

        private string salesIdField;

        private System.Nullable<decimal> salesPriceField;

        private bool salesPriceFieldSpecified;

        private decimal salesQtyField;

        private string salesStatusField;

        private System.Nullable<AxdEnum_SalesType> salesTypeField;

        private bool salesTypeFieldSpecified;

        private string salesUnitField;

        private string shipCarrierAccountField;

        private string shipCarrierAccountCodeField;

        private System.Nullable<AxdEnum_ShipCarrierDlvType> shipCarrierDlvTypeField;

        private bool shipCarrierDlvTypeFieldSpecified;

        private string shipCarrierIdField;

        private string shipCarrierNameField;

        private AxdEntityKey_LogisticsPostalAddress shipCarrierPostalAddressField;

        private System.Nullable<System.DateTime> shippingDateConfirmedField;

        private bool shippingDateConfirmedFieldSpecified;

        private System.Nullable<decimal> zonCommissionableCostField;

        private bool zonCommissionableCostFieldSpecified;

        private System.Nullable<decimal> zonCostField;

        private bool zonCostFieldSpecified;

        private string zonDeliveryContactField;

        private string zonDeliveryContactNameField;

        private System.Nullable<decimal> zonDiscussionaryFundField;

        private bool zonDiscussionaryFundFieldSpecified;

        private System.Nullable<decimal> zonDisplayCostField;

        private bool zonDisplayCostFieldSpecified;

        private System.Nullable<AxdExtType_ZonNonReturnable> zonIsItemNonReturnableField;

        private bool zonIsItemNonReturnableFieldSpecified;

        private System.Nullable<AxdEnum_boolean> zonKitHeaderField;

        private bool zonKitHeaderFieldSpecified;

        private string zonKitLinkField;

        private System.Nullable<System.DateTime> zonLastUpdateField;

        private bool zonLastUpdateFieldSpecified;

        private System.Nullable<decimal> zonLineMarginField;

        private bool zonLineMarginFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> zonModifiableField;

        private bool zonModifiableFieldSpecified;

        private string zonOnyxIDField;

        private System.Nullable<System.DateTime> zonPOConfirmationDateField;

        private bool zonPOConfirmationDateFieldSpecified;

        private System.Nullable<decimal> zonPrevSalesPriceField;

        private bool zonPrevSalesPriceFieldSpecified;

        private System.Nullable<decimal> zonPrevSalesQtyField;

        private bool zonPrevSalesQtyFieldSpecified;

        private string zonPurchAgreementIdField;

        private System.Nullable<int> zonSequenceNumberField;

        private bool zonSequenceNumberFieldSpecified;

        private string zonSOLevelField;

        private AxdEntity_LineDlvAddr[] lineDlvAddrField;

        private AxdEntity_InventDim[] inventDimField;

        private AxdEntity_DocuRefLine[] docuRefLineField;

        private AxdEntity_MarkupTransLine[] markupTransLineField;

        private AxdEntity_ZonSalesLineInfo[] zonSalesLineInfoField;

        private AxdEntity_ZonSalesLineExtension[] zonSalesLineExtensionField;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_SalesLine()
        {
            this.classField = "entity";
        }

        
        
        public System.Nullable<AxdExtType_LineStopped> Blocked
        {
            get
            {
                return this.blockedField;
            }
            set
            {
                this.blockedField = value;
            }
        }

        
        
        public bool BlockedSpecified
        {
            get
            {
                return this.blockedFieldSpecified;
            }
            set
            {
                this.blockedFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdExtType_LineComplete> Complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        
        
        public bool CompleteSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        
       
        public System.Nullable<System.DateTime> ConfirmedDlv
        {
            get
            {
                return this.confirmedDlvField;
            }
            set
            {
                this.confirmedDlvField = value;
            }
        }

        
        
        public bool ConfirmedDlvSpecified
        {
            get
            {
                return this.confirmedDlvFieldSpecified;
            }
            set
            {
                this.confirmedDlvFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> CostPrice
        {
            get
            {
                return this.costPriceField;
            }
            set
            {
                this.costPriceField = value;
            }
        }

        
        
        public bool CostPriceSpecified
        {
            get
            {
                return this.costPriceFieldSpecified;
            }
            set
            {
                this.costPriceFieldSpecified = value;
            }
        }

        
        
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        
        
        public string CustAccount
        {
            get
            {
                return this.custAccountField;
            }
            set
            {
                this.custAccountField = value;
            }
        }

        
        
        public string CustomerRef
        {
            get
            {
                return this.customerRefField;
            }
            set
            {
                this.customerRefField = value;
            }
        }

        
        
        public AxdType_DimensionAttributeValueSet DefaultDimension
        {
            get
            {
                return this.defaultDimensionField;
            }
            set
            {
                this.defaultDimensionField = value;
            }
        }

        
        
        public string DeliveryName
        {
            get
            {
                return this.deliveryNameField;
            }
            set
            {
                this.deliveryNameField = value;
            }
        }

        
        
        public AxdEntityKey_LogisticsPostalAddress DeliveryPostalAddress
        {
            get
            {
                return this.deliveryPostalAddressField;
            }
            set
            {
                this.deliveryPostalAddressField = value;
            }
        }

        
        
        public System.Nullable<AxdExtType_TradeLineDlvTypeId> DeliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        
        
        public bool DeliveryTypeSpecified
        {
            get
            {
                return this.deliveryTypeFieldSpecified;
            }
            set
            {
                this.deliveryTypeFieldSpecified = value;
            }
        }

        
        
        public string DlvMode
        {
            get
            {
                return this.dlvModeField;
            }
            set
            {
                this.dlvModeField = value;
            }
        }

        
        
        public System.Nullable<decimal> ExpectedRetQty
        {
            get
            {
                return this.expectedRetQtyField;
            }
            set
            {
                this.expectedRetQtyField = value;
            }
        }

        
        
        public bool ExpectedRetQtySpecified
        {
            get
            {
                return this.expectedRetQtyFieldSpecified;
            }
            set
            {
                this.expectedRetQtyFieldSpecified = value;
            }
        }

        
        
        public string InventRefId
        {
            get
            {
                return this.inventRefIdField;
            }
            set
            {
                this.inventRefIdField = value;
            }
        }

        
        
        public string InventRefTransId
        {
            get
            {
                return this.inventRefTransIdField;
            }
            set
            {
                this.inventRefTransIdField = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_InventRefType> InventRefType
        {
            get
            {
                return this.inventRefTypeField;
            }
            set
            {
                this.inventRefTypeField = value;
            }
        }

        
        
        public bool InventRefTypeSpecified
        {
            get
            {
                return this.inventRefTypeFieldSpecified;
            }
            set
            {
                this.inventRefTypeFieldSpecified = value;
            }
        }

        
        
        public string ItemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }

        
        
        public string ItemName
        {
            get
            {
                return this.itemNameField;
            }
            set
            {
                this.itemNameField = value;
            }
        }

        
        
        public AxdType_LedgerAccount LedgerDimension
        {
            get
            {
                return this.ledgerDimensionField;
            }
            set
            {
                this.ledgerDimensionField = value;
            }
        }

        
        
        public System.Nullable<decimal> LineAmount
        {
            get
            {
                return this.lineAmountField;
            }
            set
            {
                this.lineAmountField = value;
            }
        }

        
        
        public bool LineAmountSpecified
        {
            get
            {
                return this.lineAmountFieldSpecified;
            }
            set
            {
                this.lineAmountFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> LineDisc
        {
            get
            {
                return this.lineDiscField;
            }
            set
            {
                this.lineDiscField = value;
            }
        }

        
        
        public bool LineDiscSpecified
        {
            get
            {
                return this.lineDiscFieldSpecified;
            }
            set
            {
                this.lineDiscFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> LineNum
        {
            get
            {
                return this.lineNumField;
            }
            set
            {
                this.lineNumField = value;
            }
        }

        
        
        public bool LineNumSpecified
        {
            get
            {
                return this.lineNumFieldSpecified;
            }
            set
            {
                this.lineNumFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> LinePercent
        {
            get
            {
                return this.linePercentField;
            }
            set
            {
                this.linePercentField = value;
            }
        }

        
        
        public bool LinePercentSpecified
        {
            get
            {
                return this.linePercentFieldSpecified;
            }
            set
            {
                this.linePercentFieldSpecified = value;
            }
        }

        
        
        public AxdEntityKey_AgreementLine MatchingAgreementLine
        {
            get
            {
                return this.matchingAgreementLineField;
            }
            set
            {
                this.matchingAgreementLineField = value;
            }
        }

        
        
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        
        
        public System.Nullable<decimal> OverDeliveryPct
        {
            get
            {
                return this.overDeliveryPctField;
            }
            set
            {
                this.overDeliveryPctField = value;
            }
        }

        
        
        public bool OverDeliveryPctSpecified
        {
            get
            {
                return this.overDeliveryPctFieldSpecified;
            }
            set
            {
                this.overDeliveryPctFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> PriceUnit
        {
            get
            {
                return this.priceUnitField;
            }
            set
            {
                this.priceUnitField = value;
            }
        }

        
        
        public bool PriceUnitSpecified
        {
            get
            {
                return this.priceUnitFieldSpecified;
            }
            set
            {
                this.priceUnitFieldSpecified = value;
            }
        }

        
        
        public string PurchorderFormNum
        {
            get
            {
                return this.purchorderFormNumField;
            }
            set
            {
                this.purchorderFormNumField = value;
            }
        }

        
        
        public System.Nullable<decimal> QtyOrdered
        {
            get
            {
                return this.qtyOrderedField;
            }
            set
            {
                this.qtyOrderedField = value;
            }
        }

        
        
        public bool QtyOrderedSpecified
        {
            get
            {
                return this.qtyOrderedFieldSpecified;
            }
            set
            {
                this.qtyOrderedFieldSpecified = value;
            }
        }

        
       
        public System.Nullable<System.DateTime> ReceiptDateConfirmed
        {
            get
            {
                return this.receiptDateConfirmedField;
            }
            set
            {
                this.receiptDateConfirmedField = value;
            }
        }

        
        
        public bool ReceiptDateConfirmedSpecified
        {
            get
            {
                return this.receiptDateConfirmedFieldSpecified;
            }
            set
            {
                this.receiptDateConfirmedFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

        
        
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

        
        
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_ReturnStatusLine> ReturnStatus
        {
            get
            {
                return this.returnStatusField;
            }
            set
            {
                this.returnStatusField = value;
            }
        }

        
        
        public bool ReturnStatusSpecified
        {
            get
            {
                return this.returnStatusFieldSpecified;
            }
            set
            {
                this.returnStatusFieldSpecified = value;
            }
        }

        
        
        public string SalesGroup
        {
            get
            {
                return this.salesGroupField;
            }
            set
            {
                this.salesGroupField = value;
            }
        }

        
        
        public string SalesId
        {
            get
            {
                return this.salesIdField;
            }
            set
            {
                this.salesIdField = value;
            }
        }

        
        
        public System.Nullable<decimal> SalesPrice
        {
            get
            {
                return this.salesPriceField;
            }
            set
            {
                this.salesPriceField = value;
            }
        }

        
        
        public bool SalesPriceSpecified
        {
            get
            {
                return this.salesPriceFieldSpecified;
            }
            set
            {
                this.salesPriceFieldSpecified = value;
            }
        }

        
        public decimal SalesQty
        {
            get
            {
                return this.salesQtyField;
            }
            set
            {
                this.salesQtyField = value;
            }
        }

        
        
        public string SalesStatus
        {
            get
            {
                return this.salesStatusField;
            }
            set
            {
                this.salesStatusField = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_SalesType> SalesType
        {
            get
            {
                return this.salesTypeField;
            }
            set
            {
                this.salesTypeField = value;
            }
        }

        
        
        public bool SalesTypeSpecified
        {
            get
            {
                return this.salesTypeFieldSpecified;
            }
            set
            {
                this.salesTypeFieldSpecified = value;
            }
        }

        
        public string SalesUnit
        {
            get
            {
                return this.salesUnitField;
            }
            set
            {
                this.salesUnitField = value;
            }
        }

        
        
        public string ShipCarrierAccount
        {
            get
            {
                return this.shipCarrierAccountField;
            }
            set
            {
                this.shipCarrierAccountField = value;
            }
        }

        
        
        public string ShipCarrierAccountCode
        {
            get
            {
                return this.shipCarrierAccountCodeField;
            }
            set
            {
                this.shipCarrierAccountCodeField = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_ShipCarrierDlvType> ShipCarrierDlvType
        {
            get
            {
                return this.shipCarrierDlvTypeField;
            }
            set
            {
                this.shipCarrierDlvTypeField = value;
            }
        }

        
        
        public bool ShipCarrierDlvTypeSpecified
        {
            get
            {
                return this.shipCarrierDlvTypeFieldSpecified;
            }
            set
            {
                this.shipCarrierDlvTypeFieldSpecified = value;
            }
        }

        
        
        public string ShipCarrierId
        {
            get
            {
                return this.shipCarrierIdField;
            }
            set
            {
                this.shipCarrierIdField = value;
            }
        }

        
        
        public string ShipCarrierName
        {
            get
            {
                return this.shipCarrierNameField;
            }
            set
            {
                this.shipCarrierNameField = value;
            }
        }

        
        
        public AxdEntityKey_LogisticsPostalAddress ShipCarrierPostalAddress
        {
            get
            {
                return this.shipCarrierPostalAddressField;
            }
            set
            {
                this.shipCarrierPostalAddressField = value;
            }
        }

        
        
        public System.Nullable<System.DateTime> ShippingDateConfirmed
        {
            get
            {
                return this.shippingDateConfirmedField;
            }
            set
            {
                this.shippingDateConfirmedField = value;
            }
        }

        
        
        public bool ShippingDateConfirmedSpecified
        {
            get
            {
                return this.shippingDateConfirmedFieldSpecified;
            }
            set
            {
                this.shippingDateConfirmedFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> ZonCommissionableCost
        {
            get
            {
                return this.zonCommissionableCostField;
            }
            set
            {
                this.zonCommissionableCostField = value;
            }
        }

        
        
        public bool ZonCommissionableCostSpecified
        {
            get
            {
                return this.zonCommissionableCostFieldSpecified;
            }
            set
            {
                this.zonCommissionableCostFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> ZonCost
        {
            get
            {
                return this.zonCostField;
            }
            set
            {
                this.zonCostField = value;
            }
        }

        
        
        public bool ZonCostSpecified
        {
            get
            {
                return this.zonCostFieldSpecified;
            }
            set
            {
                this.zonCostFieldSpecified = value;
            }
        }

        
        
        public string ZonDeliveryContact
        {
            get
            {
                return this.zonDeliveryContactField;
            }
            set
            {
                this.zonDeliveryContactField = value;
            }
        }

        
        
        public string ZonDeliveryContactName
        {
            get
            {
                return this.zonDeliveryContactNameField;
            }
            set
            {
                this.zonDeliveryContactNameField = value;
            }
        }

        
        
        public System.Nullable<decimal> ZonDiscussionaryFund
        {
            get
            {
                return this.zonDiscussionaryFundField;
            }
            set
            {
                this.zonDiscussionaryFundField = value;
            }
        }

        
        
        public bool ZonDiscussionaryFundSpecified
        {
            get
            {
                return this.zonDiscussionaryFundFieldSpecified;
            }
            set
            {
                this.zonDiscussionaryFundFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> ZonDisplayCost
        {
            get
            {
                return this.zonDisplayCostField;
            }
            set
            {
                this.zonDisplayCostField = value;
            }
        }

        
        
        public bool ZonDisplayCostSpecified
        {
            get
            {
                return this.zonDisplayCostFieldSpecified;
            }
            set
            {
                this.zonDisplayCostFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdExtType_ZonNonReturnable> ZonIsItemNonReturnable
        {
            get
            {
                return this.zonIsItemNonReturnableField;
            }
            set
            {
                this.zonIsItemNonReturnableField = value;
            }
        }

        
        
        public bool ZonIsItemNonReturnableSpecified
        {
            get
            {
                return this.zonIsItemNonReturnableFieldSpecified;
            }
            set
            {
                this.zonIsItemNonReturnableFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_boolean> ZonKitHeader
        {
            get
            {
                return this.zonKitHeaderField;
            }
            set
            {
                this.zonKitHeaderField = value;
            }
        }

        
        
        public bool ZonKitHeaderSpecified
        {
            get
            {
                return this.zonKitHeaderFieldSpecified;
            }
            set
            {
                this.zonKitHeaderFieldSpecified = value;
            }
        }

        
        
        public string ZonKitLink
        {
            get
            {
                return this.zonKitLinkField;
            }
            set
            {
                this.zonKitLinkField = value;
            }
        }

        
       
        public System.Nullable<System.DateTime> ZonLastUpdate
        {
            get
            {
                return this.zonLastUpdateField;
            }
            set
            {
                this.zonLastUpdateField = value;
            }
        }

        
        
        public bool ZonLastUpdateSpecified
        {
            get
            {
                return this.zonLastUpdateFieldSpecified;
            }
            set
            {
                this.zonLastUpdateFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> ZonLineMargin
        {
            get
            {
                return this.zonLineMarginField;
            }
            set
            {
                this.zonLineMarginField = value;
            }
        }

        
        
        public bool ZonLineMarginSpecified
        {
            get
            {
                return this.zonLineMarginFieldSpecified;
            }
            set
            {
                this.zonLineMarginFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_NoYes> ZonModifiable
        {
            get
            {
                return this.zonModifiableField;
            }
            set
            {
                this.zonModifiableField = value;
            }
        }

        
        
        public bool ZonModifiableSpecified
        {
            get
            {
                return this.zonModifiableFieldSpecified;
            }
            set
            {
                this.zonModifiableFieldSpecified = value;
            }
        }

        
        
        public string ZonOnyxID
        {
            get
            {
                return this.zonOnyxIDField;
            }
            set
            {
                this.zonOnyxIDField = value;
            }
        }

        
       
        public System.Nullable<System.DateTime> ZonPOConfirmationDate
        {
            get
            {
                return this.zonPOConfirmationDateField;
            }
            set
            {
                this.zonPOConfirmationDateField = value;
            }
        }

        
        
        public bool ZonPOConfirmationDateSpecified
        {
            get
            {
                return this.zonPOConfirmationDateFieldSpecified;
            }
            set
            {
                this.zonPOConfirmationDateFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> ZonPrevSalesPrice
        {
            get
            {
                return this.zonPrevSalesPriceField;
            }
            set
            {
                this.zonPrevSalesPriceField = value;
            }
        }

        
        
        public bool ZonPrevSalesPriceSpecified
        {
            get
            {
                return this.zonPrevSalesPriceFieldSpecified;
            }
            set
            {
                this.zonPrevSalesPriceFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> ZonPrevSalesQty
        {
            get
            {
                return this.zonPrevSalesQtyField;
            }
            set
            {
                this.zonPrevSalesQtyField = value;
            }
        }

        
        
        public bool ZonPrevSalesQtySpecified
        {
            get
            {
                return this.zonPrevSalesQtyFieldSpecified;
            }
            set
            {
                this.zonPrevSalesQtyFieldSpecified = value;
            }
        }

        
        
        public string ZonPurchAgreementId
        {
            get
            {
                return this.zonPurchAgreementIdField;
            }
            set
            {
                this.zonPurchAgreementIdField = value;
            }
        }

        
        
        public System.Nullable<int> ZonSequenceNumber
        {
            get
            {
                return this.zonSequenceNumberField;
            }
            set
            {
                this.zonSequenceNumberField = value;
            }
        }

        
        
        public bool ZonSequenceNumberSpecified
        {
            get
            {
                return this.zonSequenceNumberFieldSpecified;
            }
            set
            {
                this.zonSequenceNumberFieldSpecified = value;
            }
        }

        
        
        public string ZonSOLevel
        {
            get
            {
                return this.zonSOLevelField;
            }
            set
            {
                this.zonSOLevelField = value;
            }
        }

        
       
        public AxdEntity_LineDlvAddr[] LineDlvAddr
        {
            get
            {
                return this.lineDlvAddrField;
            }
            set
            {
                this.lineDlvAddrField = value;
            }
        }

        
        
        public AxdEntity_InventDim[] InventDim
        {
            get
            {
                return this.inventDimField;
            }
            set
            {
                this.inventDimField = value;
            }
        }

        
        public AxdEntity_DocuRefLine[] DocuRefLine
        {
            get
            {
                return this.docuRefLineField;
            }
            set
            {
                this.docuRefLineField = value;
            }
        }

        
        public AxdEntity_MarkupTransLine[] MarkupTransLine
        {
            get
            {
                return this.markupTransLineField;
            }
            set
            {
                this.markupTransLineField = value;
            }
        }

        
        public AxdEntity_ZonSalesLineInfo[] ZonSalesLineInfo
        {
            get
            {
                return this.zonSalesLineInfoField;
            }
            set
            {
                this.zonSalesLineInfoField = value;
            }
        }

        
        public AxdEntity_ZonSalesLineExtension[] ZonSalesLineExtension
        {
            get
            {
                return this.zonSalesLineExtensionField;
            }
            set
            {
                this.zonSalesLineExtensionField = value;
            }
        }

        
        
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        
        
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        
        
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

    
   
    public enum AxdExtType_LineStopped
    {

        
        No,

        
        Yes,
    }

    
    
    public enum AxdExtType_LineComplete
    {

        
        No,

        
        Yes,
    }

    
  
    public partial class AxdType_DimensionAttributeValueSet
    {

        private AxdType_DimensionAttributeValue[] valuesField;

        
        public AxdType_DimensionAttributeValue[] Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
    }

    
    
    public partial class AxdEntityKey_LogisticsPostalAddress
    {

        private string location_LocationIdField;

        private AxdExtType_EffectiveDateTime validFromField;

        
        public string Location_LocationId
        {
            get
            {
                return this.location_LocationIdField;
            }
            set
            {
                this.location_LocationIdField = value;
            }
        }

        
        public AxdExtType_EffectiveDateTime ValidFrom
        {
            get
            {
                return this.validFromField;
            }
            set
            {
                this.validFromField = value;
            }
        }
    }

    
     
    public enum AxdExtType_TradeLineDlvTypeId
    {

        
        None,

        
        DropShip,
    }

   
    public enum AxdEnum_InventRefType
    {

        
        None,

        
        Sales,

        
        Purch,

        
        Production,

        
        ProdLine,

        
        InventJournal,

        
        CRMQuotation,

        
        InventTransfer,

        
        FixedAsset,
    }

    
    
    public enum AxdEnum_ReturnStatusLine
    {

        
        None,

        
        Awaiting,

        
        Registered,

        
        Quarantine,

        
        Received,

        
        Invoiced,

        
        Canceled,
    }

    
    
    public enum AxdEnum_SalesType
    {

        
        Journal,

        
        DEL_Quotation,

        
        Subscription,

        
        Sales,

        
        ReturnItem,

        
        DEL_Blanket,

        
        ItemReq,
    }

    
   
    public enum AxdEnum_ShipCarrierDlvType
    {

        
        Misc,

        
        Ground,

        
        Air,

        
        PickUp,
    }

    
  
    public enum AxdExtType_ZonNonReturnable
    {

        
        No,

        
        Yes,
    }

    
    
    public partial class AxdEntity_TableDlvAddr
    {

        private string addressField;

        private string cityField;

        private string countryRegionIdField;

        private string stateField;

        private string streetField;

        private string zipCodeField;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_TableDlvAddr()
        {
            this.classField = "entity";
        }

        
        
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        
        
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        
        
        public string CountryRegionId
        {
            get
            {
                return this.countryRegionIdField;
            }
            set
            {
                this.countryRegionIdField = value;
            }
        }

        
        
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        
        
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        
        
        public string ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }

        
        
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        
        
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        
        
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

    
   
    public partial class AxdEntity_SalesTable
    {

        private string _DocumentHashField;

        private string createdByField;

        private AxdExtType_CreatedDateTime createdDateTimeField;

        private string currencyCodeField;

        private string custAccountField;

        private string custInvoiceIdField;

        private string customerRefField;

        private System.Nullable<System.DateTime> deadlineField;

        private bool deadlineFieldSpecified;

        private AxdType_DimensionAttributeValueSet defaultDimensionField;

        private System.Nullable<System.DateTime> deliveryDateField;

        private bool deliveryDateFieldSpecified;

        private string deliveryNameField;

        private AxdEntityKey_LogisticsPostalAddress deliveryPostalAddressField;

        private string dlvModeField;

        private string dlvTermField;

        private System.Nullable<AxdEnum_DocumentStatus> documentStatusField;

        private bool documentStatusFieldSpecified;

        private string emailField;

        private string exportReasonField;

        private string freightZoneField;

        private string invoiceAccountField;

        private string invoiceAddressField;

        private string invoiceCityField;

        private string invoiceCountryRegionIdField;

        private string invoiceCountyField;

        private string invoiceLocationNameField;

        private string invoiceStateField;

        private string invoiceStreetField;

        private string invoiceStreetNumberField;

        private string invoiceZipCodeField;

        private AxdExtType_ModifiedDateTime modifiedDateTimeField;

        private string paymModeField;

        private string phoneField;

        private string purchIdField;

        private string purchOrderFormNumField;

        private System.DateTime receiptDateRequestedField;

        private System.Nullable<long> recIdField;

        private bool recIdFieldSpecified;

        private System.Nullable<int> recVersionField;

        private bool recVersionFieldSpecified;

        private string salesIdField;

        private string salesNameField;

        private string salesOriginIdField;

        private string salesPoolIdField;

        private System.Nullable<AxdEnum_SalesStatus> salesStatusField;

        private bool salesStatusFieldSpecified;

        private System.Nullable<AxdEnum_SalesType> salesTypeField;

        private bool salesTypeFieldSpecified;

        private string salesUnitIdField;

        private string shipCarrierAccountField;

        private string shipCarrierAccountCodeField;

        private System.Nullable<AxdExtType_ShipCarrierBlindShipment> shipCarrierBlindShipmentField;

        private bool shipCarrierBlindShipmentFieldSpecified;

        private string shipCarrierDeliveryContactField;

        private System.Nullable<AxdEnum_ShipCarrierDlvType> shipCarrierDlvTypeField;

        private bool shipCarrierDlvTypeFieldSpecified;

        private string shipCarrierIdField;

        private string shipCarrierNameField;

        private AxdEntityKey_LogisticsPostalAddress shipCarrierPostalAddressField;

        private System.Nullable<System.DateTime> shippingDateConfirmedField;

        private bool shippingDateConfirmedFieldSpecified;

        private System.Nullable<System.DateTime> shippingDateRequestedField;

        private bool shippingDateRequestedFieldSpecified;

        private System.Nullable<decimal> smmSalesAmountTotalField;

        private bool smmSalesAmountTotalFieldSpecified;

        private string workerSalesResponsibleField;

        private System.Nullable<AxdExtType_ZonBillCompleted> zonBillCompletedField;

        private bool zonBillCompletedFieldSpecified;

        private string zonCompanyOnyxIDField;

        private System.Nullable<System.DateTime> zonConfirmationDateField;

        private bool zonConfirmationDateFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> zonConfirmationStatusField;

        private bool zonConfirmationStatusFieldSpecified;

        private string zonFreightReasonField;

        private System.Nullable<AxdExtType_ZonGiftReceipts> zonGiftReceiptField;

        private bool zonGiftReceiptFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> zonIsGAMOrderField;

        private bool zonIsGAMOrderFieldSpecified;

        private System.Nullable<System.DateTime> zonLastUpdateField;

        private bool zonLastUpdateFieldSpecified;

        private string zonOnyxIDField;

        private System.Nullable<System.DateTime> zonOrderDateField;

        private bool zonOrderDateFieldSpecified;

        private System.Nullable<AxdEnum_ZonOrderSource> zonOrderSourceField;

        private bool zonOrderSourceFieldSpecified;

        private System.Nullable<AxdEnum_ZonOrderType> zonOrderTypeField;

        private bool zonOrderTypeFieldSpecified;

        private System.Nullable<AxdEnum_NoYes> zonOverrideFinancialDimensionField;

        private bool zonOverrideFinancialDimensionFieldSpecified;

        private System.Nullable<AxdEnum_ZonQuoteStatus> zonQuoteStatusField;

        private bool zonQuoteStatusFieldSpecified;

        private string zonSalesResponsibleField;

        private string zonSOBuyerField;

        private System.Nullable<AxdExtType_ZonSuppressInvoice> zonSuppressInvoiceField;

        private bool zonSuppressInvoiceFieldSpecified;

        private string zonTaxExemptionTypeField;

        private System.Nullable<System.DateTime> zonVertexOrigDlvDateField;

        private bool zonVertexOrigDlvDateFieldSpecified;

        private AxdEntity_TableDlvAddr[] tableDlvAddrField;

        private AxdEntity_SalesLine[] salesLineField;

        private AxdEntity_DocuRefHeader[] docuRefHeaderField;

        private AxdEntity_MarkupTransHeader[] markupTransHeaderField;

        private AxdEntity_ZonCustAddlCreditCards[] zonCustAddlCreditCardsField;

        private AxdEntity_ZonSalesTableExtension[] zonSalesTableExtensionField;

        private string classField;

        private AxdEnum_AxdEntityAction actionField;

        private bool actionFieldSpecified;

        public AxdEntity_SalesTable()
        {
            this.classField = "entity";
        }

        
        
        public string _DocumentHash
        {
            get
            {
                return this._DocumentHashField;
            }
            set
            {
                this._DocumentHashField = value;
            }
        }

        
        
        public string CreatedBy
        {
            get
            {
                return this.createdByField;
            }
            set
            {
                this.createdByField = value;
            }
        }

        
        
        public AxdExtType_CreatedDateTime CreatedDateTime
        {
            get
            {
                return this.createdDateTimeField;
            }
            set
            {
                this.createdDateTimeField = value;
            }
        }

        
        
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        
        
        public string CustAccount
        {
            get
            {
                return this.custAccountField;
            }
            set
            {
                this.custAccountField = value;
            }
        }

        
        
        public string CustInvoiceId
        {
            get
            {
                return this.custInvoiceIdField;
            }
            set
            {
                this.custInvoiceIdField = value;
            }
        }

        
        
        public string CustomerRef
        {
            get
            {
                return this.customerRefField;
            }
            set
            {
                this.customerRefField = value;
            }
        }

        
        public System.Nullable<System.DateTime> Deadline
        {
            get
            {
                return this.deadlineField;
            }
            set
            {
                this.deadlineField = value;
            }
        }

        
        
        public bool DeadlineSpecified
        {
            get
            {
                return this.deadlineFieldSpecified;
            }
            set
            {
                this.deadlineFieldSpecified = value;
            }
        }

        
        
        public AxdType_DimensionAttributeValueSet DefaultDimension
        {
            get
            {
                return this.defaultDimensionField;
            }
            set
            {
                this.defaultDimensionField = value;
            }
        }

        
        public System.Nullable<System.DateTime> DeliveryDate
        {
            get
            {
                return this.deliveryDateField;
            }
            set
            {
                this.deliveryDateField = value;
            }
        }

        
        
        public bool DeliveryDateSpecified
        {
            get
            {
                return this.deliveryDateFieldSpecified;
            }
            set
            {
                this.deliveryDateFieldSpecified = value;
            }
        }

        
        
        public string DeliveryName
        {
            get
            {
                return this.deliveryNameField;
            }
            set
            {
                this.deliveryNameField = value;
            }
        }

        
        
        public AxdEntityKey_LogisticsPostalAddress DeliveryPostalAddress
        {
            get
            {
                return this.deliveryPostalAddressField;
            }
            set
            {
                this.deliveryPostalAddressField = value;
            }
        }

        
        
        public string DlvMode
        {
            get
            {
                return this.dlvModeField;
            }
            set
            {
                this.dlvModeField = value;
            }
        }

        
        
        public string DlvTerm
        {
            get
            {
                return this.dlvTermField;
            }
            set
            {
                this.dlvTermField = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_DocumentStatus> DocumentStatus
        {
            get
            {
                return this.documentStatusField;
            }
            set
            {
                this.documentStatusField = value;
            }
        }

        
        
        public bool DocumentStatusSpecified
        {
            get
            {
                return this.documentStatusFieldSpecified;
            }
            set
            {
                this.documentStatusFieldSpecified = value;
            }
        }

        
        
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        
        
        public string ExportReason
        {
            get
            {
                return this.exportReasonField;
            }
            set
            {
                this.exportReasonField = value;
            }
        }

        
        
        public string FreightZone
        {
            get
            {
                return this.freightZoneField;
            }
            set
            {
                this.freightZoneField = value;
            }
        }

        
        
        public string InvoiceAccount
        {
            get
            {
                return this.invoiceAccountField;
            }
            set
            {
                this.invoiceAccountField = value;
            }
        }

        
        
        public string InvoiceAddress
        {
            get
            {
                return this.invoiceAddressField;
            }
            set
            {
                this.invoiceAddressField = value;
            }
        }

        
        
        public string InvoiceCity
        {
            get
            {
                return this.invoiceCityField;
            }
            set
            {
                this.invoiceCityField = value;
            }
        }

        
        
        public string InvoiceCountryRegionId
        {
            get
            {
                return this.invoiceCountryRegionIdField;
            }
            set
            {
                this.invoiceCountryRegionIdField = value;
            }
        }

        
        
        public string InvoiceCounty
        {
            get
            {
                return this.invoiceCountyField;
            }
            set
            {
                this.invoiceCountyField = value;
            }
        }

        
        
        public string InvoiceLocationName
        {
            get
            {
                return this.invoiceLocationNameField;
            }
            set
            {
                this.invoiceLocationNameField = value;
            }
        }

        
        
        public string InvoiceState
        {
            get
            {
                return this.invoiceStateField;
            }
            set
            {
                this.invoiceStateField = value;
            }
        }

        
        
        public string InvoiceStreet
        {
            get
            {
                return this.invoiceStreetField;
            }
            set
            {
                this.invoiceStreetField = value;
            }
        }

        
        
        public string InvoiceStreetNumber
        {
            get
            {
                return this.invoiceStreetNumberField;
            }
            set
            {
                this.invoiceStreetNumberField = value;
            }
        }

        
        
        public string InvoiceZipCode
        {
            get
            {
                return this.invoiceZipCodeField;
            }
            set
            {
                this.invoiceZipCodeField = value;
            }
        }

        
        
        public AxdExtType_ModifiedDateTime ModifiedDateTime
        {
            get
            {
                return this.modifiedDateTimeField;
            }
            set
            {
                this.modifiedDateTimeField = value;
            }
        }

        
        
        public string PaymMode
        {
            get
            {
                return this.paymModeField;
            }
            set
            {
                this.paymModeField = value;
            }
        }

        
        
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        
        
        public string PurchId
        {
            get
            {
                return this.purchIdField;
            }
            set
            {
                this.purchIdField = value;
            }
        }

        
        
        public string PurchOrderFormNum
        {
            get
            {
                return this.purchOrderFormNumField;
            }
            set
            {
                this.purchOrderFormNumField = value;
            }
        }

        
        public System.DateTime ReceiptDateRequested
        {
            get
            {
                return this.receiptDateRequestedField;
            }
            set
            {
                this.receiptDateRequestedField = value;
            }
        }

        
        
        public System.Nullable<long> RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

        
        
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<int> RecVersion
        {
            get
            {
                return this.recVersionField;
            }
            set
            {
                this.recVersionField = value;
            }
        }

        
        
        public bool RecVersionSpecified
        {
            get
            {
                return this.recVersionFieldSpecified;
            }
            set
            {
                this.recVersionFieldSpecified = value;
            }
        }

        
        
        public string SalesId
        {
            get
            {
                return this.salesIdField;
            }
            set
            {
                this.salesIdField = value;
            }
        }

        
        
        public string SalesName
        {
            get
            {
                return this.salesNameField;
            }
            set
            {
                this.salesNameField = value;
            }
        }

        
        
        public string SalesOriginId
        {
            get
            {
                return this.salesOriginIdField;
            }
            set
            {
                this.salesOriginIdField = value;
            }
        }

        
        
        public string SalesPoolId
        {
            get
            {
                return this.salesPoolIdField;
            }
            set
            {
                this.salesPoolIdField = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_SalesStatus> SalesStatus
        {
            get
            {
                return this.salesStatusField;
            }
            set
            {
                this.salesStatusField = value;
            }
        }

        
        
        public bool SalesStatusSpecified
        {
            get
            {
                return this.salesStatusFieldSpecified;
            }
            set
            {
                this.salesStatusFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_SalesType> SalesType
        {
            get
            {
                return this.salesTypeField;
            }
            set
            {
                this.salesTypeField = value;
            }
        }

        
        
        public bool SalesTypeSpecified
        {
            get
            {
                return this.salesTypeFieldSpecified;
            }
            set
            {
                this.salesTypeFieldSpecified = value;
            }
        }

        
        
        public string SalesUnitId
        {
            get
            {
                return this.salesUnitIdField;
            }
            set
            {
                this.salesUnitIdField = value;
            }
        }

        
        
        public string ShipCarrierAccount
        {
            get
            {
                return this.shipCarrierAccountField;
            }
            set
            {
                this.shipCarrierAccountField = value;
            }
        }

        
        
        public string ShipCarrierAccountCode
        {
            get
            {
                return this.shipCarrierAccountCodeField;
            }
            set
            {
                this.shipCarrierAccountCodeField = value;
            }
        }

        
        
        public System.Nullable<AxdExtType_ShipCarrierBlindShipment> ShipCarrierBlindShipment
        {
            get
            {
                return this.shipCarrierBlindShipmentField;
            }
            set
            {
                this.shipCarrierBlindShipmentField = value;
            }
        }

        
        
        public bool ShipCarrierBlindShipmentSpecified
        {
            get
            {
                return this.shipCarrierBlindShipmentFieldSpecified;
            }
            set
            {
                this.shipCarrierBlindShipmentFieldSpecified = value;
            }
        }

        
        
        public string ShipCarrierDeliveryContact
        {
            get
            {
                return this.shipCarrierDeliveryContactField;
            }
            set
            {
                this.shipCarrierDeliveryContactField = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_ShipCarrierDlvType> ShipCarrierDlvType
        {
            get
            {
                return this.shipCarrierDlvTypeField;
            }
            set
            {
                this.shipCarrierDlvTypeField = value;
            }
        }

        
        
        public bool ShipCarrierDlvTypeSpecified
        {
            get
            {
                return this.shipCarrierDlvTypeFieldSpecified;
            }
            set
            {
                this.shipCarrierDlvTypeFieldSpecified = value;
            }
        }

        
        
        public string ShipCarrierId
        {
            get
            {
                return this.shipCarrierIdField;
            }
            set
            {
                this.shipCarrierIdField = value;
            }
        }

        
        
        public string ShipCarrierName
        {
            get
            {
                return this.shipCarrierNameField;
            }
            set
            {
                this.shipCarrierNameField = value;
            }
        }

        
        
        public AxdEntityKey_LogisticsPostalAddress ShipCarrierPostalAddress
        {
            get
            {
                return this.shipCarrierPostalAddressField;
            }
            set
            {
                this.shipCarrierPostalAddressField = value;
            }
        }

        
        public System.Nullable<System.DateTime> ShippingDateConfirmed
        {
            get
            {
                return this.shippingDateConfirmedField;
            }
            set
            {
                this.shippingDateConfirmedField = value;
            }
        }

        
        
        public bool ShippingDateConfirmedSpecified
        {
            get
            {
                return this.shippingDateConfirmedFieldSpecified;
            }
            set
            {
                this.shippingDateConfirmedFieldSpecified = value;
            }
        }

        
        public System.Nullable<System.DateTime> ShippingDateRequested
        {
            get
            {
                return this.shippingDateRequestedField;
            }
            set
            {
                this.shippingDateRequestedField = value;
            }
        }

        
        
        public bool ShippingDateRequestedSpecified
        {
            get
            {
                return this.shippingDateRequestedFieldSpecified;
            }
            set
            {
                this.shippingDateRequestedFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<decimal> smmSalesAmountTotal
        {
            get
            {
                return this.smmSalesAmountTotalField;
            }
            set
            {
                this.smmSalesAmountTotalField = value;
            }
        }

        
        
        public bool smmSalesAmountTotalSpecified
        {
            get
            {
                return this.smmSalesAmountTotalFieldSpecified;
            }
            set
            {
                this.smmSalesAmountTotalFieldSpecified = value;
            }
        }

        
        
        public string WorkerSalesResponsible
        {
            get
            {
                return this.workerSalesResponsibleField;
            }
            set
            {
                this.workerSalesResponsibleField = value;
            }
        }

        
        
        public System.Nullable<AxdExtType_ZonBillCompleted> ZonBillCompleted
        {
            get
            {
                return this.zonBillCompletedField;
            }
            set
            {
                this.zonBillCompletedField = value;
            }
        }

        
        
        public bool ZonBillCompletedSpecified
        {
            get
            {
                return this.zonBillCompletedFieldSpecified;
            }
            set
            {
                this.zonBillCompletedFieldSpecified = value;
            }
        }

        
        
        public string ZonCompanyOnyxID
        {
            get
            {
                return this.zonCompanyOnyxIDField;
            }
            set
            {
                this.zonCompanyOnyxIDField = value;
            }
        }

        
        public System.Nullable<System.DateTime> ZonConfirmationDate
        {
            get
            {
                return this.zonConfirmationDateField;
            }
            set
            {
                this.zonConfirmationDateField = value;
            }
        }

        
        
        public bool ZonConfirmationDateSpecified
        {
            get
            {
                return this.zonConfirmationDateFieldSpecified;
            }
            set
            {
                this.zonConfirmationDateFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_NoYes> ZonConfirmationStatus
        {
            get
            {
                return this.zonConfirmationStatusField;
            }
            set
            {
                this.zonConfirmationStatusField = value;
            }
        }

        
        
        public bool ZonConfirmationStatusSpecified
        {
            get
            {
                return this.zonConfirmationStatusFieldSpecified;
            }
            set
            {
                this.zonConfirmationStatusFieldSpecified = value;
            }
        }

        
        
        public string ZonFreightReason
        {
            get
            {
                return this.zonFreightReasonField;
            }
            set
            {
                this.zonFreightReasonField = value;
            }
        }

        
        
        public System.Nullable<AxdExtType_ZonGiftReceipts> ZonGiftReceipt
        {
            get
            {
                return this.zonGiftReceiptField;
            }
            set
            {
                this.zonGiftReceiptField = value;
            }
        }

        
        
        public bool ZonGiftReceiptSpecified
        {
            get
            {
                return this.zonGiftReceiptFieldSpecified;
            }
            set
            {
                this.zonGiftReceiptFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_NoYes> ZonIsGAMOrder
        {
            get
            {
                return this.zonIsGAMOrderField;
            }
            set
            {
                this.zonIsGAMOrderField = value;
            }
        }

        
        
        public bool ZonIsGAMOrderSpecified
        {
            get
            {
                return this.zonIsGAMOrderFieldSpecified;
            }
            set
            {
                this.zonIsGAMOrderFieldSpecified = value;
            }
        }

        
        public System.Nullable<System.DateTime> ZonLastUpdate
        {
            get
            {
                return this.zonLastUpdateField;
            }
            set
            {
                this.zonLastUpdateField = value;
            }
        }

        
        
        public bool ZonLastUpdateSpecified
        {
            get
            {
                return this.zonLastUpdateFieldSpecified;
            }
            set
            {
                this.zonLastUpdateFieldSpecified = value;
            }
        }

        
        
        public string ZonOnyxID
        {
            get
            {
                return this.zonOnyxIDField;
            }
            set
            {
                this.zonOnyxIDField = value;
            }
        }

        
        public System.Nullable<System.DateTime> ZonOrderDate
        {
            get
            {
                return this.zonOrderDateField;
            }
            set
            {
                this.zonOrderDateField = value;
            }
        }

        
        
        public bool ZonOrderDateSpecified
        {
            get
            {
                return this.zonOrderDateFieldSpecified;
            }
            set
            {
                this.zonOrderDateFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_ZonOrderSource> ZonOrderSource
        {
            get
            {
                return this.zonOrderSourceField;
            }
            set
            {
                this.zonOrderSourceField = value;
            }
        }

        
        
        public bool ZonOrderSourceSpecified
        {
            get
            {
                return this.zonOrderSourceFieldSpecified;
            }
            set
            {
                this.zonOrderSourceFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_ZonOrderType> ZonOrderType
        {
            get
            {
                return this.zonOrderTypeField;
            }
            set
            {
                this.zonOrderTypeField = value;
            }
        }

        
        
        public bool ZonOrderTypeSpecified
        {
            get
            {
                return this.zonOrderTypeFieldSpecified;
            }
            set
            {
                this.zonOrderTypeFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_NoYes> ZonOverrideFinancialDimension
        {
            get
            {
                return this.zonOverrideFinancialDimensionField;
            }
            set
            {
                this.zonOverrideFinancialDimensionField = value;
            }
        }

        
        
        public bool ZonOverrideFinancialDimensionSpecified
        {
            get
            {
                return this.zonOverrideFinancialDimensionFieldSpecified;
            }
            set
            {
                this.zonOverrideFinancialDimensionFieldSpecified = value;
            }
        }

        
        
        public System.Nullable<AxdEnum_ZonQuoteStatus> ZonQuoteStatus
        {
            get
            {
                return this.zonQuoteStatusField;
            }
            set
            {
                this.zonQuoteStatusField = value;
            }
        }

        
        
        public bool ZonQuoteStatusSpecified
        {
            get
            {
                return this.zonQuoteStatusFieldSpecified;
            }
            set
            {
                this.zonQuoteStatusFieldSpecified = value;
            }
        }

        
        
        public string ZonSalesResponsible
        {
            get
            {
                return this.zonSalesResponsibleField;
            }
            set
            {
                this.zonSalesResponsibleField = value;
            }
        }

        
        
        public string ZonSOBuyer
        {
            get
            {
                return this.zonSOBuyerField;
            }
            set
            {
                this.zonSOBuyerField = value;
            }
        }

        
        
        public System.Nullable<AxdExtType_ZonSuppressInvoice> ZonSuppressInvoice
        {
            get
            {
                return this.zonSuppressInvoiceField;
            }
            set
            {
                this.zonSuppressInvoiceField = value;
            }
        }

        
        
        public bool ZonSuppressInvoiceSpecified
        {
            get
            {
                return this.zonSuppressInvoiceFieldSpecified;
            }
            set
            {
                this.zonSuppressInvoiceFieldSpecified = value;
            }
        }

        
        
        public string ZonTaxExemptionType
        {
            get
            {
                return this.zonTaxExemptionTypeField;
            }
            set
            {
                this.zonTaxExemptionTypeField = value;
            }
        }

        
        public System.Nullable<System.DateTime> ZonVertexOrigDlvDate
        {
            get
            {
                return this.zonVertexOrigDlvDateField;
            }
            set
            {
                this.zonVertexOrigDlvDateField = value;
            }
        }

        
        
        public bool ZonVertexOrigDlvDateSpecified
        {
            get
            {
                return this.zonVertexOrigDlvDateFieldSpecified;
            }
            set
            {
                this.zonVertexOrigDlvDateFieldSpecified = value;
            }
        }

        
        public AxdEntity_TableDlvAddr[] TableDlvAddr
        {
            get
            {
                return this.tableDlvAddrField;
            }
            set
            {
                this.tableDlvAddrField = value;
            }
        }

        
        public AxdEntity_SalesLine[] SalesLine
        {
            get
            {
                return this.salesLineField;
            }
            set
            {
                this.salesLineField = value;
            }
        }

        
        public AxdEntity_DocuRefHeader[] DocuRefHeader
        {
            get
            {
                return this.docuRefHeaderField;
            }
            set
            {
                this.docuRefHeaderField = value;
            }
        }

        
        public AxdEntity_MarkupTransHeader[] MarkupTransHeader
        {
            get
            {
                return this.markupTransHeaderField;
            }
            set
            {
                this.markupTransHeaderField = value;
            }
        }

        
        public AxdEntity_ZonCustAddlCreditCards[] ZonCustAddlCreditCards
        {
            get
            {
                return this.zonCustAddlCreditCardsField;
            }
            set
            {
                this.zonCustAddlCreditCardsField = value;
            }
        }

        
        public AxdEntity_ZonSalesTableExtension[] ZonSalesTableExtension
        {
            get
            {
                return this.zonSalesTableExtensionField;
            }
            set
            {
                this.zonSalesTableExtensionField = value;
            }
        }

        
        
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        
        
        public AxdEnum_AxdEntityAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        
        
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
    }

    
    
    public enum AxdEnum_DocumentStatus
    {

        
        None,

        
        Quotation,

        
        PurchaseOrder,

        
        Confirmation,

        
        PickingList,

        
        PackingSlip,

        
        ReceiptsList,

        
        Invoice,

        
        ApproveJournal,

        
        ProjectInvoice,

        
        ProjectPackingSlip,

        
        CRMQuotation,

        
        Lost,

        
        Cancelled,

        
        FreeTextInvoice,

        
        RFQ,

        
        RFQAccept,

        
        RFQReject,

        
        PurchReq,

        
        RFQReSend,
    }

    
     
    public enum AxdEnum_SalesStatus
    {

        
        None,

        
        Backorder,

        
        Delivered,

        
        Invoiced,

        
        Canceled,
    }

    
    
    public enum AxdExtType_ShipCarrierBlindShipment
    {

        
        No,

        
        Yes,
    }

    
   
    public enum AxdExtType_ZonBillCompleted
    {

        
        No,

        
        Yes,
    }

    
    
    public enum AxdExtType_ZonGiftReceipts
    {

        
        No,

        
        Yes,
    }

    
    
    public enum AxdEnum_ZonOrderSource
    {

        
        AX,

        
        CRM,

        
        Web,

        
        Subscription,

        
        PSA,

        
        GOL,

        
        ZEP,

        
        EDI,

        
        Cloud,

        
        API,

        
        Renewals,
    }

    
   
    public enum AxdEnum_ZonOrderType
    {

        
        Order,

        
        Quote,
    }

    
   
    public enum AxdEnum_ZonQuoteStatus
    {

        
        Blank,

        
        Draft,

        
        Submitted,

        
        Won,

        
        Lost,

        
        Expired,

        
        Canceled,
    }

    
    
    public enum AxdExtType_ZonSuppressInvoice
    {

        
        No,

        
        Yes,
    }

    
   
    public partial class AxdSalesOrder
    {

        private System.Nullable<AxdEnum_XMLDocPurpose> docPurposeField;

        private bool docPurposeFieldSpecified;

        private AxdEntity_SalesTable[] salesTableField;

        
        
        public System.Nullable<AxdEnum_XMLDocPurpose> DocPurpose
        {
            get
            {
                return this.docPurposeField;
            }
            set
            {
                this.docPurposeField = value;
            }
        }

        
        
        public bool DocPurposeSpecified
        {
            get
            {
                return this.docPurposeFieldSpecified;
            }
            set
            {
                this.docPurposeFieldSpecified = value;
            }
        }

        
        
        public AxdEntity_SalesTable[] SalesTable
        {
            get
            {
                return this.salesTableField;
            }
            set
            {
                this.salesTableField = value;
            }
        }
    }

    
   
    public enum AxdEnum_XMLDocPurpose
    {

        
        Original,

        
        Duplicate,

        
        Proforma,

        
        Replacement,
    }

    
    public delegate void deleteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    
    public delegate void createCompletedEventHandler(object sender, createCompletedEventArgs e);

    
    
    public partial class createCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal createCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        
        public EntityKey[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((EntityKey[])(this.results[0]));
            }
        }
    }

    
    public delegate void findCompletedEventHandler(object sender, findCompletedEventArgs e);

    
    public partial class findCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal findCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        
        public AxdSalesOrder Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((AxdSalesOrder)(this.results[0]));
            }
        }
    }

    
    public delegate void findKeysCompletedEventHandler(object sender, findKeysCompletedEventArgs e);

    
    public partial class findKeysCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal findKeysCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        
        public EntityKey[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((EntityKey[])(this.results[0]));
            }
        }
    }

    
    public delegate void getChangedKeysCompletedEventHandler(object sender, getChangedKeysCompletedEventArgs e);

    
    public partial class getChangedKeysCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getChangedKeysCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        
        public EntityKeyPage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((EntityKeyPage)(this.results[0]));
            }
        }
    }

    
    public delegate void getKeysCompletedEventHandler(object sender, getKeysCompletedEventArgs e);

    
    public partial class getKeysCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getKeysCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        
        public EntityKeyPage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((EntityKeyPage)(this.results[0]));
            }
        }
    }

    
    public delegate void readCompletedEventHandler(object sender, readCompletedEventArgs e);

    
    public partial class readCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal readCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        
        public AxdSalesOrder Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((AxdSalesOrder)(this.results[0]));
            }
        }
    }

    
    public delegate void updateCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}
