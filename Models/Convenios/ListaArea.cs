using Originacion.Models.Convenios;
using Originacion.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Convenios
{
    public class ListaArea : OriginaBase
    {

        private List<Area> _listAreas = new List<Area>();

        public List<Area> ListadoAreas
        {
            get { return _listAreas; }
            set { _listAreas = value; }
        }


    }
}
