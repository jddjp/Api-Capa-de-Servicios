using System;
using System.Collections.Generic;

namespace Originacion.Models.Catalogos.BuroCredito
{
    public partial class CnsBcCuenta
    {
        public int pkCuenta { get; set; }
        public string numeroControlConsulta { get; set; }
        public string fechaActualizacion { get; set; }
        public string nombreOtorgante { get; set; }
        public string tipoCuenta { get; set; }
        public string tipoContrato { get; set; }
        public string numeroPagos { get; set; }
        public string frecuenciaPagos { get; set; }
        public string montoPagar { get; set; }
        public string fechaAperturaCuenta { get; set; }
        public string fechaUltimoPago { get; set; }
        public string fechaUltimaCompra { get; set; }
        public string fechaCierreCuenta { get; set; }
        public string fechaReporte { get; set; }
        public string formaPagoActual { get; set; }
        public string historicoPagos { get; set; }
        public object claveObservacion { get; set; }
        public double pagoMensual { get; set; }
        public string indicador { get; set; }
    }
}
