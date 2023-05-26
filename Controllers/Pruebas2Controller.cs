using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class Pruebas2Controller : Controller
    {
        // GET: Pruebas2
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Age = "28",
                Email = "jime@mail.com",
                Activo = true,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }

        public ActionResult Escuela()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Age = "28",
                Email = "jime@mail.com",
                Activo = true,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            return View(alumno);
        }

        public ActionResult CajasDinamicas(int NumCajas = 0)
        {
            ViewBag.NumCajas = NumCajas;
            return View();
        }

        public ActionResult CajasDinamicasResultados(double[] Caja)
        {
            double prom = 0.0;
            double sum = 0.0;
            List<double> repetidos = new List<double>();

            if (Caja != null && Caja.Length > 0)
            {
                prom = Caja.Average();
                sum = Caja.Sum();

                var agrupados = Caja.GroupBy(x => x);
                repetidos = agrupados.Where(g => g.Count() > 1).Select(g => g.Key).ToList();

            }

            ViewBag.Promedio = prom;
            ViewBag.Sum = sum;
            ViewBag.Repetidos = repetidos;

            return View();
        }


    }
}