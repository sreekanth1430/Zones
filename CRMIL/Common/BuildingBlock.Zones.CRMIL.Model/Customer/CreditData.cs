using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Customer
{
    public class CreditData
    {
        public string CustAccount { get; set; }
        public bool CreditLimitFlag { get; set; }
        public bool CreditStatusFlag { get; set; }
        public bool FirstDateFlag { get; set; }
        public bool LastDateFlag { get; set; }
        public bool TotalOrdersFlag { get; set; }
        public bool P3MthSalesFlag { get; set; }
        public bool P12MthSalesFlag { get; set; }
        public bool OpenQuotesFlag { get; set; }
        public bool TermDaysFlag { get; set; }
        public bool BillCompleteFlag { get; set; }
        public bool AvgPerOrderFlag { get; set; }
        public bool LifeTimeTotalFlag { get; set; }
        public bool TotalOpenFlag { get; set; }
        public bool PotentialARFlag { get; set; }
        public bool AvailableCreditFlag { get; set; }
        public decimal CreditLimit { get; set; }
        public int CreditStatus { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public decimal TotalOrders { get; set; }
        public decimal P3MthSales { get; set; }
        public decimal P12MthSales { get; set; }
        public decimal OpenQuotes { get; set; }
        public string TermDays { get; set; }
        public bool BillComplete { get; set; }
        public decimal TotalOpen { get; set; }
        public decimal PotentialAR { get; set; }
        public decimal AvailableCredit { get; set; }
        public decimal LargeOrderReviewAmount { get; set; }
        public string ArCollector { get; set; }
    }
}
