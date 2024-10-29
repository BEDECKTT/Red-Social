using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;
using AppDevextreme.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;

namespace AppDevextreme.Controllers {
    public class SampleDataController : ApiController
    {

        private static readonly HttpClient Usuar = new HttpClient();
        [HttpGet]

        public async Task<HttpResponseMessage> Get(DataSourceLoadOptions loadOptions)
        {
            var apiUrl = "https://localhost:44323/api/Usuarios";

            var respuestaJson = await GetAsync(apiUrl);

            List<Usuario> listaPeli = JsonConvert.DeserializeObject<List<Usuario>>(respuestaJson);
            return Request.CreateResponse(DataSourceLoader.Load(listaPeli, loadOptions));
        }
        public static async Task<string> GetAsync(string uri)
        {
            var response = await Usuar.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

      
        [HttpPost]
        public async Task<HttpResponseMessage> Post(FormDataCollection form)
        {

            var values = form.Get("values");

            var httpContent = new StringContent(values, System.Text.Encoding.UTF8, "application/json");

            var url = "https://localhost:44323/api/Usuarios";
            var response = await Usuar.PostAsync(url, httpContent);

            var result = response.Content.ReadAsStringAsync().Result;

            return Request.CreateResponse(HttpStatusCode.Created);
        }

    }


    
}