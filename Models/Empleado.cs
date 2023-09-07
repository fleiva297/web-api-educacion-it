using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAutores.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)"), Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)"), Required]
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        [Column(TypeName = "varchar(50)"), Required]
        public string Email { get; set; }
    }
}
