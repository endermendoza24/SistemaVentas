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
         [StringLength(30)]
        [MaxLength(30, ErrorMessage = "Máximo 30 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Nombre { get; set; }


        [Required]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres"), MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        [Phone]
        public string Telefono { get; set; }
       
        [StringLength(500)]
        [MaxLength(500, ErrorMessage = "Máximo 500 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Direccion { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres"), MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public bool Estado { get; set; } = true;

        #endregion
    }
}