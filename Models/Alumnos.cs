﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Alumnos
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public bool Activo { get; set; }
        public DateTime Inscripcion { get; set; }
    }
}