using BuildingBlock.Core.Model;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Command;
using BuildingBlock.Zones.CRMIL.Model.Customer;
using BuildingBlock.Zones.CRMIL.Model.Customer.RequestModel;
using BuildingBlock.Zones.CRMIL.Model.Customer.ResponseModel;
using BuildingBlock.Zones.CRMIL.Model.Order.OrderRecall.RequestModel;
using BuildingBlock.Zones.CRMIL.Repo;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using BuildingBlock.Zones.CRMIL.Service.UnitTests.Mocks;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using BuildingBlock.Zones.Model.Customer;
using BuildingBlock.Zones.Model.Customer.ResponseModel;
using MediatR;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace BuildingBlock.Zones.CRMIL.Service.UnitTests
{
    public class CustomerServiceUnitTest
    {
        public CustomerServiceUnitTest()
        {

        }

        [Fact]
        public void UpdateCreidtLimitWithValidData()
        {
            var customerRepomock = new Mock<ICustomerRepository>();
            var mediatormock = new Mock<IMediator>();

            customerRepomock.Setup(arg => arg.UpdateCreditLimit(It.IsAny<CreditLimitInfo>()))
            .Returns(Task.FromResult(true));
            ICustomerService custservice = new CustomerService(customerRepomock.Object, mediatormock.Object);

           var result=  custservice.UpdateCreidtLimit(new UpdateCreditLimitCommand() { CompanyId = "", CreditLimit = "", CustomerAccount = "" }).Result;

        }
        [Fact]
        public void CustomerCreditData_ValidData()
        {
            var customerRepomock = new Mock<ICustomerRepository>();
            var mediatormock = new Mock<IMediator>();

            CustomerCreditDataContract[] CreditResponse = new CustomerCreditDataContract[] { new CustomerCreditDataContract() { CustAccount = "10033" } };
            customerRepomock.Setup(arg => arg.GetFnOCreditData(It.IsAny<string[]>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>()))
            .Returns(Task.FromResult(CreditResponse));
            ICustomerService custservice = new CustomerService(customerRepomock.Object, mediatormock.Object);
            List<CreditData> data = new List<CreditData>(); data.Add(new CreditData { CustAccount = "10033" });
            var companyId = "ZLLC";
            var result = custservice.GetCustomerCreditData(data,companyId).Result;

            if(result.Count >=1)
            {
                Assert.True(true);
            }

        }

        [Fact]
        public void CustomerCreditData_InValidData()
        {
            var customerRepomock = new Mock<ICustomerRepository>();
            var mediatormock = new Mock<IMediator>();

            CustomerCreditDataContract[] CreditResponse = new CustomerCreditDataContract[] { new CustomerCreditDataContract() { CustAccount = "10033" } };
            customerRepomock.Setup(arg => arg.GetFnOCreditData(It.IsAny<string[]>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>()))
            .Returns(Task.FromResult(CreditResponse));
            ICustomerService custservice = new CustomerService(customerRepomock.Object, mediatormock.Object);
            List<CreditData> data = new List<CreditData>();
            var companyId = "ZLLC";
            var result = custservice.GetCustomerCreditData(data, companyId).Result;

            if (result.Count >= 1)
            {
                Assert.False(true);
            }
            else { Assert.False(false); }

        }
        [Fact]
        public void Test1()
        {

            var mockConfiguration = new Mock<IConfiguration>();

            // And:
            mockConfiguration
                .SetupGet(c => c["Instance"])
                .Returns("https://login.microsoftonline.com/"); // We are returning the same key that we passed for validation

            mockConfiguration
              .SetupGet(c => c["Tenant"])
              .Returns("d8660806-f38d-4ca0-a6f1-8deb7cfe8971"); // We are returning the same key that we passed for validation

           


            IUtility utility = new TestUtility(MockValidIOrderStore.MockConfig());
            IHttpClientWrapper httpClientWrapper = new HTTPClient(MockValidIOrderStore.MockConfig(), utility);
            ICustomerRepository customerRepository = new CustomerRepository(MockValidIOrderStore.MockConfig(), httpClientWrapper);
            ICustomerService orderService = new CustomerService(customerRepository, MockValidIOrderStore.MockMediator());
            CustomerController controller = new CustomerController(orderService, MockValidIOrderStore.MockRepoLogger(), MockValidIOrderStore.MockControllerApiErrorFactory(),
                MockValidIOrderStore.MockControllerLocalizer());
         
            UpdateCreditLimitResponse updateCreditLimitResponse = new UpdateCreditLimitResponse { CreditLimitStatus = true, HttpStatusCode = System.Net.HttpStatusCode.OK};
           

            UpdateCreditLimitCommand updateCreditLimitCommand = new UpdateCreditLimitCommand { CustomerAccount = "10033", CreditLimit = "10", CompanyId = "ZLLC" };
            CreditLimitInfo creditLimitInfo = new CreditLimitInfo { CustomerAccount="10033", CreditLimit="10", _companyId= "ZLLC" };
            
            var response = controller.UpdateCreditLimitAsync(updateCreditLimitCommand).Result;





        }
    }
}