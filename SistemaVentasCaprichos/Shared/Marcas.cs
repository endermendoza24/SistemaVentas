using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SistemaVentasCaprichos.Shared
{
    public class Marcas
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }

        
        [Required]
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Máximo 50 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Nombre { get; set; } 
             
        [StringLength(200)]
        [MaxLength(200, ErrorMessage = "Máximo 200 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Descripcion { get; set; }

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        public bool Estado { get; set; } = true;

        #endregion
    }
}