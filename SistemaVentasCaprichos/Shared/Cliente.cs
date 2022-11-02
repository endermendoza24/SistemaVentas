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
        [Required]
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Máximo 50 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string NombreyApellido { get; set; }
        [Required]
        [StringLength(16)]
        [MaxLength(16, ErrorMessage = "Máximo 16 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        // buscar algún regex de cédula
        public string Cedula { get; set; }
        [Required, EnumDataType(typeof(Sexos))]

        
        public Sexos Sexo { get; set; }
        [Required]
        [StringLength(200)]
        [MaxLength(200, ErrorMessage = "Máximo 200 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Dirección { get; set; }
        [Required]
        [StringLength(20)]
        [MaxLength(20, ErrorMessage = "Máximo 20 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        [Phone(ErrorMessage = "Sólo números")]
        public string Teléfono { get; set; }

        
        public decimal Saldo { get; set; }
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
