using BuildingBlock.Zones.CRMIL.Model.Customer.RequestModel;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



namespace BuildingBlock.Zones.CRMIL.Repo.Helper
{

    public  interface IHttpClientWrapper
    {
        public Task<object> PostOperation(string apiUrl, object postObject); 
    }

    public class HTTPClient : IHttpClientWrapper
    {
        private readonly IConfiguration _configuration;
        private readonly IUtility _utility;

        public HTTPClient(IConfiguration config, IUtility utility ) 
        {
            _configuration = config;
            _utility=utility;

        }
        public async Task<object> PostOperation(string apiUrl, Object postObject)
        {
            object result = null;
            try
            {
             //   Utility utility = new Utility(_configuration);
                //string token = await utility.GetTokenAsync();
                string token = await _utility.GetTokenAsync();
                using (var client = new HttpClient())
                {
                    Object objData = (Object)postObject;
                    var json = JsonConvert.SerializeObject(objData);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    client.DefaultRequestHeaders.Add("Authorization", token); // "Authorization" Put in a constant file.
                    var response = await client.PostAsync(apiUrl, data);

                    if (response.IsSuccessStatusCode)
                    {
                        result = JsonConvert.DeserializeObject<object>(await response.Content.ReadAsStringAsync());

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    }
    /// <summary>
    /// A generic wrapper class to REST API calls
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HTTPClientWrapper<T> where T : class
    {
        private readonly IConfiguration _configuration;
        public HTTPClientWrapper(IConfiguration config)
        {
            _configuration = config;
        }
        //public HTTPClientWrapper()
        //{

        //}

        /// <summary>
        /// For getting the resources from a web api
        /// </summary>
        /// <param name="url">API Url</param>
        /// <returns>A Task with result object of type T</returns>
        public async Task<T> Get(string url)
        {
            T result = null;
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6ImpTMVhvMU9XRGpfNTJ2YndHTmd2UU8yVnpNYyIsImtpZCI6ImpTMVhvMU9XRGpfNTJ2YndHTmd2UU8yVnpNYyJ9.eyJhdWQiOiJodHRwczovL2dsb2JhbHFhNWYwMzhjM2Y4ZjBlYmUyNGFvcy5jbG91ZGF4LmR5bmFtaWNzLmNvbSIsImlzcyI6Imh0dHBzOi8vc3RzLndpbmRvd3MubmV0L2Q4NjYwODA2LWYzOGQtNGNhMC1hNmYxLThkZWI3Y2ZlODk3MS8iLCJpYXQiOjE2NDgxMTY4ODEsIm5iZiI6MTY0ODExNjg4MSwiZXhwIjoxNjQ4MTIwNzgxLCJhaW8iOiJFMlpnWURENDlrRDJpazk1d3UxOWkwMXovMTNaQndBPSIsImFwcGlkIjoiMGJlMTZhYTUtODFmZi00NmUyLWIzNjQtNGE5ZmJiMmFhOWJkIiwiYXBwaWRhY3IiOiIxIiwiaWRwIjoiaHR0cHM6Ly9zdHMud2luZG93cy5uZXQvZDg2NjA4MDYtZjM4ZC00Y2EwLWE2ZjEtOGRlYjdjZmU4OTcxLyIsIm9pZCI6IjZlNTcyM2FjLWQ0ODktNDIyOS04NTA5LTc2MTAzMzlhZmYxYiIsInJoIjoiMC5BUTBBQmdobTJJM3pvRXltOFkzcmZQNkpjUlVBQUFBQUFBQUF3QUFBQUFBQUFBQU5BQUEuIiwic3ViIjoiNmU1NzIzYWMtZDQ4OS00MjI5LTg1MDktNzYxMDMzOWFmZjFiIiwidGlkIjoiZDg2NjA4MDYtZjM4ZC00Y2EwLWE2ZjEtOGRlYjdjZmU4OTcxIiwidXRpIjoiZEoxWGdQUkM0RXk1WlFMcjhqNGtBUSIsInZlciI6IjEuMCJ9.oqAx_L_4c0PsGmNaYQEgg_032jswPLZToGnfH0AbIL4hl-v97KEBP6H7j78utZckPZ7JuQ_OXDKz13BlHEp6fvLRwTJLxP-nB3LwL7wn3_df2oEJYwBmLwDJLGJhqFe_JFQ308fC-I5ula9lQypP8P93yEG2XFQtqpaXcusSMfaGA0im4hB_XP8RDpIJNYIqH-frAlz1XxN8QB90g9XD5a196X09eyORxY8biHI8tcn9b2x8Q_9nhg6QEWaqGQZhwEp418nIWqXnCXzVqY4DS-z5sySvKtRPp7rrPstO40TQf4NNczfuhrXe_yB-AlogsYyc9PPoDYadL9jvf3gimg");

                var response = httpClient.GetAsync(new Uri(url)).Result;
                response.EnsureSuccessStatusCode();
                await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
                {
                    if (x.IsFaulted)
                        throw x.Exception;
                    result = JsonConvert.DeserializeObject<T>(x.Result);
                });
            }
            return result;
        }



        /// <summary>
        /// For creating a new item over a web api using POST
        /// </summary>
        /// <param name="apiUrl">API Url</param>
        /// <param name="postObject">The object to be created</param>
        /// <returns>A Task with created item</returns>
        public async Task<T> PostRequest(string apiUrl, Object postObject)
        {
            T result = null;
            try
            {
                Utility utility = new Utility(_configuration);
                string token =await utility.GetTokenAsync();                
                using (var client = new HttpClient())
                {
                    Object objData = (Object)postObject; 
                    var json = JsonConvert.SerializeObject(objData);

                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    client.DefaultRequestHeaders.Add("Authorization", token); // "Authorization" Put in a constant file.
                    var response = await client.PostAsync(apiUrl, data);

                    if (response.IsSuccessStatusCode)
                    {   
                        await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
                        {
                            if (x.IsFaulted)
                            {
                                throw x.Exception;
                            }
                            result = JsonConvert.DeserializeObject<T>(x.Result);
                        });
                    } 
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public async Task<object> PostRequestOperation(string apiUrl, Object postObject)
        {
            object result = null;
            try
            {
                Utility utility = new Utility(_configuration);
                string token = await utility.GetTokenAsync();
                using (var client = new HttpClient())
                {
                    Object objData = (Object)postObject;
                    var json = JsonConvert.SerializeObject(objData);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    client.DefaultRequestHeaders.Add("Authorization", token); // "Authorization" Put in a constant file.
                    var response = await client.PostAsync(apiUrl, data);

                    if (response.IsSuccessStatusCode)
                    {
                        result=JsonConvert.DeserializeObject<object>(await response.Content.ReadAsStringAsync());

                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return result;
        }

        public async Task<T> PostRequest(string apiUrl, Object postObject, string token)
        {
            T result = null;
            try
            {  
                using (var client = new HttpClient())
                {
                    Object objData = (Object)postObject;
                    var json = JsonConvert.SerializeObject(objData);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    client.DefaultRequestHeaders.Add("Authorization", token);
                    var response = await client.PostAsync(apiUrl, data);

                    if (response.IsSuccessStatusCode)
                    {
                        await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
                        {
                            if (x.IsFaulted)
                                throw x.Exception;

                            result = JsonConvert.DeserializeObject<T>(x.Result);
                        });
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }




        /// <summary>
        /// For updating an existing item over a web api using PUT
        /// </summary>
        /// <param name="apiUrl">API Url</param>
        /// <param name="putObject">The object to be edited</param>
        public static async Task PutRequest(string apiUrl, T putObject)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PutAsync(apiUrl, putObject, new JsonMediaTypeFormatter()).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
