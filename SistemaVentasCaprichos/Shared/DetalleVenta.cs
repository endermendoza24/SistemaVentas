using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class DetalleVenta
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        [Required]
        public int ArticuloId { get; set; }
        [ForeignKey("ArticuloId")]
        public Articulo Articulo { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }

        [Required]

        public int Descuento { get; set; } = 0;

        public decimal SubTotal => Precio * Cantidad;
        public decimal IvaAlternativo => SubTotal * (15M / 100M);
        public decimal Iva => SubTotal + (SubTotal * (15M / 100M));
        
        public decimal SubTotalConDescuento => Iva - ((SubTotal) * (Descuento / 100M));
        

        //public decimal Iva => (Precio * Cantidad) + (Precio * Cantidad * (15M / 100M)); // 460
        //public decimal SubTotal => Iva - ((Precio * Cantidad) * (Descuento / 100M)); // 420
        [Required]
        public int VentaId { get; set; }
        [ForeignKey("VentaId")]
        public Venta Venta { get; set; }

        //  conectando para hacer la devolucion
        public List<Retornos> Retorno { get; set; } = new List<Retornos>();

        #endregion
    }
}
