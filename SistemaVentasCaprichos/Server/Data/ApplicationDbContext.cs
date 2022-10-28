
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SistemaVentasCaprichos.Server;
using SistemaVentasCaprichos.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }               
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Tallas> Tallas { get; set; }
        public DbSet<Marcas> Marca { get; set; }

        public DbSet<Proveedores> Proveedores { get; set; }
       
    }
}
