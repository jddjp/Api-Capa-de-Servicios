using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public class ListaEstadoCivil : OriginaBase
    {
        private List<EstadoCivil> _listaEstadoCivil = new List<EstadoCivil>();

        public List<EstadoCivil> ListadoEstasdosCiviles
        {
            get { return _listaEstadoCivil; }
            set { _listaEstadoCivil = value; }
        }
    }
}
