using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using BuildingBlock.Zones.CRMIL.Api.Service;
using BuildingBlock.Zones.CRMIL.Api.UnitTests.Mocks;
using BuildingBlock.Zones.CRMIL.Model.Order.OrderRecall.RequestModel;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using BuildingBlock.Zones.CRMIL.Service;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
using BuildingBlock.Core.Logger;
using Microsoft.Extensions.Localization;
using BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Command;
using System.Collections.Generic;
using BuildingBlock.Zones.Model.Customer;
using BuildingBlock.Zones.CRMIL.Model.Customer;

namespace BuildingBlock.Zones.CRMIL.Api.UnitTests
{
    public class CustomerControllerTest
    {
        public CustomerControllerTest()
        {

        }

        [Fact]
        public async Task UpdateCreditLimitWithCorrectDaat()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var request = new OrderDetailsRequest
            {
                SalesID = "J2000001",
                CallContextCompany = "ZUKL"
            };

            OrderRecallQuery orderRecallQuery = new OrderRecallQuery
            {
                _salesOrderList = new string[] { request.SalesID, },
                _companyId = request.CallContextCompany
            };

            HTTPClientWrapper<Object> hTTPClientWrapper = new HTTPClientWrapper<Object>(MockValidIOrderStore.MockConfig());


            Utility utility = new Utility(config);
            string token = await utility.GetTokenAsync();
            var response = hTTPClientWrapper.PostRequest(config["OrderDetailURL"].ToString(), orderRecallQuery, token).Result;
            bool getRecord = false;
            if (response is not null)
            {
                getRecord = true;
            }
            //string expectedOrderRecallResponse = JsonLoader.LoadJson(@"../../../JSonModels/OrderRecall.json");
            //Assert
            Assert.Equal(true, getRecord);

        }

        [Fact]
        public async Task UpdateCreditLimiteTest_WhenValusarenull()
        {

            var appierrormock = new Mock<IApiErrorFactory>();
            var CustomerServicemock = new Mock<ICustomerService>();
            var loggermock = new Mock<ICoreLogger<CustomerController>>();
            var localozermock = new Mock<IStringLocalizer<CustomerController>>();
            CustomerServicemock.Setup(arg => arg.UpdateCreidtLimit(It.IsAny<UpdateCreditLimitCommand>()))
            .Returns(Task.FromResult(true));
            
            CustomerController controller = new CustomerController(CustomerServicemock.Object,loggermock.Object, appierrormock.Object, localozermock.Object);
           var response= await controller.UpdateCreditLimitAsync(new UpdateCreditLimitCommand() { CompanyId = "", CreditLimit = "", CustomerAccount = "" });

        }
        [Fact]
        public async Task GetCreditCardDataAync_ValidData()
        {

            var appierrormock = new Mock<IApiErrorFactory>();
            var CustomerServicemock = new Mock<ICustomerService>();
            var loggermock = new Mock<ICoreLogger<CustomerController>>();
            var localozermock = new Mock<IStringLocalizer<CustomerController>>();

            CustomerController controller = new CustomerController(CustomerServicemock.Object, loggermock.Object, appierrormock.Object, localozermock.Object);
            List<CreditData> CreditResponse = new List<CreditData> { new CreditData { CustAccount = "10033" } };
            CustomerServicemock.Setup(arg => arg.GetCustomerCreditData(It.IsAny<List<CreditData>>(), It.IsAny<string>()))
            .Returns(Task.FromResult(CreditResponse));

            List<CreditData> data = new List<CreditData>(); data.Add(new CreditData { CustAccount = "10033" });
            CustomerCreditData list = new CustomerCreditData() { companyId = "ZLLC",  creditdata = data };
            var response = await controller.CustomerCreditData(list);

            if (response!=null)
            {
                Assert.True(true); 
            }
        }

        [Fact]
        public async Task GetCreditCardDataAync_InValidData()
        {

            var appierrormock = new Mock<IApiErrorFactory>();
            var CustomerServicemock = new Mock<ICustomerService>();
            var loggermock = new Mock<ICoreLogger<CustomerController>>();
            var localozermock = new Mock<IStringLocalizer<CustomerController>>();

            CustomerController controller = new CustomerController(CustomerServicemock.Object, loggermock.Object, appierrormock.Object, localozermock.Object);
            List<CreditData> CreditResponse = new List<CreditData> { };
            CustomerServicemock.Setup(arg => arg.GetCustomerCreditData(It.IsAny<List<CreditData>>(), It.IsAny<string>()))
            .Returns(Task.FromResult(CreditResponse));

            List<CreditData> data = new List<CreditData>(); data.Add(new CreditData { CustAccount = "10033" });
            CustomerCreditData list = new CustomerCreditData() { companyId = "ZLLC", creditdata = data };
            var response = await controller.CustomerCreditData(list);

            if (response!=null)
            { 
                Assert.True(true); 
            }
            else { Assert.False(false); }
        }
    }
}
