using System;
using System.Collections.Generic;
using System.Linq;
using Originacion.Models.General;

namespace Originacion.Models.Catalogos
{
    public class ListaInstitucionFinanciera : OriginaBase
    {
        private List<InstitucionFinanciera> _listInstitucionFinanciera = new List<InstitucionFinanciera>();

        public List<InstitucionFinanciera> ListadoInstitucionesFinancieras
        {
            get { return _listInstitucionFinanciera; }
            set { _listInstitucionFinanciera = value; }
        }

    }
}
