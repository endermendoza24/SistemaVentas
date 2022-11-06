using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Tallas
    {
        [Key]
        public int Id { get; set; }

         [Required]
         [StringLength(30)]
        [MaxLength(30, ErrorMessage = "Máximo 30 dígitos"), MinLength(1, ErrorMessage = "Minimo 1 dígitos")]
        public string Nombre { get; set; }


        public DateTime Fecha { get; set; } = DateTime.Now;
        public bool Estado { get; set; } = true;
    }
}
