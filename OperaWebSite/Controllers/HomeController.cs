using Microsoft.AspNetCore.Mvc;
using System;

namespace OperaWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido al sistema de operas";
            ViewBag.Fecha=DateTime.Now;
            return View();
        }
    }
}
