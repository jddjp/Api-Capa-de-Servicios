using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.General
{
    public class ResServicio
    {
        public byte ResultadoServicio { get; set; }
        public string ErrorMensaje { get; set; }
        public string ErrorCodigo { get; set; }
        public byte ErrorNivel { get; set; }
        public string ErrorDescripcionTecnica { get; set; }
    }
}
