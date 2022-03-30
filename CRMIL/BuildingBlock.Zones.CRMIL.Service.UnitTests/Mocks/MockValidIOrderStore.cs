using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Core.Logger;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using BuildingBlock.Zones.CRMIL.Repo;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Service.UnitTests.Mocks
{
    public class MockValidIOrderStore
    {

        public static BuildingBlock.Zones.CRMIL.Repo.ICustomerRepository MockIOrderStoreValid()
        {
            var mock = new Mock<BuildingBlock.Zones.CRMIL.Repo.ICustomerRepository>();
            return mock.Object;
        }
        public static ICustomerRepository MockRepo() 
        {
            var mock = new Mock<ICustomerRepository>();
            return mock.Object;
        }

        public static IApiErrorFactory MockControllerApiErrorFactory()
        {
            var mock = new Mock<IApiErrorFactory>();
            mock.Setup(x => x.AddErrorDetail(It.IsAny<ApiErrorDetail>()));
            return mock.Object;
        }

        public static ICoreLogger<CustomerController> MockRepoLogger()
        {
            var mock = new Mock<ICoreLogger<CustomerController>>();
            return mock.Object;
        }
        public static IMediator MockMediator()
        {
            var mock = new Mock<IMediator>();
            return mock.Object;
        }

        public static IConfiguration MockConfig()
        {
            var mock = new Mock<IConfiguration>();
            return mock.Object;
        }

        public static IHttpClientWrapper MockHttpClient()
        {
            var mock = new Mock<IHttpClientWrapper>();
            return mock.Object;
        }


        public static IStringLocalizer<CustomerController> MockControllerLocalizer()
        {
            var mock = new Mock<IStringLocalizer<CustomerController>>();
            return mock.Object;
        }
    }
}
