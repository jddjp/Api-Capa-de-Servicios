using System;
using System.Collections.Generic;
using Originacion.Models.General;

namespace Originacion.Models.Incidencias
{
    public class ExpedienteTiketsExpediente : OriginaBase
    {
        public int IdTicketExpediente { get; set; }
        public int CodClasificacionTicket { get; set; }
        public int IdExpediente { get; set; }
        public string CodTipoTramite { get; set; }
        public int? IdReferencia { get; set; }
        public string CodRequisito { get; set; }
        public string Descripcion { get; set; }
        public string CodEcvTicket { get; set; }
        public string CodTipoOrigenTicket { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaUltCambio { get; set; }
        public string DescripcionClasificacion { get; set; }
        public string Mensaje_Atencion { get; set; }
        public string NombreClasificacion { get; set; }
        public string NombreRequisito { get; set; }
        public string NombreEstatus { get; set; }
    }
}
