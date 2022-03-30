using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using System;
using System.Data.Services.Client;
using System.Globalization;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Repo.Helper
{
    ///<Summary>
    /// Generates Bearer Token Based on the D365 Client Id and Secret Id
    ///</Summary>
    ///
    public interface IUtility
    {
        public Task<string> GetTokenAsync();


    }
    public class TestUtility : IUtility
    {
        private readonly IConfiguration _configuration;
        public TestUtility(IConfiguration config)
        {
            _configuration = config;
        }

        private async Task<string> GetAuthenticationHeader()
        {
            string Authority = String.Format(CultureInfo.InvariantCulture, _configuration["Instance"], _configuration["Tenant"]);
            IConfidentialClientApplication app = ConfidentialClientApplicationBuilder.Create(_configuration["ClientId"])
                    .WithClientSecret(_configuration["ClientSecret"])
                    .WithAuthority(new Uri(Authority))
                    .Build();
            string[] scopes = new string[] { $"{_configuration["BaseUrl"]}/.default" };
            AuthenticationResult result = await app.AcquireTokenForClient(scopes)
                .ExecuteAsync();
            return result.CreateAuthorizationHeader();
        }

        private void ReportODataError(DataServiceQueryException ex)
        {
            //Client level Exception message
            Console.WriteLine(ex.Message);

            //The InnerException of DataServiceQueryException contains DataServiceClientException
            DataServiceClientException dataServiceClientException = ex.InnerException as DataServiceClientException;

            // You can get ODataErrorException from dataServiceClientException.InnerException
            // This object holds Exception as thrown from the service
            // ODataErrorException contains odataErrorException.Message contains a message string that conforms to dotnet
            // Exception.Message standards
            var odataErrorException = dataServiceClientException.InnerException as Microsoft.OData.ODataErrorException;
            if (odataErrorException != null)
            {
                Console.WriteLine(odataErrorException.Message);
            }

            Console.WriteLine(dataServiceClientException.Message);
        }
        // Generate Token
        public async Task<string> GetTokenAsync()
        {

            string bearerToken = await GetAuthenticationHeader();
            return bearerToken;
        }

    }
    public class Utility
    {
        private readonly IConfiguration _configuration; 
        public Utility(IConfiguration config)
        {
            _configuration = config;
        }

        private  async Task<string> GetAuthenticationHeader()
        {
            string Authority = String.Format(CultureInfo.InvariantCulture, _configuration["Instance"], _configuration["Tenant"]);
            IConfidentialClientApplication app = ConfidentialClientApplicationBuilder.Create(_configuration["ClientId"])
                    .WithClientSecret(_configuration["ClientSecret"])
                    .WithAuthority(new Uri(Authority))
                    .Build();
            string[] scopes = new string[] { $"{_configuration["BaseUrl"]}/.default" };
            AuthenticationResult result = await app.AcquireTokenForClient(scopes)
                .ExecuteAsync();
            return result.CreateAuthorizationHeader();
        }

        private void ReportODataError(DataServiceQueryException ex)
        {
            //Client level Exception message
            Console.WriteLine(ex.Message);

            //The InnerException of DataServiceQueryException contains DataServiceClientException
            DataServiceClientException dataServiceClientException = ex.InnerException as DataServiceClientException;

            // You can get ODataErrorException from dataServiceClientException.InnerException
            // This object holds Exception as thrown from the service
            // ODataErrorException contains odataErrorException.Message contains a message string that conforms to dotnet
            // Exception.Message standards
            var odataErrorException = dataServiceClientException.InnerException as Microsoft.OData.ODataErrorException;
            if (odataErrorException != null)
            {
                Console.WriteLine(odataErrorException.Message);
            }

            Console.WriteLine(dataServiceClientException.Message);
        }
        // Generate Token
        public  async Task<string> GetTokenAsync()
        {  

           string bearerToken = await GetAuthenticationHeader();
            return bearerToken;
        }

    }
}
