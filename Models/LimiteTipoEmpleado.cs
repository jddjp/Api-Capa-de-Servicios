using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models
{
    public class LimiteTipoEmpleado
    {
        public int ID_Convenio { get; set; }
        public string Cod_Tipo_Empleado { get; set; }
        public float Porc_Max_Endeudam { get; set; }
        public float Porc_Max_Descuento { get; set; }
        public int Edad_Min { get; set; }
        public int Edad_Max { get; set; }
        public int Antiguedad_Min { get; set; }
        public int Antiguedad_Max { get; set; }
        public float Monto_Min { get; set; }
        public float Monto_Max { get; set; }
        public int Plazo_Min { get; set; }
        public int  Plazo_Max { get; set; }
        

    }
}
