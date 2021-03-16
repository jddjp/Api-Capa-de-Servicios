using System;
using System.Collections.Generic;

namespace Originacion.Models.Convenios
{
    public partial class Area
    {
        public int IdArea { get; set; }
        public string Nombre { get; set; }
        public string? IndVigencia { get; set; }
        public int? IdDependencia { get; set; }
    }
}
