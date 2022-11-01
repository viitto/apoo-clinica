using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Exame
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}