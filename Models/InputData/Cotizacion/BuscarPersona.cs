using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Capa_de_Servicios.Models.InputData
{
    public class Persona
    {
        public Credenciales Credenciales { get; set; }
        public String Nombre1 { get; set; }
        public String Nombre2 { get; set; }
        public String Apellido1 { get; set; }
        public String Apellido2 { get; set; }
        public String rfc { get; set; }

    }
}
