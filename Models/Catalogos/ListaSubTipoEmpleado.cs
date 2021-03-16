using System;
using System.Collections.Generic;
using System.Linq;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos
{
    public class ListaSubTipoEmpleado : OriginaBase
    {
        private List<SubTipoEmpleado> _listSubTipoEmpleado = new List<SubTipoEmpleado>();

        public List<SubTipoEmpleado> ListadoSubTiposEmpleado
        {
            get { return _listSubTipoEmpleado; }
            set { _listSubTipoEmpleado = value; }
        }

    }
}
