using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Solicitudes
{
    public class SolicitudLista : OriginaBase
    {
        private List<SolicitudItemLista> _itemListaSolicitudes = new List<SolicitudItemLista>();

        public List<SolicitudItemLista> listaSolicitudes
        {
            get { return _itemListaSolicitudes; }
            set { _itemListaSolicitudes = value;  }
        }
    }
}
