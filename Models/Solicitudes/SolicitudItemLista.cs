using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Solicitudes
{
    public class SolicitudItemLista
    {
        public int IdCredito { get; set; }
        public string Nombre { get; set; }
        public double Importe { get; set; }
        public string FrecPago { get; set; }
        public string FrecPagoNombre { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Prim_Liq { get; set; }
        public string Estatus { get; set; }
        public string Etapa { get; set; }
        public int Incidencias { get; set; }

    }
}
