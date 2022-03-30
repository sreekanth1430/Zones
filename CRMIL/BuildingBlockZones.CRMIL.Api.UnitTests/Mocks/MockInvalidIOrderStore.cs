using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Core.Logger;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using BuildingBlock.Zones.CRMIL.Api.Service;
using Microsoft.Extensions.Localization;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Api.UnitTests.Mocks
{
    public class MockInvalidIOrderStore
    {
        public static BuildingBlock.Zones.CRMIL.Repo.IOrderRepository MockIOrderStoreInValid()
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
        public static Task<BuildingBlock.Zones.Model.CRMIL.Order> AddInvalidOrder()
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

        public static Task<BuildingBlock.Zones.Model.CRMIL.Order> DeleteInvalidOrder()
        {
            BuildingBlock.Zones.Model.CRMIL.Order addResponse = new BuildingBlock.Zones.Model.CRMIL.Order
            {

            };
            return Task.FromResult(addResponse);
        }

        public static Task<BuildingBlock.Zones.Model.CRMIL.Order> UpdateInvalidOrder()
        {
            BuildingBlock.Zones.Model.CRMIL.Order updateResponse = new BuildingBlock.Zones.Model.CRMIL.Order
            {

            };
            return Task.FromResult(updateResponse);
        }

        public static Task<List<BuildingBlock.Zones.Model.CRMIL.Order>> UpdateAllInvalidOrder()
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
        public static IStringLocalizer<OrderController> MockControllerLocalizer()
        {
            var mock = new Mock<IStringLocalizer<OrderController>>();
            return mock.Object;
        }
    }
}
