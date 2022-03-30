namespace BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel
{
    public class OrderSearchRequest
    {
        public string SalesID { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
        public string Margin { get; set; }
        public string ItemTotalPrice { get; set; }
        public string WareHouse { get; set; }
        public string PO { get; set; }
        public string ETS { get; set; }
        public string Status { get; set; }
        public string OSR { get; set; }
        public string HeaderMargin { get; set; }
        public string HeaderTax { get; set; }
        public string HeaderShipped { get; set; }
        public string HeaderTotalPrice { get; set; }
        public string TotalProduct { get; set; }
        public string Tax { get; set; }
        public string TaxEmpition { get; set; }
        public string Shipping { get; set; }
        public string OrderTotal { get; set; }
        public string TotalMargin { get; set; }
        public string ShippingMargin { get; set; }
        public string TotalOSR { get; set; }
        public string OrderFinalTotal { get; set; }
        public string CallContextCompany { get; set; }
    }       
}
