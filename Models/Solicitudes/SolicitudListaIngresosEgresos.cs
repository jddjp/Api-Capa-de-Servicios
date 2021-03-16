using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Solicitudes
{
    public class SolicitudListaIngresosEgresos : OriginaBase
    {
        private List<SolicitudIngresoEgreso> _itemSolicitudIngresoEgreso = new List<SolicitudIngresoEgreso>();

        public List<SolicitudIngresoEgreso> ListaIngresosEgresos
        {
            get { return _itemSolicitudIngresoEgreso; }
            set { _itemSolicitudIngresoEgreso = value; }
        }
    }
}
