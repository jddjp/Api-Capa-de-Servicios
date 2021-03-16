using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.Catalogos.CatalogosDomicilios;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosDomicilios
{
    public class ListaEstadoRegion : OriginaBase
    {
        private List<EdoRegion> _listaEstados = new List<EdoRegion>();

        public List<EdoRegion> Estados
        {
            get { return _listaEstados; }
            set { _listaEstados = value; }
        }
    }
}
