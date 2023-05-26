using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class GuardaService
    {
        public void GuardaArchivo(Maestros maes) 
        {
            var nombre = maes.Nombre;
            var apaterno = maes.Apaterno;
            var amaterno = maes.Amaterno;
            var edad = maes.Edad;
            var email = maes.Email;
            var datos = nombre + ", " + apaterno + ", " + amaterno + ", " + edad + ", " + email + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            File.AppendAllText(archivo, datos);
        }

        public void GuardaPalabra(Palabras palabra)
        {
            var esp = palabra.Esp;
            var ing = palabra.Ing;

            var datos = esp + ", " + ing + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");
            File.AppendAllText(archivo, datos);
        }
    }
}