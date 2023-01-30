using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using OperaWebSite.Data;
using OperaWebSite.Models;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace OperaWebSite.Controllers
{
    public class OperaController : Controller
    {
        private readonly OperaDBContext context;

        public OperaController(OperaDBContext context)
        {
            this.context = context;

        }

        //Get/Opera
        [HttpGet]

        public IActionResult Index()
        {

            //lista de operas

            var operas = context.Operas.ToList();

            //enviar las operas a la vista
            return View("Index", operas);
        }

        //Get:opera/create

        [HttpGet]
        public ActionResult Create()
        {

            Opera opera = new Opera();

            return View("Create", opera);

        } // devolver al cliente el html 

        //Post:Opera/Create

        [HttpPost]

        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opera);
        }

        //Opera/delete/1

        [HttpGet]

        public ActionResult Delete(int id)
        {
            var opera = TraerUna(id);

            if (opera == null)
            {
                return NotFound();
            }

            else
            {
                return View(opera);
            }

        }
        //Post opera/delete/1

        // POST opera / delete /1
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var opera = TraerUna(id);
            if (opera == null)
            {
                return NotFound();
            }
            else
            {
                context.Operas.Remove(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }

        




        //Get Opera/Detalle/4

        //GET Opera/Details/4
        [HttpGet]
        public ActionResult Details(int id)
        {
            Opera opera = TraerUna(id);
            if (opera == null)
            {
                return NotFound();
            }
            else
            {
                return View("detalle", opera);
            }

        }

        //´métodos privados
        private Opera TraerUna(int id)
        {
            return context.Operas.Find(id);
        }

    }
}

