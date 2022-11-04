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
    public class MarcasController : ControllerBase
    {
        Marcas objMarcas = new Marcas();
        private readonly ApplicationDbContext context;
        public MarcasController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Marcas>>> Get()
        {
            //return await context.Marca.ToListAsync();
            return await context.Marca
                .Where(x => x.Estado == true) // a través de este where solo se muestran en pantalla los que tengan un estado true
                .ToListAsync();
        }
        [HttpGet("bajas")]
        public async Task<ActionResult<List<Marcas>>> GetBajas()
        {
            //return await context.Marca.ToListAsync();
            return await context.Marca
                .Where(x => x.Estado != true) // a través de este where solo se muestran en pantalla los que tengan un estado true
                .ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Marcas>> Get(int id)
        {
            return await context.Marca.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpGet("buscar/{textoBusqueda}")]
        public async Task<ActionResult<List<Marcas>>> Get(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<Marcas>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await context.Marca
            .Where(x => x.Nombre.ToLower().Contains(textoBusqueda)).ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Marcas Marcas)
        {

            context.Add(Marcas);
            await context.SaveChangesAsync();
            return Marcas.Id;
        }
        [HttpPut]
        public async Task<ActionResult> Put(Marcas Marcas)
        {
            context.Attach(Marcas).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Marca.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Marcas { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Marcas>>> GetDos()
        //{
        //    var desactivado = await context.Marca.AnyAsync(x => x.Estado == true);
        //    if (!desactivado) { return NotFound(); }
            
        //    return await context.Marca.ToListAsync();
        //}
    }
}