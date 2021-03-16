using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.Cotizacion;
using Originacion.Models.General;

namespace Originacion.Models.Solicitudes
{
    public class SolicitudListaRenovacion : OriginaBase
    {
        private List<SolicitudRenovacion> _itemListaSolicitudesRenovacion = new List<SolicitudRenovacion>();

        public List<SolicitudRenovacion> ListaRenovaciones
        {
            get { return _itemListaSolicitudesRenovacion; }
            set { _itemListaSolicitudesRenovacion = value; }
        }
    }
}
