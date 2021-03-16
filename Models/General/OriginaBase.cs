using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.General
{
    public class OriginaBase
    {
        private ResServicio _estatusServicio = new ResServicio();
        public ResServicio estatusServicio   // property
        {
            get { return _estatusServicio; }   // get method
            set { _estatusServicio = value; }  // set method
        }

    }
}
