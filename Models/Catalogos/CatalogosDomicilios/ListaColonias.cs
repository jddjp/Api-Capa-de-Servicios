using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;
using Originacion.Models.Catalogos.CatalogosDomicilios;

namespace Originacion.Models.Catalogos.CatalogosDomicilios
{
    public class ListaColonias : OriginaBase
    {
        private List<Colonia> _listaColonias = new List<Colonia>();

        public List<Colonia> Colonias
        {
            get { return _listaColonias; }
            set { _listaColonias = value; }
        }
    }
}
