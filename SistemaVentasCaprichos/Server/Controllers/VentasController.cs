using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SistemaVentasCaprichos.Server.Controllers;
using SistemaVentasCaprichos.Server.Data;
using SistemaVentasCaprichos.Shared;

namespace SistemaVentasCaprichos.Server.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public VentasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //GET: api/ventas
        [HttpGet]
        public async Task<ActionResult<List<Venta>>> Get()
        {
            return await context.Ventas.Include(x => x.Cliente)
                
                .Include(x => x.DetalleVentas)
                .ThenInclude(x => x.Articulo)
                .ToListAsync();
        }

        //GET: api/ventas/filtro/cliente&empleado&fecha
        [HttpGet("filtro")]
        public async Task<ActionResult<List<Venta>>> Get([FromQuery] string empleado, [FromQuery] string fecha)
        {
            DateTime f = Convert.ToDateTime(fecha);

            var queryable = context.Ventas.Include(x => x.Cliente)
                
                .Include(x => x.DetalleVentas)
                .ThenInclude(x => x.Articulo).AsQueryable();

            
            return await queryable.OrderByDescending(x => x.Fecha).ToListAsync();
        }

        // GET: api/ventas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Venta>> Get(int id)
        {
            return await context.Ventas.Include(x => x.Cliente)                
                .Include(x => x.DetalleVentas)
                .ThenInclude(x => x.Articulo)
                .FirstAsync(x => x.Id == id);
        }

        // POST: api/ventas 
        [HttpPost]
        public async Task<ActionResult<int>> Post(Venta venta)
        {
            context.Ventas.Add(venta);
            try
            {
                            
                venta.Fecha = DateTime.Now;
                await context.SaveChangesAsync();

                await DecrementaStock(venta);

                if (venta.ClienteId != null)
                {
                    
                }
            }
            catch (DbUpdateException)
            {
                if (Exists(venta.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return venta.Id;
        }

        // DELETE: api/ventas/5  
        [HttpDelete("{id}")]
        public async Task<ActionResult<Venta>> Delete(int id)
        {
            var venta = await context.Ventas.Include(x => x.DetalleVentas)
                .FirstAsync(x => x.Id == id);

            if (venta != null)
            {
                if (venta.ClienteId != null)
                {
                    
                }
                await IncrementaStock(venta);

                context.Ventas.Remove(venta);
                await context.SaveChangesAsync();

                return venta;
            }
            else
            {
                return NotFound();
            }
        }

        private bool Exists(int id)
        {
            return context.Ventas.Any(e => e.Id == id);

        }

        

       

        private async Task DecrementaStock(Venta venta)
        {
            var lista_articulo = await context.Articulos.ToListAsync();
            ArticulosController articulos = new ArticulosController(context);

            foreach (var detalle in venta.DetalleVentas)
            {
                var articulo = lista_articulo.First(x => x.Id == detalle.ArticuloId);
                articulo.StockActual = articulo.StockActual - detalle.Cantidad;
                await articulos.Put(articulo);
            }
        }

        private async Task IncrementaStock(Venta venta)
        {
            var lista_articulo = await context.Articulos.ToListAsync();

            ArticulosController articulos = new ArticulosController(context);
            foreach (var detalle in venta.DetalleVentas)
            {
                var articulo = lista_articulo.First(x => x.Id == detalle.ArticuloId);
                articulo.StockActual = articulo.StockActual + detalle.Cantidad;
                await articulos.Put(articulo);
            }
        }
    }
}