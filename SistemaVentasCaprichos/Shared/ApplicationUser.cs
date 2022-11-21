using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class ApplicationUser : IdentityUser
    {
        public string NombreyApellido { get; set; }
        public string Apellido { get; set; }
        public virtual List<Venta> Ventas { get; set; }
        //public virtual List<Pago> Pagos { get; set; }
        public virtual List<Compra> Compras { get; set; }
    }
}
