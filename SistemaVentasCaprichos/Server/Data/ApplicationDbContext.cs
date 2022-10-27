using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
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
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<CuentaCorriente> CuentasCorrientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Tallas> Tallas { get; set; }
        public DbSet<Marcas> Marca { get; set; }

        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }
        //public object Categorias { get; internal set; }
    }
}
