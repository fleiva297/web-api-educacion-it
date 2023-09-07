using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAutores.Models
{
    [Table("Autor")]
    public class Autor
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)"), Required]
        public string Nombre { get; set; }

        #region propiedades de navegacion
        public List<Libro> Libros { get; set; }
        #endregion
    }
}
