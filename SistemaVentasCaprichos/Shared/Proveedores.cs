using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SistemaVentasCaprichos.Shared
{
    public class Proveedores
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres"), MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres"), MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        [Phone]
        public string Telefono { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres"), MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Direccion { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public bool Estado { get; set; } = true;

        #endregion
    }
}