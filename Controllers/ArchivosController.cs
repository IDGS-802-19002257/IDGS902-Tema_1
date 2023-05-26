using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Maestros maes) 
        {
            var ope1 = new GuardaService();
            ope1.GuardaArchivo(maes);

            return View(maes);
        }

        public ActionResult LeerDatos()
        {
            var arch = new LeerService();
            ViewBag.Archivos = arch.LeerArchivo();

            return View();
        }
    }
}