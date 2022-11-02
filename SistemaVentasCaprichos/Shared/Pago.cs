using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Pago
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        [Range(1, 99999999, ErrorMessage = "Seleccione cliente")]
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        [Range(1, 99999999, ErrorMessage = "Seleccione cliente")]
        public Cliente Cliente { get; set; }


        public string EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public virtual ApplicationUser ApplicationUser { get; set; }


        [Required]          
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Máximo 50 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Concepto { get; set; }


        [Required, EnumDataType(typeof(FormasPago))]
        public FormasPago FormaPago { get; set; }


        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal Importe { get; set; }

        public enum FormasPago
        {
            Efectivo = 1,
            MercadoPago = 2,
            Cheque = 3,
            Transferencia = 4
        }
        #endregion
    }
}
