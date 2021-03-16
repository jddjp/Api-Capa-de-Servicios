using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Catalogos
{
    public class IngresosEgresos
    {
        public int IdConceptoIE {get;set;}
        public string CodTipoIE { get; set; }
        public string Nombre { get; set; }
        public double MontoMaximo { get; set; }
        public string CodCategproaIngresoEgreso { get; set; }
        public bool RequiereEgresosMismoGrupo { get; set; }
        public double TopeMaximo { get; set; }
    }
}
