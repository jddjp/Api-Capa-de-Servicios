using System;
using System.Collections.Generic;

namespace Originacion.Models.Personas
{
    public partial class DirElectronica
    {
        public int IdDireccionElectronica { get; set; }
        public string CodDirElectronica { get; set; }
        public int? IdPersona { get; set; }
        public string PrefijoNacional { get; set; }
        public short? CodigoArea { get; set; }
        public string TxtDireccion { get; set; }
        public string Extension { get; set; }
        public string Observacion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public string CodEcvDireccion { get; set; }
        public DateTime? FechaUltAccion { get; set; }
        public string CodUltAccion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? ValidoDesde { get; set; }
        public DateTime? ValidoHasta { get; set; }
        public DateTime? FechaUltCambio { get; set; }
        public short? Version { get; set; }
        public string Prioridad { get; set; }
        public string TipoDirelectronica { get; set; }
    }
}
