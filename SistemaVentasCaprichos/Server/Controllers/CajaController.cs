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
        // POST: api/ventas 
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<int>> Post(Caja caja)
        {
            context.Caja.Add(caja);
            
            try
            {
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
        //GET: api/caja
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Caja>>> Get()
        {
            return await context.Caja.OrderBy(x => x.Id).ToListAsync();
        }
        private bool Exists(int id)
        {
            return context.Caja.Any(e => e.Id == id);

        }       
    }
}
