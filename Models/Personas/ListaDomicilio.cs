using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.Cotizacion;
using Originacion.Models.General;

namespace Originacion.Models.Personas
{
    public class ListaDomiclio : OriginaBase
    {
        private List<Domicilio> _itemListaDomicilio = new List<Domicilio>();

        public List<Domicilio> ListaDomicilios
        {
            get { return _itemListaDomicilio; }
            set { _itemListaDomicilio = value; }
        }
    }
}
