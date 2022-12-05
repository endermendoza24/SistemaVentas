using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Cliente
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingesar un {0}")]
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Máximo 50 dígitos"), MinLength(1, ErrorMessage = "Mínimo 1 dígitos")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingesar un {0}")]
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Máximo 50 dígitos"), MinLength(1, ErrorMessage = "Mínimo 1 dígitos")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe ingesar una {0}")]
        [StringLength(16)]
        [MaxLength(16, ErrorMessage = "Máximo 16 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        // buscar algún regex de cédula
        [RegularExpression("[0-9]{13}[A-Z]{1}",
            ErrorMessage = "El término introducido no corresponde la formato de cédula nicaragüense")]
        public string Cedula { get; set; }
        [Required, EnumDataType(typeof(Sexos))]        
        public Sexos Sexo { get; set; }
        [Required(ErrorMessage = "Debe ingesar una {0}")]
        [StringLength(300)]
        [MaxLength(300, ErrorMessage = "Máximo 300 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Dirección { get; set; }
        [Required(ErrorMessage = "Debe ingesar un número de {0}")]
        [StringLength(20)]
        [MaxLength(20, ErrorMessage = "Máximo 20 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        [Phone(ErrorMessage = "Sólo números")]
        public string Teléfono { get; set; }                
        public DateTime FechaAlta { get; set; } = DateTime.Now;
        public bool Estado { get; set; } = true;

        public enum Sexos
        {
            Masculino = 1,
            Femenino = 2, 
            No_Especifica = 3
        }
        #endregion
    }
}
