using Originacion.Models.Convenios;
using Originacion.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Convenios
{
    public class ListaDependencia : OriginaBase
    {

        private List<Dependencia> _listDependencias = new List<Dependencia>();

        public List<Dependencia> ListadoDependencias
        {
            get { return _listDependencias; }
            set { _listDependencias = value; }
        }


    }
}
