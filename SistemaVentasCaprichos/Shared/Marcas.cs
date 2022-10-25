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
        [MaxLength(30, ErrorMessage = "Máximo 30 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Nombre { get; set; }        
        [MaxLength(100, ErrorMessage = "Máximo 100 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Descripcion { get; set; }

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        public bool Estado { get; set; } = true;

        #endregion
    }
}