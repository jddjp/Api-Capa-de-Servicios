using System;
using System.Collections.Generic;

namespace Originacion.Models.Personas
{
    public partial class DatosBancarios
    {
        public int IdDatoBancario { get; set; }
        public int? IdPersona { get; set; }
        public int? IdInstFinanciera { get; set; }
        public string CodTipoCuentaBancaria { get; set; }
        public string TarjetaDebito { get; set; }
        public string CuentaBancaria { get; set; }
        public string Clabe { get; set; }
        public string Celular { get; set; }
        public string NumCtaBancaria { get; set; }
        public string CodEstatusCuenta { get; set; }
        public string TitularCuenta { get; set; }
    }
}
