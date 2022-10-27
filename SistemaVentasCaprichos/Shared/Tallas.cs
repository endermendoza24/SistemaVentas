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
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public bool Estado { get; set; } = true;
    }
}
