
using BuildingBlock.Zones.Model.Customer.ResponseModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BuildingBlock.Zones.Model.Customer.RequestModel;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using BuildingBlock.Zones.CRMIL.Model.Customer.RequestModel;
using BuildingBlock.Zones.CRMIL.Model.Customer.ResponseModel;

namespace BuildingBlock.Zones.CRMIL.Repo
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly IConfiguration _configuration;
        private readonly IHttpClientWrapper  _httpClientWrapper;
        public CustomerRepository(IConfiguration configuration, IHttpClientWrapper httpClientWrapper)
        {
            _configuration = configuration;
           _httpClientWrapper= httpClientWrapper;

        }
        public async Task<CustomerCreditDataContract[]> GetFnOCreditData(string[] _customerList, string CallContextCompaney,bool _creditLimit, bool _creditStatus, bool _firstDate, bool _lastDate, bool _orderCount, bool _p3MthSales, bool _p12MthSales, bool _openQuotes, bool _paymTermDays, bool _billComplete, bool _totalOpen, bool _potentialAR, bool _creditAvailable)
        {
            List<CustomerAccount> Accountlist = new List<CustomerAccount> {  new CustomerAccount() };
            Accountlist[0].CustAccount = _customerList[0];
            Accountlist[0].companyId = CallContextCompaney;
            CustomerCreditDataRequestContract request = new CustomerCreditDataRequestContract { 
                _customerList = Accountlist,
                _creditStatus = _creditStatus,
                _firstDate = _firstDate,
                _lastDate = _lastDate,
                _orderCount = _orderCount,
                _creditLimit = _creditLimit,
                _p3MthSales = _p3MthSales,
                _p12MthSales = _p12MthSales,
                _openQuotes = _openQuotes,
                _paymTermDays = _paymTermDays,
                _billComplete = _billComplete,
                _totalOpen = _totalOpen,
                _potentialAR = _potentialAR,
                _creditAvailable = _creditAvailable };


            CustomerCreditDataContract Response = new();
            HTTPClientWrapper<CustomerCreditDataContract[]> hTTPClientWrapper = new HTTPClientWrapper<CustomerCreditDataContract[]>(_configuration);

            var response = await hTTPClientWrapper.PostRequest(_configuration.GetSection("FnoGetCustomerCreditDataURL").Value, request);

            return response;
        }

        public async Task<bool> UpdateCreditLimit(CreditLimitInfo creditLimitInfo)
        {
            
            UpdateCreditLimitResponse updateCreditLimitResponse = new UpdateCreditLimitResponse();
           
            HTTPClientWrapper<UpdateCreditLimitResponse> hTTPClientWrapper = new HTTPClientWrapper<UpdateCreditLimitResponse>(_configuration);
            //var response = await _httpClientWrapper.PostOperation("https://globalqa5f038c3f8f0ebe24aos.cloudax.dynamics.com/api/services/ZonCustomerCustomServiceGroup/ZonCustomerCustomService/updateCustomerCreditLimit", (object)creditLimitInfo);
            var response = await hTTPClientWrapper.PostRequestOperation( Convert.ToString(_configuration["UpdateCreditLimitURL"]), creditLimitInfo);
            return (bool)response;
        }

    }
}
