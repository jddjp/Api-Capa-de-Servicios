using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Solicitudes
{
    public class SolicitudIngresoEgreso
    {
        public int IDCreditoIngresoEgreso { get; set; }
        public int IDCredito { get; set; }
        public string Cod_Tipo_IngEgr { get; set; }
        public string Cod_Origen { get; set; }
        public int IdConcepto { get; set; }
        public double Importe { get; set; }
        public string Ind_Incluye_PDD { get; set; }
        public string Ind_Incluye_CDP { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Observaciones { get; set; }
        public string Nombre_Concepto { get; set; }

    }
}
