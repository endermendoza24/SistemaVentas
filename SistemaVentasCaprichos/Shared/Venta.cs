using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Venta
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }

        // [Required, EnumDataType(typeof(FormasPago))]
        public FormasPago FormaPago { get; set; } = FormasPago.Cordoba;
        public List<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione cliente")]
        public int? ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        public string EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal Total { get; set; }
        #endregion
    }

    public enum FormasPago // segun los requerimientos del cliente solo se aceptara córdoba como moneda de pago
    {
        Cordoba = 1
    }


}
