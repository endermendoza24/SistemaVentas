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
    public class DevolucionesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public DevolucionesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Retornos>>> Get()
        {
            return await context.Retornos.Include(x => x.DetalleVenta)                 
                .ToListAsync();
        }
        
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Retornos>> Get(int id)
        {
            return await context.Retornos.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpGet("buscar/{textoBusqueda}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Retornos>>> Get(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<Retornos>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await context.Retornos
            .Where(x => x.Motivo.ToLower().Contains(textoBusqueda)).ToListAsync();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<int>> Post(Retornos devoluciones)
        {
            //buscar el producto en la tabla DetalleVentas
            var detalleVenta = await context.DetalleVentas.FirstOrDefaultAsync(p => p.Id == devoluciones.DetalleVentaId);
            if (detalleVenta == null) return BadRequest("No existe una venta con ese id");

            //buscar el articulo relacionado con detalleVenta
            var articulo = await context.Articulos.FirstOrDefaultAsync(p => p.Id == detalleVenta.ArticuloId);
            if (articulo == null) return BadRequest("No existe un articulo con ese id");

            //verificar si el producto existe y si hay suficiente cantidad para devolver
            if (articulo != null && articulo.StockActual >= devoluciones.Cantidad)
            {
                //buscar el producto en la tabla DetalleVentas
                var producto = await context.DetalleVentas.FirstOrDefaultAsync(p => p.Id == devoluciones.DetalleVentaId);

                //buscar la venta relacionada con el detalleVenta
                var venta = await context.Ventas.FirstOrDefaultAsync(v => v.Id == detalleVenta.VentaId);

                //buscar la caja relacionada con la venta
                var caja = await context.Caja.FirstOrDefaultAsync(c => c.IdVenta == venta.Id);

                //crear nuevo registro en la tabla Retornos
                context.Retornos.Add(devoluciones);
                //actualizar la cantidad en inventario en la tabla Articulos
                articulo.StockActual += devoluciones.Cantidad;
                detalleVenta.Cantidad -= devoluciones.Cantidad;

                //crear nuevo registro en la tabla Retornos                
                devoluciones.Precio = producto.Precio;
                devoluciones.Descuento = producto.Descuento;
                context.Retornos.Add(devoluciones);

                //actualizar el campo Total en la tabla Ventas
                venta.Total = detalleVenta.SubTotalConDescuento; // malo

                //actualizar el campo Saldo en la tabla Caja
                caja.Saldo = detalleVenta.SubTotalConDescuento;

                //guardar cambios en la base de datos
                await context.SaveChangesAsync();
                return devoluciones.Id;
            }
            else
            {
                return BadRequest("El producto seleccionado no está disponible para devolver o la cantidad es incorrecta");
            }
        }




        [HttpPut]
        [AllowAnonymous]
        public async Task<ActionResult> Put(Retornos devoluciones)
        {
            context.Attach(devoluciones).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Retornos.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Retornos { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}