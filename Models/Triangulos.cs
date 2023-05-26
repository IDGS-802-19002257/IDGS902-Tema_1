using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Models
{
    public class Triangulos
    {
        public double ax { get; set; }
        public double ay { get; set; }
        public double bx { get; set; }
        public double by { get; set; }
        public double cx { get; set; }
        public double cy { get; set; }

        public List<double> definirDistancias()
        {
            double distanciaAB = Math.Round(Math.Sqrt(Math.Pow((this.bx - this.ax), 2) + Math.Pow((this.by - this.ay), 2)), 2);
            double distanciaAC = Math.Round(Math.Sqrt(Math.Pow((this.cx - this.ax), 2) + Math.Pow((this.cy - this.ay), 2)), 2);
            double distanciaBC = Math.Round(Math.Sqrt(Math.Pow((this.cx - this.bx), 2) + Math.Pow((this.cy - this.by), 2)), 2);
            var distancias = new List<double> { distanciaAB, distanciaAC, distanciaBC };
            return distancias;
        }

        public bool esTriangulo()
        {
            List<double> distancias = definirDistancias();

            if (distancias[0] > 0 && distancias[1] > 0 && distancias[2] > 0 &&
                distancias[0] + distancias[1] > distancias[2] &&
                distancias[0] + distancias[2] > distancias[1] &&
                distancias[1] + distancias[2] > distancias[0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string tipoTriangulo()
        {
            List<double> distancias = definirDistancias();

            if (distancias[0] == distancias[1] && distancias[1] == distancias[2])
            {
                return "Equilatero";
            }
            else if (distancias[0] == distancias[1] ||
                     distancias[0] == distancias[2] ||
                     distancias[1] == distancias[2])
            {
                return "Isoceles";
            }
            else
            {
                return "Escaleno";
            }
        }

        public double area()
        {
            double area = 0;
            if (esTriangulo())
            {
                List<double> distancias = definirDistancias();
                double semiperimetro = distancias.Sum() / 2;
                area = (double)Math.Sqrt(semiperimetro * (semiperimetro - distancias[0]) * (semiperimetro - distancias[1]) * (semiperimetro - distancias[2]));
            }
            return Math.Round(area, 2);
        }
    }
}