﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasCaprichos.Shared
{
    public class CuentaCorriente
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        public int? ComprobanteId { get; set; }
        public Conceptos Concepto { get; set; }
        public decimal Importe { get; set; }
        public decimal Saldo_Parcial { get; set; }
        #endregion

        public enum Conceptos
        {
            Debe = 1,
            Haber = 2,
            Reajuste = 3
        }
    }
}
