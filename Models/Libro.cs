using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAutores.Models
{
    [Table("Libro")]
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }

        #region propiedades de navegacion
        public Autor Autor { get; set; }
        #endregion
    }
}
