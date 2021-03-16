using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Catalogos
{
    public class UnidadMedida
    {
        public string Cod_UDM { get; set; }
	    public string Nombre { get; set; }
        public int Num_dias { get; set; }
        public double Factor_Mensual { get; set; }
    }
}
