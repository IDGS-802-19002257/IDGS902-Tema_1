using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OperasBas(string n1, string n2, string opera) {
            int res = 0;
            switch (opera)
            {
                case "suma":
                    res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
                    break;
                case "resta":
                    res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
                    break;
                case "multi":
                    res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
                    break;
                case "divi":
                    res = Convert.ToUInt16(n1) * Convert.ToInt16(n2);
                    break;
            }
            //int res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.Res = Convert.ToString(res);
            return View();
        }

        public ActionResult OperasBas2(Calculos op)
        {
            /*int res = 0;
            switch (opera)
            {
                case "suma":
                    res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
                    break;
                case "resta":
                    res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
                    break;
                case "multi":
                    res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
                    break;
                case "divi":
                    res = Convert.ToUInt16(n1) * Convert.ToInt16(n2);
                    break;
            }*/
            //int res = Convert.ToInt16(n1) + Convert.ToInt16(n2);

            var model = new Calculos();
            model.Res = Convert.ToInt16(op.Num1) + Convert.ToInt16(op.Num2);
            ViewBag.Res = model.Res;
            return View(model);
        }

        public ActionResult Distacias (Calculos op)
        { 
            var model = new Calculos();
            ViewBag.Res = model.resultado(op.x1, op.x2, op.y1, op.y2);
            return View(model);
        }

        public ActionResult MuestraPulques()
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();
            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();
            return View(model);
        }
    }
}