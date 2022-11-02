using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Configuracion
    {
        [Key]
        public int Id { get; set; }
        [Required]
         [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Máximo 50 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]

        public string NombreSistema { get; set; }

        [Required]
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Máximo 50 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string NombrePropietario { get; set; }
        
       
        [Required]
        [StringLength(200)]
        [MaxLength(200, ErrorMessage = "Máximo 200 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "No puede dejar este campo {0} vacio")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        [Phone(ErrorMessage = "Este no es un número telefónico válido")]
        public string Telefono { get; set; }
        
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        [EmailAddress(ErrorMessage = "La proporcionada no es una dirección de correo válida")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "No puede dejar este campo {0} vacio")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres")]
        public string RUC { get; set; }

    }
}
