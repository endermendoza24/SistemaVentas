using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Articulo
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
       
        public string? Descripcion { get; set; }
        public string? Url_Imagen { get; set; }
        [Required]
        [Range(1, 99999999, ErrorMessage = "Valor inválido")]
        public decimal PrecioMayorista { get; set; }
        [Required]
        [Range(1, 99999999, ErrorMessage = "Valor inválido")]
        public decimal PrecioUnitario { get; set; }
        public DateTime Ultima_Modificación { get; set; }
        [Required]
        [Range(1, 99999999, ErrorMessage = "Valor inválido")]
        public int StockMinimo { get; set; }
        [Required]
        [Range(1, 99999999, ErrorMessage = "Valor inválido")]
        public int StockMaximo { get; set; }
        [Required]
        [Range(0, 99999999, ErrorMessage = "Valor inválido")]
        public int StockActual { get; set; }
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categorias { get; set; }

      
        #endregion

        #region MÉTODOS
        public void CalcularUnitario(int porcentaje)
        {
            PrecioUnitario = ((PrecioMayorista) + (porcentaje * PrecioMayorista) / 100);
        }
        #endregion
    }
}
