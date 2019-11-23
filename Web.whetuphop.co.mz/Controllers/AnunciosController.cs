using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.whetuphop.co.mz.Controllers
{
    public class AnunciosController: Controller
    {
        //Get: Supermercado/{slug}/Anuncios
        public ActionResult Anuncios(string slug)
        {
            return View();
        }
    }
}