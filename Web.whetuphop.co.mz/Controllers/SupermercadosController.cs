using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.whetuphop.co.mz.Controllers
{
    public class SupermercadosController: Controller
    {
        public ActionResult Index(string slug)
        {
            return View();
        }

        //Get: Supermercado/{slug}/Anuncios
        public ActionResult Anuncios(string slug)
        {
            return View("../Anuncios/Index");
        }
    }
}