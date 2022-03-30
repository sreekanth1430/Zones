using BuildingBlock.Zones.CRMIL.Model.Order.OrderRecall.RequestModel;
using BuildingBlock.Zones.CRMIL.Repo;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json;
using BuildingBlock.Zones.CRMIL.Api.UnitTests;
using BuildingBlock.Zones.CRMIL.Api.Service;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using BuildingBlock.Core.Logger;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using BuildingBlock.Zones.CRMIL.Api.Helper;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BuildingBlock.Zones.CRMIL.Service.UnitTests
{
    public class OrderServiceUnitTest
    {
        [Fact]
        public void ReadOrderWithValidData()
        {
            var iwebHost = new Mock<IWebHostEnvironment>();
            var orderRepomock = new Mock<IOrderRepository>();
            var mediatormock = new Mock<IMediator>();
            var coreLogger = new Mock<ICoreLogger<OrderService>>();
            var configuration = new Mock<IConfiguration>();

            List<OrderResponseData> orderResponseData = new List<OrderResponseData>();
            string expectedOrderRecallResponse = JsonHelper.LoadJson(@"../../../JSonModels/OrderRecall.json");

            orderResponseData = JsonConvert.DeserializeObject<List<OrderResponseData>>(expectedOrderRecallResponse);
            //Service layer mocking            
            orderRepomock.Setup(x => x.GetOrderRecall(It.IsAny<OrderRecallQuery>())).Returns(Task.FromResult(orderResponseData));
            IOrderService orderService = new OrderService(iwebHost.Object,orderRepomock.Object,coreLogger.Object, mediatormock.Object,configuration.Object);

            var result = orderService.RecallOrderAsync(new OrderDetailsRequest() { SalesID = "J2000001", CallContextCompany = "ZUKL" }).Result;

            Assert.IsType<List<OrderResponseData>>(result);
            Assert.NotNull(orderResponseData);
            Assert.True(result?.Count > 0);

        }


        [Fact]
        public void ReadOrderWithInValidData()
        {
            var iwebHost = new Mock<IWebHostEnvironment>();
            var orderRepomock = new Mock<IOrderRepository>();
            var mediatormock = new Mock<IMediator>();
            var coreLogger = new Mock<ICoreLogger<OrderService>>();
            var configuration = new Mock<IConfiguration>();

            List<OrderResponseData> orderResponseData = new List<OrderResponseData>();
            string expectedOrderRecallResponse = JsonHelper.LoadJson(@"../../../JSonModels/OrderRecall.json");

            orderRepomock.Setup(x => x.GetOrderRecall(It.IsAny<OrderRecallQuery>())).Returns(Task.FromResult(orderResponseData));
            //Service layer mocking
            IOrderService orderService = new OrderService(iwebHost.Object,orderRepomock.Object, coreLogger.Object, mediatormock.Object, configuration.Object);

            var result = orderService.RecallOrderAsync(new OrderDetailsRequest() { SalesID = "", CallContextCompany = "" }).Result;

            Assert.True(result?.Count <= 0);
            Assert.IsType<List<OrderResponseData>>(result);
            Assert.NotNull(orderResponseData);

        }
    }
}
