﻿using Microsoft.AspNetCore.Mvc;
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
    public class TallasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public TallasController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Tallas>>> Get()
        {
            return await context.Tallas
                 .Where(x => x.Estado == true) // a través de este where solo se muestran en pantalla los que tengan un estado true
                .ToListAsync();
        }
        [HttpGet("bajas")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Tallas>>> GetBajas()
        {
            return await context.Tallas
                 .Where(x => x.Estado == false) 
                .ToListAsync();
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Tallas>> Get(int id)
        {
            return await context.Tallas.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpGet("buscar/{textoBusqueda}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Tallas>>> Get(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda)) { return new List<Tallas>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await context.Tallas
            .Where(x => x.Nombre.ToLower().Contains(textoBusqueda)).ToListAsync();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<int>> Post(Tallas Tallas)
        {

            context.Add(Tallas);
            await context.SaveChangesAsync();
            return Tallas.Id;
        }
        [HttpPut]
        [AllowAnonymous]
        public async Task<ActionResult> Put(Tallas Tallas)
        {
            context.Attach(Tallas).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Tallas.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Tallas { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}