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
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "Máximo 100 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string Nombre { get; set; }

        [StringLength(500)]
        [MaxLength(500, ErrorMessage = "Máximo 500 dígitos"), MinLength(2, ErrorMessage = "Minimo 2 dígitos")]
        public string? Descripcion { get; set; }
        
        public string? Url_Imagen { get; set; }      

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal PrecioMayorista { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal PrecioUnitario { get; set; }

        public DateTime Ultima_Modificación { get; set; }
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [Required]
        public string? Codigo { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Valor inválido")]
        public int StockMinimo { get; set; } = 7;
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Valor inválido")]
        public int StockActual { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Valor inválido")]
        public int StockMaximo
        { get { return  StockMaximo = StockActual; } // le agrega una unidad más al stock actual en la casilla de stock máximo
            set { }
        }

        public bool Estado { get; set; } = true;

        // conexión a categorías
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categorias { get; set; }
        // conexion a tallas
        public int TallasId { get; set; }
        [ForeignKey("TallasId")]
        public Tallas Tallas { get; set; }
        //  conexión a Marcas
        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]
        public Marcas Marca { get; set; }

      


        #endregion

        #region MÉTODOS
        public void CalcularUnitario(int porcentaje)
        {
            PrecioUnitario = ((PrecioMayorista) + (porcentaje * PrecioMayorista) / 100);
        }
        #endregion
    }
}