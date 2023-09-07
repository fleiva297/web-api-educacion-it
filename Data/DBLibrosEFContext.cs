using Microsoft.EntityFrameworkCore;
using WebApiAutores.Models;

namespace WebApiDemoEF.Data
{
    public class DBLibrosEFContext: DbContext
    {
        //tiene que estar el constructor con parámetro
        public DBLibrosEFContext(DbContextOptions<DBLibrosEFContext> options) : base(options) { }

        //Propiedades DBSET por Modelo
        //DML |
        //    V
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
    }

}
