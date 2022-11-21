using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentasCaprichos.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVentasCaprichos.Server;
using SistemaVentasCaprichos.Server.Data;
using Microsoft.AspNetCore.Authorization;

namespace SistemaVentasCaprichos.Server.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "admin")]
    public class MarcasController : ControllerBase
    {
        Marcas objMarcas = new Marcas();
        private readonly ApplicationDbContext context;
        public MarcasController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Marcas>>> Get()
        {
            //return await context.Marca.ToListAsync();
            return await context.Marca
                .Where(x => x.Estado == true) // a través de este where solo se muestran en pantalla los que tengan un estado true
                .ToListAsync();
        }
        [HttpGet("bajas")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Marcas>>> GetBajas()
        {
            //return await context.Marca.ToListAsync();
            return await context.Marca
                .Where(x => x.Estado != true) // a través de este where solo se muestran en pantalla los que tengan un estado true
                .ToListAsync();
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Marcas>> Get(int id)
        {
            return await context.Marca.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpGet("buscar/{textoBusqueda}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Marcas>>> Get(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<Marcas>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await context.Marca
            .Where(x => x.Nombre.ToLower().Contains(textoBusqueda)).ToListAsync();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<int>> Post(Marcas Marcas)
        {

            context.Add(Marcas);
            await context.SaveChangesAsync();
            return Marcas.Id;
        }
        [HttpPut]
        [AllowAnonymous]
        public async Task<ActionResult> Put(Marcas Marcas)
        {
            context.Attach(Marcas).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Marca.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Marcas { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}