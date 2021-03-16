using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.General;

namespace Originacion.Models.Personas
{
    public class ListaPersonaReferencia : OriginaBase
    {

        private List<PersonaReferencia> _listaPersonaReferencia = new List<PersonaReferencia>();

        public List<PersonaReferencia> ListaPersonaReferencias
        {
            get { return _listaPersonaReferencia; }
            set { _listaPersonaReferencia = value; }
        }
    }
}
