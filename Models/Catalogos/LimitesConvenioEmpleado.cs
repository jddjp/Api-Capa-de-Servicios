using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Catalogos
{
    public class LimitesConvenioEmpleado
    {
        public int IdConvenio { get; set; }
        public string IdTipoEmpleado { get; set; }
        public double Porc_Max_Endeudam { get; set; }
        public double Porc_Max_Descuento { get; set; }
        public int Edad_Min { get; set; }
        public int Edad_Max { get; set; }
        public int Antiguedad_Min { get; set; }
        public int Antiguedad_Max { get; set; }
        public double Monto_Min { get; set; }
        public double Monto_Max { get; set; }
        public int Plazo_Min { get; set; }
        public int Plazo_Max { get; set; }

    }
}
