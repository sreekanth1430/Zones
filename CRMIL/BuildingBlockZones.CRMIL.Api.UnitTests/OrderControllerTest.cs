using AutoMapper;
using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Core.Logger;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using BuildingBlock.Zones.CRMIL.Api.Helper;
using BuildingBlock.Zones.CRMIL.Api.Service;
using BuildingBlock.Zones.CRMIL.Api.UnitTests.Mocks;
using BuildingBlock.Zones.CRMIL.Model.Order.OrderRecall.RequestModel;
using BuildingBlock.Zones.CRMIL.Repo;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace BuildingBlock.Zones.CRMIL.Api.UnitTests
{

    public class OrderControllerTest
    { 

        [Fact]
        public async Task PostOrderRecallProcessAsync()
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
            Assert.Equal(true, getRecord);

        }

        //[Fact]
        [Theory]
        [InlineData("J2000001", "ZUKL")]
        public async void ReadOrderValid(string salesId, string callContextId)
        {
            var _apiErrorFactory = new Mock<IApiErrorFactory>();
            var _orderRepository = new Mock<IOrderRepository>();
            var _orderService = new Mock<IOrderService>();
            var _coreLogger = new Mock<ICoreLogger<OrderController>>();
            var _localizer = new Mock<IStringLocalizer<OrderController>>();
            var _mapper = new Mock<IMapper>();
            var _configuration = new Mock<IConfiguration>();

            OrderController orderController = new OrderController(_orderService.Object, _coreLogger.Object, _apiErrorFactory.Object, _localizer.Object, _mapper.Object, _configuration.Object);
            List<OrderResponseData> orderResponseData = new List<OrderResponseData>();
            string expectedOrderRecallResponse = JsonHelper.LoadJson(@"../../../JSonModels/OrderRecall.json");

            orderResponseData = JsonConvert.DeserializeObject<List<OrderResponseData>>(expectedOrderRecallResponse);
            //Service layer mocking            
            _orderService.Setup(x => x.RecallOrderAsync(It.IsAny<OrderDetailsRequest>())).Returns(Task.FromResult(orderResponseData));

            var response = orderController.GetOrderDetailsAsync(new OrderDetailsRequest() { SalesID = salesId, CallContextCompany = callContextId }).Result;

            var okResult = response as OkObjectResult;

            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<OrderResponseData>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);


        }

        [Fact]
        public void ReadOrderInValid()
        {
            var _apiErrorFactory = new Mock<IApiErrorFactory>();
            var _orderRepository = new Mock<IOrderRepository>();
            var _orderService = new Mock<IOrderService>();
            var _coreLogger = new Mock<ICoreLogger<OrderController>>();
            var _localizer = new Mock<IStringLocalizer<OrderController>>();
            var _mapper = new Mock<IMapper>();
            var _configuration = new Mock<IConfiguration>();

            OrderController orderController = new OrderController(_orderService.Object, _coreLogger.Object, _apiErrorFactory.Object, _localizer.Object, _mapper.Object, _configuration.Object);
            List<OrderResponseData> orderResponseData = new List<OrderResponseData>();
            _orderService.Setup(arg => arg.RecallOrderAsync(It.IsAny<OrderDetailsRequest>()))
            .Returns(Task.FromResult(orderResponseData));
            var response = orderController.GetOrderDetailsAsync(new OrderDetailsRequest() { SalesID = "", CallContextCompany = "" }).Result;

            var badResult = response as Microsoft.AspNetCore.Mvc.BadRequestResult;

            Assert.Equal(StatusCodes.Status400BadRequest, badResult.StatusCode);
        }

    } 
}
