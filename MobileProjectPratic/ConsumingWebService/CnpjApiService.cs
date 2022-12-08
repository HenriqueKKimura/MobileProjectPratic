using MobileProjectPratic.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileProjectPratic.ConsumingWebService
{
    public class CnpjApiService
    {
        string URL = "https://receitaws.com.br/v1/cnpj/";
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "Application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");
            return client;
        }
        public async Task<EmpresaResponse> GetCNPJ(string CNPJ)
        {
            try
            {
                using (var client = GetClient())
                {
                    URL += CNPJ;
                    var response = client.GetAsync(URL).Result;
                    if (response.IsSuccessStatusCode) // Codigo 200
                    {
                        string content = response.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<EmpresaResponse>(content);
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
