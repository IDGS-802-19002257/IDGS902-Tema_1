using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Calculos
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public double Res { get; set; }

        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }

        public double resultado(int x1, int x2, int y1, int y2)
        {
            Res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return Res;
        }
    }
}