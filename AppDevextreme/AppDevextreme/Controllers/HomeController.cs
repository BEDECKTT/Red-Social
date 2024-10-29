using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppDevextreme.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Publicaciones()
        {  
            return View(); 
        }

        public ActionResult Comentarios()
        {
            return View();
        }

        public ActionResult Notificaciones()
        {
            return View();
        }

        public ActionResult Reacciones()
        {
            return View();
        }

        public ActionResult Pictures()
        {
            return View();
        }

    }
}