using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Convenios
{
    public class Convenio
    {
        public int IdConvenio { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string  IndicadorVigencia { get; set; }
        public string Cod_Convenio { get; set; }
        public string Cod_ECV_Cnv { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
    }
}
