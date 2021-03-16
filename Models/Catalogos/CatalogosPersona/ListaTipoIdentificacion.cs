using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public class ListaTipoIdentificacion : OriginaBase
    {
        private List<TipoIdentificacion> _listaTipoIdentificacion = new List<TipoIdentificacion>();

        public List<TipoIdentificacion> ListadoTipoIdentificacion
        {
            get { return _listaTipoIdentificacion; }
            set { _listaTipoIdentificacion = value; }
        }
    }
}
