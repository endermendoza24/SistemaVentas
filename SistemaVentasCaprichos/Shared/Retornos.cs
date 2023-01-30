using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Retornos
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int Cantidad { get; set; }
        public string Motivo { get; set; }

        public decimal Precio { get; set; }
        public int Descuento { get; set; }

        public int DetalleVentaId { get; set; }
        [ForeignKey("DetalleVentaId")]
        public DetalleVenta DetalleVenta { get; set; }


    }

}
