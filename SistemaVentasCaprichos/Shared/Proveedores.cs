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
        [MaxLength(30, ErrorMessage = "Máximo 30 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Máximo 50 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public int Teléfono { get; set; }

        [Required]
        public string Dirección { get; set; }

        public Boolean Estado { get; set; }

        #endregion
    }
}