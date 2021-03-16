using System;
using System.Collections.Generic;
using System.Linq;
using Originacion.Models.General;
using Originacion.Models.Incidencias;

namespace Originacion.Models.Incidencias
{
    public class ListaExpTicketsTrack : OriginaBase
    {
        private List<ExpTicketsTrack> _listaExpTicketsTrack = new List<ExpTicketsTrack>();

        public List<ExpTicketsTrack> ListadoExpTicketsTrack
        {
            get { return _listaExpTicketsTrack; }
            set { _listaExpTicketsTrack = value; }
        }

    }
}
