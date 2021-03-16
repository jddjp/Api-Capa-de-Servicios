using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Expediente
{
    public class ExpedienteRequisito
    {
        public string CodTipoPersona { get; set; }
        public string CodTipoTramite { get; set; }
        public string TipoSubExpediente { get; set; }
        public string CodRequisito { get; set; }
        public string Nombre { get; set; }
        public int? IdExpediente { get; set; }
        public int? IDReferencia { get; set; }
        public string? CodTipoComprobante { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaValidoHasta {get;set;}
        public string? CodECVRequisito { get; set; }
        public string? URL { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? IdDocumento { get; set; }
    }
}
