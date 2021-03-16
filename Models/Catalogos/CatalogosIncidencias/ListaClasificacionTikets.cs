using System;
using System.Collections.Generic;
using System.Linq;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosIncidencias
{
    public class ListaClasificacionTikets : OriginaBase
    {
        private List<ClasificacionTikets> _listaClasificacionTikets = new List<ClasificacionTikets>();

        public List<ClasificacionTikets> ListadoClasificacionTikets
        {
            get { return _listaClasificacionTikets; }
            set { _listaClasificacionTikets = value; }
        }

    }
}
