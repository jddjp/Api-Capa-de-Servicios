using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Expediente
{
    public class ListaExpedienteTipoComprobante : OriginaBase
    {
        private List<ExpedienteTipoComprobante> _listaExpedienteTipoComprobante = new List<ExpedienteTipoComprobante>();

        public List<ExpedienteTipoComprobante> ListaExpedienteTiposComprobante
        {
            get { return _listaExpedienteTipoComprobante; }
            set { _listaExpedienteTipoComprobante = value; }
        }
    }
}
