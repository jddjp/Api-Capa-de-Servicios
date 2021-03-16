using System;
using System.Collections.Generic;
using Originacion.Models.General;

namespace Originacion.Models.Incidencias
{
    public partial class ExpTicketsTrack : OriginaBase
    {
        public int IdEvento { get; set; }
        public int IdTicketExpediente { get; set; }
        public string Descripcion { get; set; }
        public string CodTipoEveno { get; set; }
        public string CodTipoOrigenTicket { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? IndAtendido { get; set; }
    }
}
