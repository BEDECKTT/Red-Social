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
    public class PublicacionFotoesController : ApiController
    {
        private AppDevextremeContext db = new AppDevextremeContext();

        private static readonly HttpClient PubliF = new HttpClient();
        public async Task<HttpResponseMessage> GetPubliF(DataSourceLoadOptions loadOptions)
        {
            var apiUrl = "https://localhost:44323/api/PublicacionFotoes";

            var respuestaJson = await GetAsync(apiUrl);

            List<PublicacionFoto> listaPubliF = JsonConvert.DeserializeObject<List<PublicacionFoto>>(respuestaJson);
            return Request.CreateResponse(DataSourceLoader.Load(listaPubliF, loadOptions));
        }
        public static async Task<string> GetAsync(string uri)
        {
            var response = await PubliF.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostPubliF(FormDataCollection form)
        {

            var values = form.Get("values");

            var httpContent = new StringContent(values, System.Text.Encoding.UTF8, "application/json");

            var url = "https://localhost:44323/api/PublicacionFotoes";
            var response = await PubliF.PostAsync(url, httpContent);

            var result = response.Content.ReadAsStringAsync().Result;

            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}