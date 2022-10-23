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
    public class CateController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public CateController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<CateProducto>>> Get()
        {
            return await context.CateProducto.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CateProducto>> Get(int id)
        {
            return await context.CateProducto.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpGet("buscar/{textoBusqueda}")]
        public async Task<ActionResult<List<CateProducto>>> Get(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<CateProducto>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await context.CateProducto
            .Where(x => x.Nombre.ToLower().Contains(textoBusqueda)).ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(CateProducto categorias)
        {

            context.Add(categorias);
            await context.SaveChangesAsync();
            return categorias.Id;
        }
        [HttpPut]
        public async Task<ActionResult> Put(CateProducto categoria)
        {
            context.Attach(categoria).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.CateProducto.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new CateProducto { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}