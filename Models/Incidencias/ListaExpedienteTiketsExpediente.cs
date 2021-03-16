using System;
using System.Collections.Generic;
using System.Linq;
using Originacion.Models.General;

namespace Originacion.Models.Incidencias
{
    public class ListaExpedienteTiketsExpediente : OriginaBase
    {
        private List<ExpedienteTiketsExpediente> _listaExpedienteTiketsExpediente = new List<ExpedienteTiketsExpediente>();

        public List<ExpedienteTiketsExpediente> ListadoExpedienteTiketsExpediente
        {
            get { return _listaExpedienteTiketsExpediente; }
            set { _listaExpedienteTiketsExpediente = value; }
        }

    }
}
