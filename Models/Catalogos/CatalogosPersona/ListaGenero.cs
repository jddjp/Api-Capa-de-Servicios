using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosPersona
{
    public class ListaGenero : OriginaBase
    {
        private List<Genero> _listaGeneros = new List<Genero>();

        public List<Genero> ListadoGeneros
        {
            get { return _listaGeneros; }
            set { _listaGeneros = value; }
        }
    }
}
