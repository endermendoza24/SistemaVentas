
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Caja
    {
        [Key]
        public int Id { get; set; }
        public decimal Ingresos { get; set; } = 0;
        public decimal Egresos { get; set; } = 0;
        public decimal Saldo { get; set; } = 0;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int IdVenta { get; set; }
        public int IdCompra { get; set; }
    }
}
