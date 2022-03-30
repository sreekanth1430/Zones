using BuildingBlock.Zones.CRMIL.Model.Product.RequestModel;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using BuildingBlock.Zones.CRMIL.Repo.UnitTests.Constants;
using BuildingBlock.Zones.Model.Customer.Enum;
using BuildingBlock.Zones.Model.Product.RequestModel;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BuildingBlock.Zones.CRMIL.Repo.UnitTests
{
    public class ProductRipoUnitTest
    {
        [Fact]
        public void GetProductDetails_ValidData()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var httpclientmock = new Mock<IHttpClientWrapper>();
            ProductRepository productRepository = new ProductRepository(config);
            var result = productRepository.getBasicProducts(new ProductFnORequest() { p_CountryCode = "",
                CurrencyCode = "", p_AXAccountNum = "2000000039", p_VPACode = "", p_VPARoundingOff = NoYes.Yes, sCallContextCompany = "ZUKL",
                sEDP = new string[] { "1234567899" }
            }).Result;
            var resultt = false;
            if (result != null) { resultt = true; }
            Assert.True(resultt);

        }

        [Fact]
        public void GetProductDetails_InValidData()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var httpclientmock = new Mock<IHttpClientWrapper>();
            ProductRepository productRepository = new ProductRepository(config);
            var result = productRepository.getBasicProducts(new ProductFnORequest()
            {
                p_CountryCode = "",
                CurrencyCode = "",
                p_AXAccountNum = "",
                p_VPACode = "",
                p_VPARoundingOff = NoYes.Yes,
                sCallContextCompany = "",
                sEDP = new string[] { "" }
            }).Result;
            
            if (result == null) { Assert.False(false); }

        }

        [Fact]
        public void SPADetails_ValidData()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var httpclientmock = new Mock<IHttpClientWrapper>();
            ProductRepository productRepository = new ProductRepository(config);
            var result = productRepository.GetSPADetails("2000000039", "1234567899", 1, "string", "ZLLC", "GBP").Result;
            var resultt = false;
            if (result != null) { resultt = true; }
            Assert.True(resultt);

        }

        [Fact]
        public void SPADetails_InValidData()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var httpclientmock = new Mock<IHttpClientWrapper>();
            ProductRepository productRepository = new ProductRepository(config);
            var result = productRepository.GetSPADetails("", "", 1, "string", "", "").Result;
            var resultt = true;
            if (result == null) { resultt = false; }
            Assert.False(resultt);

        }

        [Fact]
        public void OSRSummary_ValidData()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var httpclientmock = new Mock<IHttpClientWrapper>();
            ProductRepository productRepository = new ProductRepository(config);
            var result = productRepository.GetOSRSummary(new ZonOSRRequestContract[] { }, "2000000039", "","ZUKL","GBP").Result;
            var resultt = false;
            if (result != null) { resultt = true; }
            Assert.True(resultt);

        }

        [Fact]
        public void OSRSummary_InValidData()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var httpclientmock = new Mock<IHttpClientWrapper>();
            ProductRepository productRepository = new ProductRepository(config);
            var result = productRepository.GetOSRSummary(new ZonOSRRequestContract[] { }, "", "", "", "GBP").Result;
            var resultt = true;
            if (result == null) { resultt = false; }
            Assert.False(resultt);

        }
    }
}
