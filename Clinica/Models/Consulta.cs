﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Consulta
    {
        public long? Id{ get; set; }
        public DateTime Data_hora{ get; set; }
        public string Sintomas{ get; set; }
        public long? ExameId { get; set; }
        public Exame Exame { get; set; }
    }
}