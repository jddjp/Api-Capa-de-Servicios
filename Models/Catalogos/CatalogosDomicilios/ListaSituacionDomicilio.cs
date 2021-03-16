using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.Catalogos.CatalogosDomicilios;
using Originacion.Models.General;


namespace Originacion.Models.Catalogos.CatalogosDomicilios
{
    public class ListaSituacionDomicilio : OriginaBase
    {
        private List<SituacionDomicilio> _listaSituacionDomicilio = new List<SituacionDomicilio>();

        public List<SituacionDomicilio> SituacionesDomicilio
        {
            get { return _listaSituacionDomicilio; }
            set { _listaSituacionDomicilio = value; }
        }
    }
}
