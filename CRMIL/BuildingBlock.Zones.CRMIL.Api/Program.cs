using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace BuildingBlock.Zones.CRMIL.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Run();
        }
        /// <summary>
        /// CreateOrderAsync Web Host Builder
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHost CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseHealthChecks("/HealthCheck/status")
                .UseUrls("http://localhost:61000")
                .UseStartup<Startup>()
                .Build();
    }
}


