﻿using Microsoft.AspNetCore.Authorization;
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
    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ClientesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //GET: api/clientes
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            return await context.Clientes.
                Where(x => x.Estado == true)
              .OrderBy(x => x.Nombre).ToListAsync();
        }

        //GET: api/clientes/filtro/nombre
        [HttpGet("filtro")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Cliente>>> Get([FromQuery] string nombre)
        {
            var queryable = context.Clientes.Where(x => x.Estado == true).OrderBy(x => x.Nombre).AsQueryable();
            if (!string.IsNullOrEmpty(nombre))
            {
                queryable = queryable.Where(x => x.Nombre.Contains(nombre));
            }
            return await queryable.ToListAsync();
        }
        //GET: api/clientes/filtro/nombre
        [HttpGet("bajas")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Cliente>>> GetBajas([FromQuery] string nombre)
        {
            var queryable = context.Clientes.Where(x => x.Estado != true).OrderBy(x => x.Nombre).AsQueryable();
            if (!string.IsNullOrEmpty(nombre))
            {
                queryable = queryable.Where(x => x.Nombre.Contains(nombre));
            }
            return await queryable.ToListAsync();
        }

        // GET: api/clientes/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Cliente>> Get(int id)
        {
            return await context.Clientes.FirstAsync(x => x.Id == id);
        }

        // POST: api/clientes 
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Post(Cliente cliente)
        {
            if (!Exists(cliente.Cedula))
            {
                context.Clientes.Add(cliente);
                await context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }

        // PUT: api/clientes
        [HttpPut]
        [AllowAnonymous]
        public async Task<ActionResult> Put(Cliente cliente)
        {
            context.Entry(cliente).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/clientes/5  
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Cliente>> Delete(int id)
        {
            var cliente = await context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            context.Clientes.Remove(cliente);
            await context.SaveChangesAsync();

            return cliente;
        }

        private bool Exists(string cedula)
        {
            return (context.Clientes.Any(e => e.Cedula == cedula));
        }
    }
}