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
using System.Security.Cryptography.X509Certificates;
using IdentityServer4.Extensions;

namespace SistemaVentasCaprichos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "admin, empleado")]
    public class DetalleVentasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public DetalleVentasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //GET: api/ventas
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<DetalleVenta>>> Get()
        {
            return await context.DetalleVentas.ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<DetalleVenta>> Get(int id)
        {
            return await context.DetalleVentas.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
