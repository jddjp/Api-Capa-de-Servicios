using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.Catalogos.CatalogosDomicilios;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosDomicilios
{
    public class ListaMunicipios : OriginaBase
    {
        private List<Municipio> _listaMunicipios = new List<Municipio>();

        public List<Municipio> Municipios
        {
            get { return _listaMunicipios; }
            set { _listaMunicipios = value; }
        }
    }
}
