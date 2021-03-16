using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public class ListaNivelEstudios : OriginaBase
    {
        private List<NivelEstudios> _listNivelEstudios = new List<NivelEstudios>();

        public List<NivelEstudios> ListadoNivelesEstudios
        {
            get { return _listNivelEstudios; }
            set { _listNivelEstudios = value; }
        }
    }
}
