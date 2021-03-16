using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public class ListaRelacionPersonas : OriginaBase
    {
        private List<RelacionPersonas> _listaRelacionPersonas = new List<RelacionPersonas>();

        public List<RelacionPersonas> ListadoRelacionesPersonas
        {
            get { return _listaRelacionPersonas; }
            set { _listaRelacionPersonas = value; }
        }
    }
}
