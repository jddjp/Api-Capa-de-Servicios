using System;
using System.Collections.Generic;
using Originacion.Models.General;

namespace Originacion.Models.Personas
{
    public class PersonaRelacionPersona : OriginaBase
    {
        public int? IdPersona { get; set; }
        public string? CodRelPersPers { get; set; }
        public int? IdPersonaRel { get; set; }
        public DateTime? FechaVigDesde { get; set; }
        public DateTime? FechaVigHasta { get; set; }
        public string? IndVigRel { get; set; }
    }
}
