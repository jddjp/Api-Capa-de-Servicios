using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Personas
{
    public class ListaDirElectronica : OriginaBase
    {
        private List<DirElectronica> _itemListaDirElectronica = new List<DirElectronica>();

        public List<DirElectronica> ListaDireccionesElectronicas
        {
            get { return _itemListaDirElectronica; }
            set { _itemListaDirElectronica = value; }
        }
    }
}
