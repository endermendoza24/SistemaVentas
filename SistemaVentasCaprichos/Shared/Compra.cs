﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class Compra
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();            
        public decimal Total { get; set; }
        public int? ProveedoresId { get; set; }
        [ForeignKey("ProveedoresId")]
        public Proveedores Proveedores { get; set; }
        #endregion
    }

   
}
