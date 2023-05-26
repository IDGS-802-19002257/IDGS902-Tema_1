using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class DiccionariosController : Controller
    {
        // GET: Diccionarios
        public ActionResult Index(string idioma = "esp", string buscar = null)
        {
            var arch = new LeerService();
            var palabras = arch.ObtenerPalabras();

            if (palabras != null && palabras.Count > 0)
            {
                if (buscar == null)
                {
                    ViewBag.Palabras = palabras;
                }
                else
                {
                    var buscarfinal = buscar.ToLower();
                    if (idioma == "esp")
                    {
                        var palabrasEsp = palabras.Where(p => p.Esp == buscarfinal).ToList();
                        ViewBag.Palabras = palabrasEsp;
                    }
                    else if (idioma == "ing")
                    {
                        var palabrasIng = palabras.Where(p => p.Ing == buscarfinal).ToList();
                        ViewBag.Palabras = palabrasIng;
                    }
                }
            }
            else
            {
                ViewBag.Palabras = new string[0];
            }

            ViewBag.Idioma = idioma;
            ViewBag.Buscar = buscar;

            return View();
            //return Json(palabras, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Registrar() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Palabras palabras)
        {
            var ope1 = new GuardaService();
            ope1.GuardaPalabra(palabras);

            return RedirectToAction("Index", "Diccionarios");
        }
    }
}