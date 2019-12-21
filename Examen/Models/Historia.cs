using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Models
{
    public class Historia
    {
        public int ID { get; set; }
        public DateTime fechaAlta { get; set; }
        public int ddoctor { get; set; }
        public int dpaciente { get; set; }
        public string observaciones { get; set; }
    }
}