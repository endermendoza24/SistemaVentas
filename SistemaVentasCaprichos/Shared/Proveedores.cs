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

       [Required]
         [StringLength(200)]
        [MaxLength(200, ErrorMessage = "Máximo 200 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Direccion { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public bool Estado { get; set; } = true;

        #endregion
    }
}