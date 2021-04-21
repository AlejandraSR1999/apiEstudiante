using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiEstudiante.Models
{
    public class Data
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Estudiante { get; set; }

        [Required]
        public string Temperatura { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime EventDateTime { get; set; }

    }
}

