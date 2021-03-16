using System;
using System.Collections.Generic;
using Originacion.Models.Personas;
using Originacion.Models.General;

namespace Originacion.Models.Solicitudes
{
    public partial class DatosDomiciliacion : OriginaBase
    {
        public int IdDomiciliacion { get; set; }
        public int IdDatoBancario { get; set; }
        public int? IdCredito { get; set; }
        public int? IdPersona { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string CodEstatusDomiciliacion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DatosBancarios DatosBancarios { get; set; }
    }
}
