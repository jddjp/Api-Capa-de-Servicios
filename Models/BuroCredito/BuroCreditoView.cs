using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Catalogos.BuroCredito
{
    public class BuroCreditoView
    {

        public string Concepto { get; set; }
        public double Monto_Pago { get; set; }
        public string Frecuencia_Pago { get; set; }
        public string Forma_Pago { get; set; }
        public double Monto_Mensual { get; set; }
        public string Clave_Observacion { get; set; }

    }
}
