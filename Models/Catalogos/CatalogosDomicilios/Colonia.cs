using System;
using System.Collections.Generic;

namespace Originacion.Models.Catalogos.CatalogosDomicilios
{
    public partial class Colonia
    {
        public int IdColonia { get; set; }
        public string Nombre { get; set; }
        public int IdMunicipio { get; set; }
        public string Cp { get; set; }
        public int? CodEstatusColonia { get; set; }
    }
}
