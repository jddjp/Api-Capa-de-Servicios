using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public class ListaPais : OriginaBase
    {
        private List<Pais> _listaPaises = new List<Pais>();

        public List<Pais> ListadoPaises
        {
            get { return _listaPaises; }
            set { _listaPaises = value; }
        }
    }
}
