using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentasCaprichos.Server.Data;
using SistemaVentasCaprichos.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "admin, empleado")]
    public class ArticulosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ArticulosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //GET: api/articulos
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Articulo>>> Get()
        {
            return await context.Articulos.Where(x => x.Estado == true).OrderBy(x => x.Nombre).ToListAsync(); // hurra
        }


        //GET: api/articulos/filtro/nombre
        [HttpGet("filtro")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Articulo>>> Get([FromQuery] string nombre)
        {
            var queryable = context.Articulos.Where(x => x.Estado == true).OrderBy(x => x.Id).AsQueryable();
            if (!string.IsNullOrEmpty(nombre))
            {
                queryable = queryable.Where(x => x.Nombre.Contains(nombre));
            }
            return await queryable.ToListAsync();
        }

        //  borar si llegara a dar errores
        [HttpGet("filtrodos")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Articulo>>> Get([FromQuery] string nombre,
            [FromQuery] int? marcaId,
            [FromQuery] int? categoriaId,
            [FromQuery] int? tallaId)
        {
            var queryable = context.Articulos.Where(x => x.Estado == true).OrderBy(x => x.Id).AsQueryable();
            if (!string.IsNullOrEmpty(nombre))
            {
                queryable = queryable.Where(x => x.Nombre.Contains(nombre));
            }
            if (marcaId.HasValue)
            {
                queryable = queryable.Where(x => x.MarcaId == marcaId);
            }
            if (categoriaId.HasValue)
            {
                queryable = queryable.Where(x => x.CategoriaId == categoriaId);
            }
            if (tallaId.HasValue)
            {
                queryable = queryable.Where(x => x.TallasId == tallaId);
            }
            return await queryable.ToListAsync();
        }





        //GET: api/articulos/filtro/nombre
        [HttpGet("bajas")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Articulo>>> GetBajas([FromQuery] string nombre)
        {
            var queryable = context.Articulos.Where(x => x.Estado != true).OrderBy(x => x.Id).AsQueryable();
            if (!string.IsNullOrEmpty(nombre))
            {
                queryable = queryable.Where(x => x.Nombre.Contains(nombre));
            }
            return await queryable.ToListAsync();
        }



        // GET: api/articulos/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Articulo>> Get(int id)
        {
            return await context.Articulos.FirstAsync(x => x.Id == id);
        }

        // POST: api/articulos 
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Post(Articulo articulo)
        {
            context.Articulos.Add(articulo);
            try
            {
                articulo.Ultima_Modificación = DateTime.Now;
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Exists(articulo.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }

        // PUT: api/articulos
        [HttpPut]
        [AllowAnonymous]
        public async Task<ActionResult> Put(Articulo articulo)
        {
            context.Entry(articulo).State = EntityState.Modified;
            articulo.Ultima_Modificación = DateTime.Now;
            await context.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/articulos/5  
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Articulo>> Delete(int id)
        {
            var articulo = await context.Articulos.FindAsync(id);
            if (articulo == null)
            {
                return NotFound();
            }

            context.Articulos.Remove(articulo);
            await context.SaveChangesAsync();

            return articulo;
        }

        private bool Exists(int id)
        {
            return context.Articulos.Any(e => e.Id == id);
        }
    }
}