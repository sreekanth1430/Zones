using BuildingBlock.Zones.CRMIL.Model.Customer.RequestModel;
using BuildingBlock.Zones.Model.Customer.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Repo
{
    public interface ICustomerRepository
    {
         Task<CustomerCreditDataContract[]> GetFnOCreditData(string[] customerId, string CallContextCompaney, bool CreditLimit, bool CreditStatus, bool FirstDate,
                                                            bool LastDate, bool TotalOrders, bool P3MthSales,
                                                            bool P12MthSales, bool OpenQuotes, bool TermDays,
                                                            bool BillComplete, bool TotalOpen, bool PotentialAR,
                                                            bool AvailableCredit    );

        public Task<bool> UpdateCreditLimit(CreditLimitInfo creditLimitInfo);
    }
}
