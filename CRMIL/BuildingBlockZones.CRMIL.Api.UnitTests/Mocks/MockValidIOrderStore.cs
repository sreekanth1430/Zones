using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Core.Logger;
using BuildingBlock.Zones.CRMIL.Api.Service;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using Microsoft.Extensions.Localization;
using Moq;
using System.Threading.Tasks;
using System.Collections.Generic;
using MediatR;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using BuildingBlock.Zones.CRMIL.Repo;
using Microsoft.AspNetCore.Hosting;

namespace BuildingBlock.Zones.CRMIL.Api.UnitTests.Mocks
{
    public class MockValidIOrderStore
    {

        public static BuildingBlock.Zones.CRMIL.Repo.IOrderRepository MockIOrderStoreValid()
        {
            var mock = new Mock<BuildingBlock.Zones.CRMIL.Repo.IOrderRepository>();
            return mock.Object;
        }
        public static IApiErrorFactory MockControllerApiErrorFactory()
        {
            var mock = new Mock<IApiErrorFactory>();
            mock.Setup(x => x.AddErrorDetail(It.IsAny<ApiErrorDetail>()));
            return mock.Object;
        }
        public static Task<BuildingBlock.Zones.Model.CRMIL.Order> SingleAsync()
        {
            BuildingBlock.Zones.Model.CRMIL.Order addResponse = new BuildingBlock.Zones.Model.CRMIL.Order
            {

            };
            return Task.FromResult(addResponse);
        }
        public static Task<BuildingBlock.Zones.Model.CRMIL.Order> AddOrder()
        {
            BuildingBlock.Zones.Model.CRMIL.Order addResponse = new BuildingBlock.Zones.Model.CRMIL.Order
            {

            };
            return Task.FromResult(addResponse);
        }

        public static Task<IEnumerable<BuildingBlock.Zones.Model.CRMIL.Order>> AllAsync()
        {
            IEnumerable<BuildingBlock.Zones.Model.CRMIL.Order> getResponse = new List<BuildingBlock.Zones.Model.CRMIL.Order>
            {

            };
            return Task.FromResult(getResponse);
        }

        public static Task<BuildingBlock.Zones.Model.CRMIL.Order> DeleteOrder()
        {
            BuildingBlock.Zones.Model.CRMIL.Order addResponse = new BuildingBlock.Zones.Model.CRMIL.Order
            {

            };
            return Task.FromResult(addResponse);
        }

        public static Task<BuildingBlock.Zones.Model.CRMIL.Order> UpdateOrder()
        {
            BuildingBlock.Zones.Model.CRMIL.Order updateResponse = new BuildingBlock.Zones.Model.CRMIL.Order
            {

            };
            return Task.FromResult(updateResponse);
        }

        public static Task<List<BuildingBlock.Zones.Model.CRMIL.Order>> UpdateAllOrder()
        {
            List<BuildingBlock.Zones.Model.CRMIL.Order> updateResponse = new List<BuildingBlock.Zones.Model.CRMIL.Order>
            {

            };

            return Task.FromResult(updateResponse);
        }
        
        public static ICoreLogger<OrderController> MockControllerLogger()
        {
            var mock = new Mock<ICoreLogger<OrderController>>();
            mock.Setup(x => x.Information(It.IsAny<LogData>()));
            mock.Setup(x => x.Warning(It.IsAny<LogData>()));
            mock.Setup(x => x.Error(It.IsAny<LogData>()));
            return mock.Object;
        }

      

        public static ICoreLogger<OrderService> MockServiceLogger()
        {
            var mock = new Mock<ICoreLogger<OrderService>>();
            mock.Setup(x => x.Information(It.IsAny<LogData>()));
            mock.Setup(x => x.Warning(It.IsAny<LogData>()));
            mock.Setup(x => x.Error(It.IsAny<LogData>()));
            return mock.Object;
        }

        public static IMediator MockMediator()
        {
            var mock = new Mock<IMediator>();    
            return mock.Object;
        }
        public static IMapper MockMapper()
        {
            var mock = new Mock<IMapper>();
            return mock.Object;
        }
        public static IConfiguration MockConfig() 
        {
            var mock = new Mock<IConfiguration>();
            return mock.Object;
        }

        public static IOrderService MockControllerApiOrderService()
        {
            var mock = new Mock<IOrderService>();
            return mock.Object;
        }

        public static IConfigurationSection MockConfigSection() 
        {
            var mock = new Mock<IConfigurationSection>(); 
            return mock.Object;
        }
        public static IWebHostEnvironment MockWebHostEnv()
        {
            var mock = new Mock<IWebHostEnvironment>();
            return mock.Object;
        }
        public static IOrderRepository MockRepo()
        {
            var mock = new Mock<IOrderRepository>();
            return mock.Object;
        }
        public static ICoreLogger<OrderRepository> MockRepoLogger() 
        {
            var mock = new Mock<ICoreLogger<OrderRepository>>();
            return mock.Object;
        }

        public static IStringLocalizer<OrderController> MockControllerLocalizer()
        {
            var mock = new Mock<IStringLocalizer<OrderController>>();
            return mock.Object;
        }
    }
}
