using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVentasCaprichos.Server.Common;
using SistemaVentasCaprichos.Server.Controllers;
using SistemaVentasCaprichos.Server.Data;
using SistemaVentasCaprichos.Shared;

namespace SistemaVentasCaprichos.Server.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    
    public class EgresosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public EgresosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //GET: api/egresos
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Egresos>>> Get()
        {
            return await context.Egresos
                .Include(x => x.ApplicationUser) //  conexion con el empleado que hace este movimiento
                .Include(x => x.DetalleEgresos)
                .ToListAsync();
        }

        //GET: api/compras/filtro/cliente&empleado&fecha
        [HttpGet("filtro")]
        [AllowAnonymous]
        // public async Task<ActionResult<List<Compra>>> Get([FromQuery] string empleado, [FromQuery] string fecha)
        public async Task<ActionResult<List<Egresos>>> Get([FromQuery] string empleado, [FromQuery] string fecha)
        {
            DateTime f = Convert.ToDateTime(fecha);

            var queryable = context.Egresos
                .Include(x => x.ApplicationUser)
                .Include(x => x.DetalleEgresos)
                .AsQueryable();

            if (!string.IsNullOrEmpty(empleado))
            {
                queryable = queryable.Where(x => x.ApplicationUser.NombreyApellido.Contains(empleado));
            }
            if (f != DateTime.Today.AddDays(+1))
            {
                queryable = queryable.Where(x => x.Fecha.Day == f.Day &&
                                            x.Fecha.Month == f.Month &&
                                            x.Fecha.Year == f.Year);
            }
            return await queryable.OrderByDescending(x => x.Fecha).ToListAsync();
        }

        // GET: api/compras/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Egresos>> Get(int id)
        {
            return await context.Egresos
                .Include(x => x.ApplicationUser)
                .Include(x => x.DetalleEgresos)
                .FirstAsync(x => x.Id == id);
        }

        // POST: api/compras 
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<int>> Post(Egresos egresos)
        {
            context.Egresos.Add(egresos);
            try
            {
                var userid = User.GetUserId();
                egresos.EmpleadoId = userid;
                egresos.Fecha = DateTime.Now;
                await context.SaveChangesAsync();
                
            }
            catch (DbUpdateException)
            {
                if (Exists(egresos.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return egresos.Id;
        }

        // DELETE: api/compras/5  
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Egresos>> Delete(int id)
        {
            var egresos = await context.Egresos.Include(x => x.DetalleEgresos)
                .FirstAsync(x => x.Id == id);

            if (egresos != null)
            {
                context.Egresos.Remove(egresos);
                await context.SaveChangesAsync();

                return egresos;
            }
            else
            {
                return NotFound();
            }
        }

        private bool Exists(int id)
        {
            return context.Egresos.Any(e => e.Id == id);

        }
    }
}