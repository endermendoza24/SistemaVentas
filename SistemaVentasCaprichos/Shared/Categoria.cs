using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SistemaVentasCaprichos.Shared
{
    public class Categoria
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Máximo 30 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Nombre { get; set; }
        
        [StringLength(300)]
        [MaxLength(300, ErrorMessage = "Máximo 300 caracteres"), MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string? Descripcion { get; set; }


        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public bool Estado { get; set; } = true;
        #endregion
    }
}