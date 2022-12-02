using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Egresos
    {

        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        [StringLength(300, ErrorMessage = "Sobrepasado")]
        public string Detalles { get; set; }
        public List<DetalleEgresos> DetalleEgresos { get; set; } = new List<DetalleEgresos>();

        public string EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal Total { get; set; }

        public bool Estado { get; set; } = true;

        #endregion
    }
}
