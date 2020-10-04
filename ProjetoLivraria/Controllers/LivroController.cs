using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLivraria.Controllers
{
    public class LivroController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}