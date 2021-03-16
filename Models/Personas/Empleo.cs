using System;
using System.Collections.Generic;
using Originacion.Models.General;

namespace Originacion.Models.Personas
{
    public partial class Empleo : OriginaBase
    {
        public int IdEmpleo { get; set; }
        public int IdConvenio { get; set; }
        public int IdPersona { get; set; }
        public int IdDependencia { get; set; }
        public int IdArea { get; set; }
        public string NombreDependencia { get; set; }
        public string DependenciaEmpresa { get; set; }
        public string NombreArea { get; set; }
        public string Puesto { get; set; }
        public string CodTipoEmpleado { get; set; }
        public string CodSubTipoEmpleado { get; set; }
        public string ClaveEmpleado { get; set; }
        public string JefeInmediato { get; set; }
        public decimal? Sueldo { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public int? IndActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaUltCambio { get; set; }
    }
}
