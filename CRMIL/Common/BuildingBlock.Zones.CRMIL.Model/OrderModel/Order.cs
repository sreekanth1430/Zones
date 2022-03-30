using BuildingBlock.Zones.CRMIL.Model.Order;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using CRMIL.DA.Interfaces.AX.SalesOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxdEntity_SalesLine = CRMIL.DA.Interfaces.AX.SalesOrder.AxdEntity_SalesLine;

namespace BuildingBlock.Zones.Model.OrderModel
{
    public partial class Order
    {
        public Order()
        {
            lstCNotes = new List<LineCustomizationNote>();
        }

        public Order(AxdEntity_SalesTable[] p_oSalesTable)
        {
            lstCNotes = new List<LineCustomizationNote>();
            AXSalesTable = p_oSalesTable;
        }

        public AxdEntity_SalesTable[] AXSalesTable { get; set; }
        public string SalesID { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string DeliveryName { get; set; }
        public SalesLineLevelSplit[] OrderRecallLevels { get; set; }
        public AxdSalesOrder OrderRecallHeader { get; set; }
        public bool SupressInvoice { get; set; }
        public string TaxExemptionText { get; set; }
        public string DeleteLevel { get; set; }
        public string HoldLevel { get; set; }
        public string HoldLevelType { get; set; }
        public string DeleteLine { get; set; }
        public OrderBlockLine ToggleLine { get; set; }
        public AxdEntity_SalesLine SubstituteLine { get; set; }
        public OrderComment[] OrderComment { get; set; }
        public OrderFreightAnalysis[] OrderFreightAnalysiss { get; set; }
        public OrderItem[] OrderItems { get; set; }
        public string AccountName { get; set; }
        public decimal Tax { get; set; }
        public decimal ShippingTotal { get; set; }
        public string POAttachmentFlag { get; set; }
        public string[] POFileName { get; set; }
        public string[] POFolderName { get; set; }
        public string CreatedBy { get; set; }
        public string HasOtherAttachmentFlag { get; set; }
        public string[] OtherFileName { get; set; }
        public LineCustomizationNote[] LineCustomizationNoteInput { get; set; }
        public bool IsZonGiftReceipt { get; set; }
        public InventDim[] InventDim { get; set; }
        public string DepartmentCode { get; set; }
        public string BusinessUnit { get; set; }
        public string CostCenter { get; set; }
        public SendQuote SendQuote { get; set; }
        public string CustomerReference { get; set; }
        public string OrderPlacedDate_BD { get; set; }
        public string ConfirmationFlag_BD { get; set; }
        public string AXOrderType_BD { get; set; }
        public string OrderType_BD { get; set; }
        public string CRMStatus_BD { get; set; }
        public string OverallApprovalStatus_BD { get; set; }
        public string CallContextCompany { get; set; }
        public bool ExistsInAx { get; set; }
        public bool IsModifiable { get; set; }
        public bool AllLinesInvoiced { get; set; }
        public Guid CrmRecordId { get; set; }
        public OrderDocument[] OrderDocument { get; set; }
        public int AdditionalDocumentsCount { get; set; }

        private List<LineCustomizationNote> lstCNotes = null;

        public void AddLineCustomizationNote(LineCustomizationNote p_Object)
        {
            lstCNotes.Add(p_Object);
        }

        public LineCustomizationNote[] LineCustomizationNote
        {
            get
            {
                return lstCNotes.ToArray();
            }
        }

        public decimal TaxAmount { get; set; }
    }
}
