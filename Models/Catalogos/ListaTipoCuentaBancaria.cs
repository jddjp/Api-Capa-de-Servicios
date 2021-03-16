using System;
using System.Collections.Generic;
using System.Linq;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos
{
    public class ListaTipoCuentaBancaria : OriginaBase
    {
        private List<TipoCuentaBancaria> _listTipoCuentaBancaria = new List<TipoCuentaBancaria>();

        public List<TipoCuentaBancaria> ListadoTipoCuentaBancaria
        {
            get { return _listTipoCuentaBancaria; }
            set { _listTipoCuentaBancaria = value; }
        }
    }
}
