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
    public class ConfiguracionController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public ConfiguracionController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Configuracion>>> Get()
        {
            return await context.Configuracion.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Configuracion>> Get(int id)
        {
            return await context.Configuracion.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpGet("buscar/{textoBusqueda}")]
        public async Task<ActionResult<List<Configuracion>>> Get(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<Configuracion>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await context.Configuracion
            .Where(x => x.NombreSistema.ToLower().Contains(textoBusqueda)).ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Configuracion configuracion)
        {

            context.Add(configuracion);
            await context.SaveChangesAsync();
            return configuracion.Id;
        }
        [HttpPut]
        public async Task<ActionResult> Put(Configuracion configuracion)
        {
            context.Attach(configuracion).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Configuracion.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Configuracion { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}