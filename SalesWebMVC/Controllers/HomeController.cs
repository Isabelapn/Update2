using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class HomeController : Controller //a HomeController é uma subclasse do controlador Controller
    {
        public IActionResult Index() // Método Index => IActionResult (resultado da ação)
        {
            return View(); // Caso na URL não seja iniciado qual ação tomar, aparecerá a pág da Home/Index
        }

        public IActionResult About() // Método About
        {
            ViewData["Message"] = "Sales Web MVC App from C# Course";
            ViewData["Professor"] = "Isabela Nascimento";

            return View();
        }

        public IActionResult Contact() // Método Contact
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy() // Método Privacy
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() // Método Error
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
