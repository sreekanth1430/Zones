using BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Command;
using BuildingBlock.Zones.Model.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Service
{
    public interface ICustomerService
    {
        Task<List<CreditData>> GetCustomerCreditData(List<CreditData> _CreditDataList, string CallContextCompaney);
        public string GetCreditDataInfo();


        /// <summary>
        /// Update Credit Limit
        /// </summary>
        /// <param name="updateCreditLimitCommand"></param>
        /// <returns></returns>
        Task<bool> UpdateCreidtLimit(UpdateCreditLimitCommand updateCreditLimitCommand);
    }
}
