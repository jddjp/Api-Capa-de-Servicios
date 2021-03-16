using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;
using Originacion.Models.Catalogos.CatalogosDomicilios;

namespace Originacion.Models.Catalogos.CatalogosDomicilios
{
    public class ListaTipoDomicilio : OriginaBase
    {
        private List<TipoDomicilio> _listaTipoDomicilio = new List<TipoDomicilio>();

        public List<TipoDomicilio> TipoDomicilios 
        {
            get { return _listaTipoDomicilio; }
            set { _listaTipoDomicilio = value; }
        }
    }
}
