using BuildingBlock.Zones.CRMIL.Repo.Helper;
using BuildingBlock.Zones.CRMIL.Repo.UnitTests.Constants;
using Microsoft.Extensions.Configuration;
using Moq;
using Xunit;

namespace BuildingBlock.Zones.CRMIL.Repo.UnitTests
{
    public class CustomerServiceUnitTest
    {

        [Fact]
        public void UpdateCreidtLimitWithValidData()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var httpclientmock = new Mock<IHttpClientWrapper>();
            CustomerRepository customerRepository = new CustomerRepository(config, httpclientmock.Object);
            var result=customerRepository.UpdateCreditLimit(new Model.Customer.RequestModel.CreditLimitInfo() { CreditLimit="10", CustomerAccount="10033" , _companyId="ZLLC" }).Result;

          

        }

        [Fact]
        public void GetCreditData_ValidData()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var httpclientmock = new Mock<IHttpClientWrapper>();
            CustomerRepository customerRepository = new CustomerRepository(config, httpclientmock.Object);
            
            var result = customerRepository.GetFnOCreditData(new string[]{ "104273" },"ZLLC",true,true,true,true, true, true, true, true, true, true, true, true,true).Result;

            if(result!=null)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void GetCreditData_InValidData()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var httpclientmock = new Mock<IHttpClientWrapper>();
            CustomerRepository customerRepository = new CustomerRepository(config, httpclientmock.Object);
            var result = customerRepository.GetFnOCreditData(new string[] { "" }, "", true, true, true, true, true, true, true, true, true, true, true, true, true).Result;

            if (result[0].Message == "'' is not a valid company.")
            {
                Assert.True(true);
            }
        }
    }
}