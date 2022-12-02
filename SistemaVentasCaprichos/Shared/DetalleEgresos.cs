using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class DetalleEgresos
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor inválido")]
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
       
        [Required]
        public int EgresosId { get; set; } 
        [ForeignKey("EgresosId")]
        public Egresos Egresos { get; set; }
        #endregion
    }
}
