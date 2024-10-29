using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AppDevextreme.Data;
using AppDevextreme.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;

namespace AppDevextreme.Controllers
{
    public class PublicacionsController : ApiController
    {
        private static readonly HttpClient Publi = new HttpClient();
        public async Task<HttpResponseMessage> GetPubli(DataSourceLoadOptions loadOptions)
        {
            var apiUrl = "https://localhost:44323/api/Publicacions";

            var respuestaJson = await GetAsync(apiUrl);

            List<Publicacion> listaPubli = JsonConvert.DeserializeObject<List<Publicacion>>(respuestaJson);
            return Request.CreateResponse(DataSourceLoader.Load(listaPubli, loadOptions));
        }
        public static async Task<string> GetAsync(string uri)
        {
            var response = await Publi.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostPubli(FormDataCollection form)
        {

            var values = form.Get("values");

            var httpContent = new StringContent(values, System.Text.Encoding.UTF8, "application/json");

            var url = "https://localhost:44323/api/Publicacions";
            var response = await Publi.PostAsync(url, httpContent);

            var result = response.Content.ReadAsStringAsync().Result;

            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }   
}