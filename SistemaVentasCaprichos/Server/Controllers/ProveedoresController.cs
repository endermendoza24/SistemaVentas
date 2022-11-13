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
    public class ProveedoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public ProveedoresController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Proveedores>>> Get()
        {
            return await context.Proveedores.Where(x => x.Estado == true).ToListAsync();
        }
        [HttpGet("bajas")]
        public async Task<ActionResult<List<Proveedores>>> GetBajas()
        {
            return await context.Proveedores.Where(x => x.Estado == false).ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Proveedores>> Get(int id)
        {
            return await context.Proveedores.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpGet("buscar/{textoBusqueda}")]
        public async Task<ActionResult<List<Proveedores>>> Get(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<Proveedores>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await context.Proveedores
            .Where(x => x.Nombre.ToLower().Contains(textoBusqueda)).ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Proveedores Proveedores)
        {

            context.Add(Proveedores);
            await context.SaveChangesAsync();
            return Proveedores.Id;
        }
        [HttpPut]
        public async Task<ActionResult> Put(Proveedores Proveedores)
        {
            context.Attach(Proveedores).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Proveedores.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Proveedores { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}