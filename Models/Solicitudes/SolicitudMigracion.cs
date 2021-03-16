using Originacion.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Solicitudes
{
    public class SolicitudMigracion : OriginaBase
    {
        public int IdCotizacion { get; set; }
        public int IdUsuario { get; set; }
        public int IdCredito { get; set; }

    }
}
