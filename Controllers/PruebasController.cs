using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public ActionResult Index()
        {
            var idgs902 = new Alumnos() { Name = "Mario", Email = "mar@mail.com", Age = "18" };

            return Json(idgs902, JsonRequestBehavior.AllowGet);
            //return Content("<h1>Index ASP.NET</h1>");
            //return View();
        }

        public RedirectResult Index2()
        {
            return Redirect("https://www.google.com/");
        }

        public RedirectToRouteResult Index3()
        {
            return RedirectToAction("OperasBas", "Nuevo");
        }

        public ActionResult Index4()
        {
            ViewBag.Grupo = "IDGS902";
            ViewBag.Numero = 20;
            ViewBag.FechaInicio = new DateTime(2023, 2, 5);

            ViewData["Nombre"] = "Mario";
            return View();
        }
    }
}