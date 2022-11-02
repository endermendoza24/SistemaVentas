using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class DetalleCompra
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        [Required]
        public int ArticuloId { get; set; }
        [ForeignKey("ArticuloId")]
        public Articulo Articulo { get; set; }
        [Required]
        [Range(1, 99999999, ErrorMessage = "Valor inválido")]
        public int Cantidad { get; set; }


       
       [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal PrecioMayorista { get; set; }


        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal PrecioUnitario { get; set; }
        public decimal SubTotal => PrecioMayorista * Cantidad;


        [Required]
        public int CompraId { get; set; }
        [ForeignKey("CompraId")]
        public Compra Compra { get; set; }
        #endregion

        #region MÉTODOS
        public void CalcularUnitario(int porcentaje)
        {
            PrecioUnitario = ((PrecioMayorista) + (porcentaje * PrecioMayorista) / 100);
        }
        #endregion
    }
}
