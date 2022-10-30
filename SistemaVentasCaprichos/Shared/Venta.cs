
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Venta
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        [Required, EnumDataType(typeof(FormasPago))]
        public FormasPago FormaPago { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();
        [Range(1, 99999999, ErrorMessage = "Seleccione cliente")]
        public int? ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        public string EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public decimal Total { get; set; }
        #endregion
    }

    public enum FormasPago
    {
        Cordoba = 1,
        Dolar = 2
    }


}
