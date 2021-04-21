using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace asrfncestudiante.Models
{
    class Data
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
