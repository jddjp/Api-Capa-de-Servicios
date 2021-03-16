using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Cotizacion
{
    public class CotizaIngresosEgresos
    {
        public int IdCotizaIngresosEgresos { get; set; }
        public int IdCotizacion { get; set; }
        public string Cod_Tipo_IngEgr { get; set; }
        public string Cod_Origen { get; set; }
        public int IdConcepto { get; set; }
        public double Importe { get; set; }
        public string Ind_Incluye_PDD { get; set; }
        public string Ind_Incluye_CDP { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Observaciones { get; set; }

    }
}
