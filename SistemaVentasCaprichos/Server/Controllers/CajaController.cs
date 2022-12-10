using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using SistemaVentasCaprichos.Client.Pages.Articulos;
using SistemaVentasCaprichos.Server.Common;
using SistemaVentasCaprichos.Server.Data;
using SistemaVentasCaprichos.Shared;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class CajaController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private DateTime hoy = DateTime.Now;

        public CajaController(ApplicationDbContext context)
        {
            this.context = context;
        }
        //GET: api/compras
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Caja>>> Get()
        {
            return await context.Caja.ToListAsync();
        }
        //GET: api/caja/filtro/cliente&empleado&fecha
        [HttpGet("filtro")]
        [AllowAnonymous]        
        public async Task<ActionResult<List<Caja>>> Get([FromQuery] string fecha) // Entra en conflicto con VsCode y Rider
        {
            DateTime f = Convert.ToDateTime(fecha);

            var queryable = context.Caja.AsQueryable();

            if (f != DateTime.Today)
            {
                queryable = queryable.Where(x => x.Fecha.Day == f.Day &&
                                            x.Fecha.Month == f.Month &&
                                            x.Fecha.Year == f.Year);
            }
            return await queryable.OrderByDescending(x => x.Fecha).ToListAsync();
        }

        // GET: api/ventas/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Caja>> Get(int id)
        {
            return await context.Caja.Include(x => x.Id).FirstAsync(x => x.Id == id);
        }
        // POST: api/ventas 
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<int>> Post(Caja caja)
        {
            context.Caja.Add(caja);
            
            try
            {
                //caja.Egresos = context.Egresos.Sum(x => x.Total) + context.Compras.Sum(x => x.Total);
                caja.Egresos = context.Compras.Sum(x => x.Total); //  obtiene la suma del total de compras
                caja.Ingresos = context.Ventas.Sum(x => x.Total); // obtiene la suma del total de ventas
                

                caja.Saldo = context.Ventas.Sum(x => x.Total) - context.Compras
                    .Sum(x => x.Total); // resta de ambos totales
                // TODO: Validar cuando sea negativo

                caja.Fecha = DateTime.Now;
                await context.SaveChangesAsync();                                            
            }
            catch (DbUpdateException)
            {
                if (Exists(caja.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return caja.Id;
        }
      
        private bool Exists(int id)
        {
            return context.Caja.Any(e => e.Id == id);

        }       
    }
}
