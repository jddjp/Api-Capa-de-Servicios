using System;
using System.Collections.Generic;

namespace Originacion.Models.Convenios
{
    public partial class Dependencia
    {
        public int IdDependencia { get; set; }
        public int IdConvenio { get; set; }
        public string CveDependencia { get; set; }
        public string Nombre { get; set; }
        public int? Estatus { get; set; }
    }
}
