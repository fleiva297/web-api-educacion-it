using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiAutores.Models;
using WebApiDemoEF.Data;

namespace WebApiAutores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly DBLibrosEFContext context;

        public AutorController(DBLibrosEFContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Autor> Get()
        {
            return context.Autores.ToList();
        }

        [HttpGet("{id}")]
        public Autor GetById(int id)
        {
            return context.Autores.SingleOrDefault(c => c.Id == id);
        }

        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id)
        {
            //buscar uno por ID
            Autor autor = context.Autores.Find(id);

            if (autor == null)
            {
                return NotFound();
            }

            //EF guarda en memoria
            context.Autores.Remove(autor);
            //EF guarda en DB
            context.SaveChanges();

            return autor;

        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Autor autor)
        {
            if (id != autor.Id)
            {
                return BadRequest();
            }

            context.Entry(autor).State = EntityState.Modified;

            //EF guarda en DB
            context.SaveChanges();

            return NoContent();
        }
    }
}
