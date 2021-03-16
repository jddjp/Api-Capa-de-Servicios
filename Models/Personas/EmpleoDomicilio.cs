using System;
using System.Collections.Generic;
using Originacion.Models.General;

namespace Originacion.Models.Personas
{
    public partial class EmpleoDomicilio : OriginaBase
    {
    
        public int IdDireccion { get; set; }
        public int IdEmpleo { get; set; }
        public bool? IndCatalogado { get; set; }
        public int? IdColonia { get; set; }
        public int? IdDelegacion { get; set; }
        public int? IdMunicipio { get; set; }
        public short? IdEdoRegion { get; set; }
        public short? CodPaisIso { get; set; }
        public string CodTipoDomicilio { get; set; }
        public string CodSituacionDomicilio { get; set; }
        public string Calle { get; set; }
        public string NumeroExt { get; set; }
        public string NumeroInt { get; set; }
        public string UnidadHabitacional { get; set; }
        public string Edificio { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string Casa { get; set; }
        public string Lote { get; set; }
        public string Manzana { get; set; }
        public int? CodigoPostal { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Delegacion { get; set; }
        public string Municipio { get; set; }
        public string EdoRegion { get; set; }
        public string Pais { get; set; }
        public string EntreCalles { get; set; }
        public string CodEcvDireccion { get; set; }
        public DateTime? FechaUltAccion { get; set; }
        public string CodUltAccion { get; set; }
        public string TipoDomicilio { get; set; }
        public string SituacionDomicilio { get; set; }
        public DateTime? FechaInicioResidencia { get; set; }
        public DateTime? FechaFinResidencia { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaValidoDesde { get; set; }
        public DateTime? FechaValidoHasta { get; set; }
        public DateTime? FechaUltCambio { get; set; }
        public short? Version { get; set; }
        public string Prioridad { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
    }
}
