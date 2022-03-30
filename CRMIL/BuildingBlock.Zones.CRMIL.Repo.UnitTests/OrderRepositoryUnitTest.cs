using BuildingBlock.Zones.CRMIL.Repo.Helper;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace BuildingBlock.Zones.CRMIL.Repo.UnitTests
{
    public class OrderRepositoryUnitTest
    {
        [Fact]
        public void ReadOrderWithValidData()
        {            

            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build(); 
             
            var httpclientmock = new Mock<IHttpClientWrapper>();
            OrderRepository orderRepository = new OrderRepository(config);
            OrderRecallQuery orderRecallQuery = new OrderRecallQuery
            {
                _salesOrderList = new string[] { "J2000001", },
                _companyId = "ZUKL"
            };

            var result = orderRepository.GetOrderRecall(orderRecallQuery).Result;
            bool repoStatus = (result is not null ? true : false);
                       
            Assert.Equal("true",repoStatus.ToString().ToLower());
        }

        [Fact]
        public void ReadOrderWithNullData()
        {

            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build(); 
            var httpclientmock = new Mock<IHttpClientWrapper>();
            OrderRepository orderRepository = new OrderRepository(config);
            OrderRecallQuery orderRecallQuery = new OrderRecallQuery
            {
                _salesOrderList = new string[] { "", },
                _companyId = ""
            };

            var result = orderRepository.GetOrderRecall(orderRecallQuery).Result;
             
            bool repoStatus = (result is not null? true:false);
             
            Assert.Equal("false", repoStatus.ToString().ToLower());
        }
    }
}
