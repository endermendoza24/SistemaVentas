using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentasCaprichos.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVentasCaprichos.Server;
using SistemaVentasCaprichos.Server.Data;

namespace SistemaVentasCaprichos.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public CategoriasController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Categorias>>> Get()
        {
            return await context.Categoria.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Categorias>> Get(int id)
        {
            return await context.Categoria.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpGet("buscar/{textoBusqueda}")]
        public async Task<ActionResult<List<Categorias>>> Get(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<Categorias>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await context.Categoria
            .Where(x => x.Nombre.ToLower().Contains(textoBusqueda)).ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Categorias categorias)
        {

            context.Add(categorias);
            await context.SaveChangesAsync();
            return categorias.Id;
        }
        [HttpPut]
        public async Task<ActionResult> Put(Categorias categoria)
        {
            context.Attach(categoria).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Categoria.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Categorias { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}