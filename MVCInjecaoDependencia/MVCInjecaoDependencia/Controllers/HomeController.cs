using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCInjecaoDependencia.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnviarEmail _enviarEmail;

        public HomeController([Named("Mock")] IEnviarEmail enviar)
        {
            _enviarEmail = enviar;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _enviarEmail.EnviarEmail("Gilmar borges Silva");

            return View();
        }


    }
}