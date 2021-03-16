using System;
using System.Collections.Generic;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public partial class PaisNacionalidad
    {
        public int IdNacionalidad { get; set; }
        public string Nombre { get; set; }
        public string ClaveNacionalidad { get; set; }
        public short? Orden { get; set; }
        public short CodPaisIso { get; set; }
    }
}
