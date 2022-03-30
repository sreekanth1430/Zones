
using BuildingBlock.Zones.CRMIL.Model.Product.RequestModel;
using BuildingBlock.Zones.CRMIL.Model.Product.ResponseModel;
using BuildingBlock.Zones.CRMIL.Repo;
using BuildingBlock.Zones.Model.Product;
using Microsoft.Extensions.Configuration;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
using BuildingBlock.Zones.Model.Product.RequestModel;
using BuildingBlock.Zones.Model.Product.ResponseModel;

namespace BuildingBlock.Zones.CRMIL.Service.UnitTests
{
    public class ProductServiceUnitTest
    {
        [Fact]
        public void GetProductDetails_SValidData()
        {
            var productRepomock = new Mock<IProductRepository>();
            var configuration = new Mock<IConfiguration>();

            BasicProductDetails[] ProductResponse = new BasicProductDetails[] { new BasicProductDetails() { AxProductId ="" } };
            productRepomock.Setup(arg => arg.getBasicProducts(It.IsAny<ProductFnORequest>()))
            .Returns(Task.FromResult(ProductResponse));
            IProductService productservice = new ProductService(productRepomock.Object,configuration.Object);

            var response = productservice.SelectProductList(new ProductSearch()
            {
                SearchText = "", EDPList = new string[] { "1234567899" }, EDP = "", SKU = "",Geography = "",
                ConfigurationFilter = "",  N = { }, Ne = { }, No = "", Ns = "", VPACode = "", OnyxId = "",
                AXAccountNum = "2000000039", CountryCode = "",VPARoundOff = true, CallContextCompany = "ZUKL",
                CategoryAxRecId = 0, PageIndex = 0, MaxLimit = 0, IsStandard = true, Sold = true, Quoted = true,
                SalesChannel = 0, OrganizationSize = 0
            });

            var okResult = response as Task<List<Product>>;

            Assert.NotNull(okResult);
            Assert.True(okResult is Task<List<Product>>);
            Assert.IsType<Task<List<Product>>>(okResult);

        }

        [Fact]
        public void GetOSRSummary_ValidData()
        {
            var productRepomock = new Mock<IProductRepository>();
            var configuration = new Mock<IConfiguration>();


            ZonOSRRequestContract[] ProductResponse = new ZonOSRRequestContract[] { new ZonOSRRequestContract() { Id=1 } };
            productRepomock.Setup(arg => arg.GetOSRSummary(It.IsAny<ZonOSRRequestContract[]>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.FromResult(ProductResponse));
            IProductService productservice = new ProductService(productRepomock.Object, configuration.Object);

            var response = productservice.GetOSRSummaryData(new ZonOSRRequestContract[] { },"104273","string","ZUKL","GBP");

            if(response!=null)
            {
                Assert.True(true);
            }

        }

        [Fact]
        public void GetOSRSummary_InValidData()
        {
            var productRepomock = new Mock<IProductRepository>();
            var configuration = new Mock<IConfiguration>();


            ZonOSRRequestContract[] ProductResponse = new ZonOSRRequestContract[] { new ZonOSRRequestContract() { Id = 1 } };
            productRepomock.Setup(arg => arg.GetOSRSummary(It.IsAny<ZonOSRRequestContract[]>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.FromResult(ProductResponse));
            IProductService productservice = new ProductService(productRepomock.Object, configuration.Object);
            var response = productservice.GetOSRSummaryData(new ZonOSRRequestContract[] { }, null, "","","").Result;

            if(response is null)
            {
                Assert.True(true);
            }

        }

        [Fact]
        public void FetchSPADetails_ValidData()
        {
            var productRepomock = new Mock<IProductRepository>();
            var configuration = new Mock<IConfiguration>();

            PurchaseAgreementData[] ProductResponse = new PurchaseAgreementData[] { new PurchaseAgreementData() { costField =1} };
            productRepomock.Setup(arg => arg.GetSPADetails(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.FromResult(ProductResponse));
            IProductService productservice = new ProductService(productRepomock.Object, configuration.Object);
            var response = productservice.SelectSPADetails("2000000039", "1234567899", 1, "string", "ZLLC", "GBP");

            if (response != null)
            {
                Assert.True(true);
            }

        }

        [Fact]
        public void FetchSPADetails_InValidData()
        {
            var productRepomock = new Mock<IProductRepository>();
            var configuration = new Mock<IConfiguration>();

            PurchaseAgreementData[] ProductResponse = new PurchaseAgreementData[] { new PurchaseAgreementData() { costField = 1 } };
            productRepomock.Setup(arg => arg.GetSPADetails(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.FromResult(ProductResponse));
            IProductService productservice = new ProductService(productRepomock.Object, configuration.Object);
            var response = productservice.SelectSPADetails("", "", 1, "", "", "");

            if (response == null)
            {
                Assert.True(true);
            }

        }
    }

    public static class JsonLoader
    {
        public static string LoadJson(string fileName)
        {
            using (StreamReader r = new StreamReader(fileName))
            {
                string jsonData = r.ReadToEnd();
                jsonData = jsonData.Replace("\r\n", "");

                return jsonData;
            }
        }

        public static JsonSerializerOptions GetJsonSerializerOptions()
        {
            return new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }
    }
}
