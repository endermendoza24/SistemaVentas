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
        [Required(ErrorMessage = "No puede dejar este campo {0} vacio")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]

        public string NombreSistema { get; set; }
        [Required(ErrorMessage = "No puede dejar este campo {0} vacio")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]
        public string NombrePropietario { get; set; }
        [Required(ErrorMessage = "No puede dejar este campo {0} vacio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "No puede dejar este campo {0} vacio")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]
        [Phone(ErrorMessage = "Este no es un número telefónico válido")]
        public string Telefono { get; set; }
        
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres")]
        [EmailAddress(ErrorMessage = "La proporcionada no es una dirección de correo válida")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "No puede dejar este campo {0} vacio")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]
        public string RUC { get; set; }

    }
}
