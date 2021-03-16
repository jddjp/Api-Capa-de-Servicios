using System;
using System.Collections.Generic;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public partial class Pais
    {
        public int IdPais { get; set; }
        public short? CodPaisIso { get; set; }
        public string Nombre { get; set; }
        public string Cod3lIso { get; set; }
        public string Cod2lIso { get; set; }
        public int? EstatusPais { get; set; }
        public string ParaisoFiscal { get; set; }
        public string NoCooperante { get; set; }
        public string FechaAlta { get; set; }
        public string FechaUltimaMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Gentilicio { get; set; }
        public string NivelRiesgo { get; set; }
        public string NomMoneda { get; set; }
        public string CodMoneda { get; set; }
    }
}
