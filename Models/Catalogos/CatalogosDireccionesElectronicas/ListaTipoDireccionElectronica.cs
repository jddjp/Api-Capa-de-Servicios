using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos.CatalogosDireccionesElectronicas
{
    public class ListaTipoDireccionElectronica : OriginaBase
    {
        private List<TipoDireccionElectronica> _tipoDireccionElectronicas = new List<TipoDireccionElectronica>();

        public List<TipoDireccionElectronica> ListaTiposDireccion
        {
            get { return _tipoDireccionElectronicas; }
            set { _tipoDireccionElectronicas = value; }
        }
    }
}
