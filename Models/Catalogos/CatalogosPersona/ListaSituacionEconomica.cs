using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public class ListaSituacionEconomica : OriginaBase
    {
        private List<SituacionEconomica> _listaSituacionEconomica = new List<SituacionEconomica>();

        public List<SituacionEconomica> ListadoSituacionEconomica
        {
            get { return _listaSituacionEconomica; }
            set { _listaSituacionEconomica = value; }
        }
    }
}
