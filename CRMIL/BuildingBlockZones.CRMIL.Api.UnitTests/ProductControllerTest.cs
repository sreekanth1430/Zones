using Xunit;
using BuildingBlock.Zones.CRMIL.Api.UnitTests.Mocks;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using System;
using System.Text.Json;
using BuildingBlock.Zones.Model.Product;
using BuildingBlock.Zones.CRMIL.Model.Product.RequestModel;
using BuildingBlock.Zones.Model.Customer.Enum;
using BuildingBlock.Core.ErrorHandling;
using Moq;
using BuildingBlock.Zones.CRMIL.Service;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using BuildingBlock.Core.Logger;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using BuildingBlock.Zones.CRMIL.Model.Product.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BuildingBlock.Zones.Model.Product.RequestModel;
using BuildingBlock.Zones.Model.Product.ResponseModel;

namespace BuildingBlock.Zones.CRMIL.Api.UnitTests
{
    public class ProductControllerTest
    {
        [Fact]
        public async Task ProductDetailsAsyncl_ValaidData()
        {

            var appierrormock = new Mock<IApiErrorFactory>();
            var ProductServicemock = new Mock<IProductService>();
            var loggermock = new Mock<ICoreLogger<ProductController>>();
            var localozermock = new Mock<IStringLocalizer<ProductController>>();

            ProductController controller = new ProductController(ProductServicemock.Object, loggermock.Object, appierrormock.Object, localozermock.Object);
            List<Product> ProductResponse = new List<Product>() { new Product {  EDP = "2000000039"} };
            ProductServicemock.Setup(arg => arg.SelectProductList(It.IsAny<ProductSearch>()))
            .Returns(Task.FromResult(ProductResponse));
            var response = await controller.ProductDetails(new ProductSearch()
            {
                SearchText = "",
                EDPList = new string[] { "1234567899" },
                EDP = "",
                SKU = "",
                Geography = "",
                ConfigurationFilter = "",
                N = { },
                Ne = { },
                No = "",
                Ns = "",
                VPACode = "",
                OnyxId = "",
                AXAccountNum = "2000000039",
                CountryCode = "",
                VPARoundOff = true,
                CallContextCompany = "ZUKL",
                CategoryAxRecId = 0,
                PageIndex = 0,
                MaxLimit = 0,
                IsStandard = true,
                Sold = true,
                Quoted = true,
                SalesChannel = 0,
                OrganizationSize = 0
            });
            var okResult = response as OkObjectResult;

            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
        }

        [Fact]
        public async Task ProductDetailsAsyncl_InValaidData()
        {

            var appierrormock = new Mock<IApiErrorFactory>();
            var ProductServicemock = new Mock<IProductService>();
            var loggermock = new Mock<ICoreLogger<ProductController>>();
            var localozermock = new Mock<IStringLocalizer<ProductController>>();

            ProductController controller = new ProductController(ProductServicemock.Object, loggermock.Object, appierrormock.Object, localozermock.Object);
            List<Product> ProductResponse = new List<Product>() { };
            ProductServicemock.Setup(arg => arg.SelectProductList(It.IsAny<ProductSearch>()))
            .Returns(Task.FromResult(ProductResponse));
            var response = await controller.ProductDetails(new ProductSearch());
            var okResult = response as OkObjectResult;

            var badResult = response as BadRequestResult;
            Assert.Equal(StatusCodes.Status400BadRequest, badResult.StatusCode);

        }

        [Fact]
        public async Task GetOSRSummary_ValidData()
        {

            var appierrormock = new Mock<IApiErrorFactory>();
            var ProductServicemock = new Mock<IProductService>();
            var loggermock = new Mock<ICoreLogger<ProductController>>();
            var localozermock = new Mock<IStringLocalizer<ProductController>>();

            ProductController controller = new ProductController(ProductServicemock.Object, loggermock.Object, appierrormock.Object, localozermock.Object);
            ZonOSRRequestContract[] ProductResponse = new ZonOSRRequestContract[] { new ZonOSRRequestContract { Id =1 } };
            ProductServicemock.Setup(arg => arg.GetOSRSummaryData(It.IsAny<ZonOSRRequestContract[]>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.FromResult(ProductResponse));
            var response = await controller.GetOSRSummary(new OSRSummaryCall { CallContextCompany = "ZUKL", CurrencyCode = "GBP", Customeraccount = "104273", OSRDetails = new ZonOSRRequestContract[] { }, SalesId = "" });
            
            if(response!=null)
            {
                Assert.True(true);
            }
            else { Assert.False(true); }

        }

        [Fact]
        public void GetOSRSummary_InValaidData()
        {

            var appierrormock = new Mock<IApiErrorFactory>();
            var ProductServicemock = new Mock<IProductService>();
            var loggermock = new Mock<ICoreLogger<ProductController>>();
            var localozermock = new Mock<IStringLocalizer<ProductController>>();

            ProductController controller = new ProductController(ProductServicemock.Object, loggermock.Object, appierrormock.Object, localozermock.Object);
            ZonOSRRequestContract[] ProductResponse = new ZonOSRRequestContract[] {};
            ProductServicemock.Setup(arg => arg.GetOSRSummaryData(It.IsAny<ZonOSRRequestContract[]>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.FromResult(ProductResponse));
            var response = controller.GetOSRSummary(new OSRSummaryCall()).Result;
            
            var badResult = response as BadRequestResult;
            Assert.Equal(StatusCodes.Status400BadRequest, badResult.StatusCode);

        }
        [Fact]
        public async Task FetchSPA_ValaidData()
        {

            var appierrormock = new Mock<IApiErrorFactory>();
            var ProductServicemock = new Mock<IProductService>();
            var loggermock = new Mock<ICoreLogger<ProductController>>();
            var localozermock = new Mock<IStringLocalizer<ProductController>>();

            PurchaseAgreementData[] list = new PurchaseAgreementData[]{ new PurchaseAgreementData() {  vendorNameField = "" } };
            ProductController controller = new ProductController(ProductServicemock.Object, loggermock.Object, appierrormock.Object, localozermock.Object);
            ProductServicemock.Setup(arg => arg.SelectSPADetails(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.FromResult(list));

            var response = await controller.FetchSPA(new SPARequest { CustomerAccount = "2000000039", EDPNumber= "1234567899", ItemQuantity = 1, ShippingDate= "string", _companyId = "ZLLC", _currencyCode= "GBP" });
            
            
            if(response!=null)
            {
                Assert.True(true);
            }

        }
        [Fact]
        public async Task FetchSPA_InValaidData()
        {

            var appierrormock = new Mock<IApiErrorFactory>();
            var ProductServicemock = new Mock<IProductService>();
            var loggermock = new Mock<ICoreLogger<ProductController>>();
            var localozermock = new Mock<IStringLocalizer<ProductController>>();

            PurchaseAgreementData[] list = new PurchaseAgreementData[] { new PurchaseAgreementData() {} };
            ProductController controller = new ProductController(ProductServicemock.Object, loggermock.Object, appierrormock.Object, localozermock.Object);
            ProductServicemock.Setup(arg => arg.SelectSPADetails(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.FromResult(list));
            var response = await controller.FetchSPA(new SPARequest { CustomerAccount = "", EDPNumber = "1234567899" });

            var badResult = response as BadRequestResult;
            Assert.Equal(StatusCodes.Status400BadRequest, badResult.StatusCode);

        }

    }

}
