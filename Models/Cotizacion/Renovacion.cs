using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Cotizacion
{
    public class Renovacion
    {
        public int IdCotizacion { get; set; }
        public int IdPersona { get; set; }
        public int Id_Disposicion { get; set; }
        public string Clave_Disposicion { get; set; }
        public decimal Importe { get; set; }
        public decimal Saldo_Insoluto { get; set; }
        public decimal Monto_Dispersar { get; set; }
        public System.DateTime Fecha_Alta { get; set; }
        public System.DateTime Fecha_Vencimiento { get; set; }
        public string Pagare { get; set; }
        public int Prospecto { get; set; }
        public int Id_Cotizacion_Renovacion { get; set; }
    }
}
