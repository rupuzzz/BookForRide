using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.BikeData.Repository.Concrete.Utility
{
    public class ApiProxy <T>
    {
        static HttpClient client = new HttpClient();
        private static readonly string _baseUrl;

         static ApiProxy()
        {
            _baseUrl = "https://localhost:44392/api/";//ConfigurationManager.AppSettings["BaseUrl"];
            client.BaseAddress = new Uri(_baseUrl);
        }
        public static async Task<T> Get(T model, string endopoint)
        {
            try
            {
               
                HttpResponseMessage response = await client.GetAsync($"{_baseUrl}/{endopoint}");
                if (response.IsSuccessStatusCode)
                {
                    //product = await response.Content.ReadAsAsync<Product>();
                }
            }
            catch
            {
                throw;
            }
            return default;
        }

        public static async Task<T> Post(T model, string endpoint)
        {
            try
            {
                var stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(endpoint, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync();
                }
            }
            catch
            {
                throw;
            }
            return default;
        }
       
    }
}
