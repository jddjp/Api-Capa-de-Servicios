using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public class ListaEstadoOcupacion : OriginaBase
    {
        private List<EstadoOcupacion> _listaEstadosOcupaciones = new List<EstadoOcupacion>();

        public List<EstadoOcupacion> ListadoEstasdosOcupaciones
        {
            get { return _listaEstadosOcupaciones; }
            set { _listaEstadosOcupaciones = value; }
        }
    }
}
