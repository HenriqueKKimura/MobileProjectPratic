using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MobileProjectPratic.ConsumingWebService
{
    public class WebServiceAPI
    {

        public async Task<Clientes> Get<Clientes>(string url)
        {

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("CODIGO", "12345678900");
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)//código 200
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Clientes>(json);
            }
            else
            {
                return default;
            }
        }

        public async Task<UsersCredentials> GetUser<UsersCredentials>(string url)
        {
            HttpClient usuario = new HttpClient();
            var response = await usuario.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<UsersCredentials>(json);
            }
            else
            {
                return default;
            }
        }


    }

}
