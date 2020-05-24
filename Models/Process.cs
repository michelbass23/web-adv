using System;
using System.ComponentModel.DataAnnotations;

namespace EscAdv.Models
{
    public class Process
    {
        public int id { get; set; }

        [Display(Name = "Título")]
        public string title { get; set; }

        [Display(Name = "Tipo Processo")]
        public string type { get; set; }

        [Display(Name = "Número Petição")]
        public string petition { get; set; }
        // [DataType(DataType.Date)]
        // public DateTime created { get; set; }
    }
}