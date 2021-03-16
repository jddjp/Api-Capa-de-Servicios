using System;
using System.Collections.Generic;

namespace Originacion.Models.Catalogos
{
    public partial class SubTipoEmpleado
    {
        public string CodTipoEmpleado { get; set; }
        public string CodSubTipoEmpleado { get; set; }
        public string NomSubTipoEmpleado { get; set; }
        public int? IndActivo { get; set; }
    }
}
