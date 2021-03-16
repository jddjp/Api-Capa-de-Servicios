using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Cotizacion
{
    public class Amortizacion
    {
          public int Num_Amort {get; set;}
          public DateTime Fecha_Inicio { get; set; }
          public DateTime Fecha_Final { get; set; }
          public DateTime Fecha_Liq { get; set; }
          public double Saldo_Inicial { get; set; }
          public double Imp_Amortizacion { get; set; }
          public double Int_Ordinario { get; set; }
          public double Iva_Int_Ordinario { get; set; }
          public double Imp_Comision { get; set; }
          public double Iva_Comison { get; set; }
          public double Imp_Seguro { get; set; }
          public double Iva_Seguro { get; set; }
          public double Saldo_Final { get; set; }
          public double Total_Cuota { get; set; }
}
}
