using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Triangulos triangulo)
        {
            ViewBag.esTriangulo = triangulo.esTriangulo();
            ViewBag.tipo = triangulo.tipoTriangulo();
            ViewBag.perimetro = triangulo.definirDistancias().Sum();
            ViewBag.area = triangulo.area();
            return Json(triangulo.definirDistancias());
            return View(triangulo);
        }
    }
}
