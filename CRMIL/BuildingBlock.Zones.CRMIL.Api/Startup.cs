using BuildingBlock.Core.Logger;
using BuildingBlock.Core.Middleware;
using BuildingBlock.Core.WebApi;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using BuildingBlock.Zones.CRMIL.Api.Service;
using BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness;
using BuildingBlock.Zones.CRMIL.Repo;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using BuildingBlock.Zones.CRMIL.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OData.Edm;
//using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.ModelBuilder;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BuildingBlock.Zones.CRMIL.Api
{
    /// <summary>
    /// Startup
    /// </summary>
    public class Startup : BaseStartup
    {
        private string _xmlPathForSwagger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="env"></param>
        public Startup(IWebHostEnvironment env) : base(env)
        {
            SetAbstractProperties();
        }
        /// <summary>
        /// 
        /// </summary>
        protected override string XmlPathForSwagger { get { return _xmlPathForSwagger; } set { _xmlPathForSwagger = value; } }

        private void SetAbstractProperties()
        {
            var basePath = PlatformServices.Default.Application.ApplicationBasePath;
            _xmlPathForSwagger = Path.Combine(basePath, "Order.xml");
        }

        /// <summary>
        /// After Configure
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="loggerFactory"></param>
        /// <param name="versionDescriptionProvider"></param>
        protected override void AfterConfigure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, IApiVersionDescriptionProvider versionDescriptionProvider)
        {
            
        }

        /// <summary>
        /// After Configure Services
        /// </summary>
        /// <param name="services"></param>
        protected override void AfterConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<OrderDbContext>(options =>
             {
                 options.UseSqlServer(Configuration.GetSection("ConnectionString").GetSection("OrderDB").Value);
             });
             // Core Logger for Controller
            services.AddSingleton<ICoreLogger<OrderController>, CoreLogger<OrderController>>();
            services.AddSingleton<ICoreLogger<CustomerController>, CoreLogger<CustomerController>>();
            services.AddSingleton<ICoreLogger<FreightController>, CoreLogger<FreightController>>();
            services.AddSingleton<ICoreLogger<ProductController>, CoreLogger<ProductController>>();
            // Core Logger for Service
            services.AddSingleton<ICoreLogger<OrderService>, CoreLogger<OrderService>>();
            services.AddSingleton<ICoreLogger<FreightService>, CoreLogger<FreightService>>();
            // Core Logger for Global Exception
            services.AddSingleton<ICoreLogger<GlobalExceptionMiddleware>, CoreLogger<GlobalExceptionMiddleware>>();
             // EF configuration
            services.AddSingleton<IOrderService, OrderService>();
            services.AddSingleton<IOrderRepository, OrderRepository>();
            services.AddSingleton<ICustomerService, CustomerService>();
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IHttpClientWrapper, HTTPClient>();
            services.AddSingleton<IUtility, TestUtility>();
            services.AddSingleton<IFreightServices, FreightService>();
            services.AddSingleton<IFreightRepository, FreightRepository>();
            // Register Mediator and Automapper
            services.ConfigureAppService();

        }
         /// <summary>
         /// Before Configure
         /// </summary>
         /// <param name="app"></param>
         /// <param name="env"></param>
         /// <param name="loggerFactory"></param>
         /// <param name="versionDescriptionProvider"></param>
         protected override void BeforeConfigure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, IApiVersionDescriptionProvider versionDescriptionProvider)
         {

         }
         /// <summary>
         /// Before Configure Services
         /// </summary>
         /// <param name="services"></param>
         protected override void BeforeConfigureServices(IServiceCollection services)
         {
           
         }
        /// <summary>
        /// Supported Cultures for Localization
        /// </summary>
        /// <returns></returns>
        protected override List<CultureInfo> SupportedCultures()
        {
            return GetCultures();
        }
        /// <summary>
        /// Supported UI Cultures for Localization
        /// </summary>
        /// <returns></returns>
        protected override List<CultureInfo> SupportedUICultures()
        {
            return GetCultures();
        }
        /// <summary>
        /// Get the Supported Cultures
        /// </summary>
        /// <returns></returns>
        private List<CultureInfo> GetCultures()
        {
            return new List<CultureInfo>
            {
                new CultureInfo("en-US"),
                new CultureInfo("es")
            };
        }
        /// <summary>
        /// Edm Model for Api
        /// </summary>
        /// <returns></returns>
        protected override IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<BuildingBlock.Zones.Model.CRMIL.Order>("Order");
            return builder.GetEdmModel();
        }
    }
}
