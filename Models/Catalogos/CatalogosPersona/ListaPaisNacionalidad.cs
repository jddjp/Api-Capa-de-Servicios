using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public class ListaPaisNacionalidad : OriginaBase
    {
        private List<PaisNacionalidad> _listPaisNacionalidad = new List<PaisNacionalidad>();

        public List<PaisNacionalidad> ListadoPaisesNacionalidad
        {
            get { return _listPaisNacionalidad; }
            set { _listPaisNacionalidad = value; }
        }
    }
}
