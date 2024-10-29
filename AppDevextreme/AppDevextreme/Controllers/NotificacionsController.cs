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
    public class NotificacionsController : ApiController
    {
        private AppDevextremeContext db = new AppDevextremeContext();

        private static readonly HttpClient Noti = new HttpClient();
        public async Task<HttpResponseMessage> GetNotifi(DataSourceLoadOptions loadOptions)
        {
            var apiUrl = "https://localhost:44323/api/Notificacions";

            var respuestaJson = await GetAsync(apiUrl);

            List<Notificacion> listaComent = JsonConvert.DeserializeObject<List<Notificacion>>(respuestaJson);
            return Request.CreateResponse(DataSourceLoader.Load(listaComent, loadOptions));
        }
        public static async Task<string> GetAsync(string uri)
        {
            var response = await Noti.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostNotif(FormDataCollection form)
        {

            var values = form.Get("values");

            var httpContent = new StringContent(values, System.Text.Encoding.UTF8, "application/json");

            var url = "https://localhost:44323/api/Notificacions";
            var response = await Noti.PostAsync(url, httpContent);

            var result = response.Content.ReadAsStringAsync().Result;

            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}