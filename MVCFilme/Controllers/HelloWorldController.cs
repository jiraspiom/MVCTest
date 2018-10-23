using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCFilme.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

                
        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string nome, int numTimes = 3)
        {
            ViewData["Message"] = "Oi " + nome;
            
            ViewData["NumTimes"] = numTimes;                     

            return View();
            
        }


    }
}
