using System;
using System.Collections.Generic;
using System.Linq;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosIncidencias
{
    public class ListaRequisitoClasificacionTikets : OriginaBase
    {
        private List<RequisitoClasificacionTikets> _listaRequisitoClasificacionTikets = new List<RequisitoClasificacionTikets>();

        public List<RequisitoClasificacionTikets> ListadoRequisitoClasificacionTikets
        {
            get { return _listaRequisitoClasificacionTikets; }
            set { _listaRequisitoClasificacionTikets = value; }
        }

    }
}
