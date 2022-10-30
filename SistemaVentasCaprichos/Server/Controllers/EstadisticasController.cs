﻿using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EstadisticasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public EstadisticasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        ////GET: api/estadisticas/ejercicio/
        [HttpGet("ejercicio")]
        public decimal[] GetEjercicio()
        {
            int año = DateTime.Today.Year;

            decimal[] meses = new decimal[12];

            for (int i = 1; i < meses.Length; i++)
            {
                meses[i - 1] = context.Ventas
                .Where(x => x.Fecha.Date.Month == i && x.Fecha.Date.Year == año
                       && x.FormaPago != FormasPago.Cordoba)
                .Sum(x => x.Total) + context.Pagos
                .Where(x => x.Fecha.Date.Month == i && x.Fecha.Date.Year == año)
                .Sum(x => x.Importe);
            }
            return meses;
        }

        ////GET: api/estadisticas/compras/
        [HttpGet("compras")]
        public decimal[] GetCompras()
        {
            int año = DateTime.Today.Year;

            decimal[] meses = new decimal[12];

            for (int i = 1; i < meses.Length; i++)
            {
                meses[i - 1] = context.Compras
                .Where(x => x.Fecha.Date.Month == i && x.Fecha.Date.Year == año)
                .Sum(x => x.Total);
            }
            return meses;
        }

        ////GET: api/estadisticas/ventas/
        [HttpGet("ventas")]
        public decimal[] GetVentas()
        {
            int año = DateTime.Today.Year;

            decimal[] meses = new decimal[12];

            for (int i = 1; i < meses.Length; i++)
            {
                meses[i - 1] = context.Ventas
                .Where(x => x.Fecha.Date.Month == i && x.Fecha.Date.Year == año)
                .Count();
            }
            return meses;
        }

        // GET: api/estadisticas/pendientes
        [HttpGet("pendientes")]
        public async Task<ActionResult<int>> GetPedidosPendientes()
        {
            return await context.Pedidos.Where(x => x.Finalizado == false).CountAsync();
        }
    }
}