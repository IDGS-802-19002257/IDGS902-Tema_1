using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class LeerService
    {
        public Array LeerArchivo() 
        {
            Array maesDatos = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(datos))
            {
                maesDatos = File.ReadAllLines(datos);
            }
            return maesDatos;
        }

        public String[] LeerPalabras()
        {
            string[] palArchivo = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");

            if (File.Exists(datos))
            {
                palArchivo = File.ReadAllLines(datos);
            }
            return palArchivo;
        }

        public List<Palabras> ObtenerPalabras()
        {
            var palabras = new List<Palabras>();
            var listaPalabras = LeerPalabras();

            if (listaPalabras != null)
            {
                foreach (var linea in listaPalabras)
                {
                    var partes = linea.Split(',');

                    if (partes.Length == 2)
                    {
                        var nuevaPalabra = new Palabras()
                        {
                            Esp = partes[0].Trim(),
                            Ing = partes[1].Trim()
                        };
                        palabras.Add(nuevaPalabra);
                    }
                }
            }

            return palabras;
        }
    }
}