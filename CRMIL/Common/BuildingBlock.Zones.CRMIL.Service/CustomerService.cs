using BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Command;
using BuildingBlock.Zones.CRMIL.Model.Customer.ResponseModel;
using BuildingBlock.Zones.CRMIL.Repo;
using BuildingBlock.Zones.Model.Customer;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using BuildingBlock.Zones.CRMIL.Model.Customer.RequestModel;

namespace BuildingBlock.Zones.CRMIL.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _CustomerRepository;
        private readonly IMediator _mediator;
        public CustomerService(ICustomerRepository CustomerRepository , IMediator mediator)
        {
            _CustomerRepository = CustomerRepository;
            _mediator = mediator;
        }

        public string GetCreditDataInfo()
        {
            ActiveCreditCardInfo s = new ActiveCreditCardInfo();
            s.creditCardNumberField = "null";
            var strin = JsonConvert.SerializeObject(s);
            return strin;
        }

        public async Task<List<CreditData>> GetCustomerCreditData(List<CreditData> _CreditDataList, string _CallContextCompaney)
        {
            if(_CreditDataList.Any())
            {
                
            //if (_CreditDataList != null && _CreditDataList.Count > 0)
            //{
                int count = 0;
                string[] arrCustAccount = new string[_CreditDataList.Count];

                foreach (var creditData in _CreditDataList)
                {  
                    arrCustAccount[count] = creditData.CustAccount;
                    count++;
                }

                var resultList = await _CustomerRepository.GetFnOCreditData(arrCustAccount, _CallContextCompaney,
                                                                _CreditDataList[0].CreditLimitFlag, _CreditDataList[0].CreditStatusFlag,
                                                                _CreditDataList[0].FirstDateFlag, _CreditDataList[0].LastDateFlag,
                                                                _CreditDataList[0].TotalOrdersFlag, _CreditDataList[0].P3MthSalesFlag,
                                                                _CreditDataList[0].P12MthSalesFlag, _CreditDataList[0].OpenQuotesFlag,
                                                                _CreditDataList[0].TermDaysFlag, _CreditDataList[0].BillCompleteFlag,
                                                                _CreditDataList[0].TotalOpenFlag, _CreditDataList[0].PotentialARFlag,
                                                                _CreditDataList[0].AvailableCreditFlag);
                
                foreach (var creditData in _CreditDataList)
                {
                    var result = resultList.Where(a => a.CustAccount == creditData.CustAccount).SingleOrDefault();
                    creditData.BillComplete = Convert.ToBoolean((int)result.BillComplete);
                    creditData.AvailableCredit = result.AvailableCredit;
                    creditData.CreditLimit = result.CreditLimit;
                    creditData.CreditStatus = (int)result.CreditStatus;
                    creditData.FirstDate = result.Firstdate;
                    creditData.LastDate = result.LastDate;
                    creditData.OpenQuotes = result.OpenQuotes;
                    creditData.TotalOrders = result.TotalOrders;
                    creditData.P12MthSales = result.P12MthSales;
                    creditData.P3MthSales = result.P3MthSales;
                    creditData.TermDays = result.TermDays;
                    creditData.PotentialAR = result.PotentialAR;
                    creditData.TotalOpen = result.TotalOpen;
                    creditData.LargeOrderReviewAmount = result.LargeOrderReviewAmount;
                    creditData.ArCollector = result.ARCollector;
                }
            }
            return _CreditDataList;
            
        }

        async Task<bool> ICustomerService.UpdateCreidtLimit(UpdateCreditLimitCommand updateCreditLimitCommand)
        {
            CreditLimitInfo creditLimitInfo = new CreditLimitInfo { CustomerAccount = updateCreditLimitCommand.CustomerAccount, CreditLimit = updateCreditLimitCommand.CreditLimit, _companyId = updateCreditLimitCommand.CompanyId };
            var response= await _CustomerRepository.UpdateCreditLimit(creditLimitInfo);
            return response;

        }

    }
}
