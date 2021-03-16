using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Originacion.Models.Personas;


namespace Originacion.Models.Personas
{
    public class PersonaReferencia
    {
        public int NumeroReferencia { get; set; }
        public string CodTipoInformacion { get; set; }
        public string NombreTipoInformacion{ get; set; }
        public Persona Referencia { get; set; }
        public ListaDomiclio Domicilios { get; set; }
        public ListaDirElectronica DireccionesElectronicas { get; set; }
        public PersonaRelacionPersona Relacion { get; set; }
    }
}
