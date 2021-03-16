using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Expediente
{
    public class ListaExpedienteRequisito : OriginaBase
    {
        private List<ExpedienteRequisito> _listaExpedienteRequisito = new List<ExpedienteRequisito>();

        public List<ExpedienteRequisito> ListaExpedienteRequisitos
        {
            get { return _listaExpedienteRequisito; }
            set { _listaExpedienteRequisito = value; }
        }
    }
}
