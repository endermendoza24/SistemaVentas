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
        [MaxLength(300, ErrorMessage = "Máximo 300 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string NombreyApellido { get; set; }
        [Required]
        [MaxLength(16, ErrorMessage = "Máximo 16 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        // buscar algún regex de cédula
        public string Cedula { get; set; }
        [Required, EnumDataType(typeof(Sexos))]
        public Sexos Sexo { get; set; }
        [Required]
        public string Dirección { get; set; }
        [Required]
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
