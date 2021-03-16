using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Catalogos
{
    public class LineaFondeo
    {
        public int ID_Linea_Fondeo { get; set; }
        public int Id_Fondeador { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Corto { get; set; }
        public double Porc_Capacidad_Pago { get; set; }
        public int Ind_Activo { get; set; }
    }
}
