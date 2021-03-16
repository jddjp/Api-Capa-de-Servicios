using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Originacion.Models.Cotizacion
{
    public class CotizaView
    {
        [Required]
        public int Mov { get; set; }

        [Display(Name = "* Cotización")]
        public int IdCotizacion { get; set; }


        [Display(Name = "* Convenio")]
        [Required(ErrorMessage = "Convenio Requerido")]
        public int IdConvenio { get; set; }

        [Required]
        public string IdTarifa { get; set; }

        [Display(Name = "* Tipo de Empleado")]
        [Required(ErrorMessage = "Tipo de Empleado Requerido")]
        public string IdTipoEmpleado { get; set; }

        [Display(Name = "* Producto Comercial")]
        [Required(ErrorMessage = "Producto Requerido")]
        public string IdProductoComercial { get; set; }

        public int IdPersona { get; set; }

        [Display(Name = "* Primer Nombre")]
        [Required(ErrorMessage = "Nombre Requerido")]
        [StringLength(50, ErrorMessage = "Nombre Reuerido", MinimumLength = 1)]
        public string Nombre1 { get; set; }

        [Display(Name = "Segundo Nombre")]
        [StringLength(50)]
        public string Nombre2 { get; set; }


        [Display(Name = "* Apellido Paterno")]
        [Required(ErrorMessage = "Apellido Requerido")]
        [StringLength(50, ErrorMessage = "Apellido Requerido", MinimumLength = 1)]
        public string Apellido1 { get; set; }


        [Display(Name = "Apellido Materno")]
        [StringLength(50)]
        public string Apellido2 { get; set; }

        [Display(Name = "* Fec. Nac.")]
        [Required(ErrorMessage = "Fecha Requerida")]
        [DataType(DataType.Date, ErrorMessage = "Fecha Requerida")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "* Teléfono")]
        [Required(ErrorMessage = "Teléfono Requerido")]
        [Phone]
        [StringLength(20)]
        public string Telefono { get; set; }

        [Display(Name = "* RFC")]
        [Required]
        [StringLength(13, ErrorMessage = "RFC Requerido")]
        public string RFC { get; set; }

        [Display(Name = "* Correo Electrónico")]
        [Required]
        [StringLength(50, ErrorMessage = "Correo Requerido")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Formato Incorrecto")]
        public string Email { get; set; }

        [Display(Name = "* Monto del Crédito")]
        [Required]
        [Range(1, 999999.99)]
        [DataType(DataType.Currency, ErrorMessage = "Monto Requerido")]
        public double Monto { get; set; }

        [Display(Name = "Forma de Pago")]
        [Required]
        public string FormaPago { get; set; }

        [Display(Name = "Frecuencia de Pago")]
        [Required]
        public string FrecPago { get; set; }

        [Display(Name = "Tipo de Cuota")]
        [Required]
        public string TipoCuota { get; set; }

        [Display(Name = "Dias base de Cálculo")]
        [Required]
        public string DiasbaseCalculo { get; set; }

        [Display(Name = "Cómputo de dias")]
        [Required]
        public string Computodias { get; set; }

        [Display(Name = "Forma de Liquidacion")]
        [Required]
        public string FormaLiq { get; set; }

        [Display(Name = "Frecuencia de Liquidación")]
        [Required]
        public string FrecLiquidacion { get; set; }

        [Display(Name = "Modo de Liquidacion")]
        [Required]
        public string ModLiquidacion { get; set; }

        //[Required]
        [Display(Name = "Base cálculo interés Normal")]
        public string? CodBasecalIntOrd { get; set; }

        //[Required]
        [Display(Name = "Carencia")]
        public int Carencia { get; set; }


        [Display(Name = "* Plazo")]
        [Required(ErrorMessage = "Monto Requerido")]
        [Range(1, 200)]
        public int Plazo { get; set; }

        [Display(Name = "Frecuencia")]
        //[Required]
        public int IdFrecuencia { get; set; }

        [Display(Name = "* Finalidad del Crédito")]
        [Required(ErrorMessage = "Finalidad Requerida")]
        public string IdFinalidad { get; set; }

        [Range(0, 999999.99)]
        [DataType(DataType.Currency)]
        public double Ingresos { get; set; }

        [Range(0, 999999.99)]
        [DataType(DataType.Currency)]
        public double Egresos { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        public int IdCreditoAnterior { get; set; }

        public string IdUDMPlazo { get; set; }

        public string IndAmorzPrimLiq { get; set; }

        public double TasaIntOrd { get; set; }

        public double TasaIntMora { get; set; }

        public double PorcIva { get; set; }

        public string Estatus { get; set; }

        public double CAT { get; set; }

        public DateTime FechaOperacion { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string DetalleIngresos { get; set; }

        public string DetalleEgresos { get; set; }

        public string DetalleOtrosIngresos { get; set; }
        public string DetalleOtrosEgresos { get; set; }

        // Campos para totales de ingresos y egresos
        public double PorcMaxDescuento { get; set; } = 0;
        public double PorcMaxEndeudamiento { get; set; } = 0;
        
        public double NomiNeto { get; set; } = 0;
        public double NomiTotalIngresos { get; set; } = 0;
        public double NomiTotalEgresos { get; set; } = 0;
        public double NomiMontoDisponible { get; set; } = 0;
        public double NomiPorcDescuento { get; set; } = 0;

        public double TotalNeto { get; set; } = 0;
        public double TotalIngresos { get; set; } = 0;
        public double TotalEgresos { get; set; } = 0;
        public double TotalMontoDisponible { get; set; } = 0;
        public double TotalPorcDescuento { get; set; } = 0;


        [Display(Name = "* Fec. Inicio")]
        [Required(ErrorMessage = "Fecha Requerida")]
        [DataType(DataType.Date, ErrorMessage = "Fecha Requerida")]
        public DateTime Fecha_Inicio { get; set; }

        [Display(Name = "* Fec. 1era. Liq.")]
        [Required(ErrorMessage = "Fecha Requerida")]
        [DataType(DataType.Date, ErrorMessage = "Fecha Requerida")]
        public DateTime Fecha_Prim_Liq { get; set; }

        [Display(Name = "* Fecha de Ingreso")]
        [Required(ErrorMessage = "Fecha Requerida")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Fecha Requerida")]
        public DateTime Fecha_Ingreso { get; set; }

        public double MontoMaximo { get; set; }
        public int PlazoMaximo { get; set; }

        public DateTime Fecha_Limite { get; set; }

        public int NumOfSeleccionada { get; set; } = 0;
        public Ofertas? OfertaSel { get; set; }

        public string Etapa { get; set; }

        // Campos que contienen la descripción de los campos de catálogo
        public string Producto_Comercial { get; set; } = "";
        public string Forma_Pago { get; set; } = "";
        public string Frecuencia_Pago { get; set; } = "";
        public string Tipo_Cuota { get; set; } = "";
        public string Base_Calculo { get; set; } = "";
        public string Comp_Dias { get; set; } = "";
        public string Forma_Liquidacion { get; set; } = "";
        public string Frec_Liquidacion { get; set; } = "";
        public string Mod_Liquidacion { get; set; } = "";
        public string Base_Int_Ord { get; set; } = "";
        public string Dias_Gracia_Desc { get; set; } = "";
        public string Tarifa { get; set; } = "";
        public string Tipo_Empleado { get; set; } = "";
        public string Finalidad_Credito { get; set; } = "";
        public string Etapa_Desc { get; set; } = "";
        public string Estatus_Desc { get; set; } = "";
        public string Convenio { get; set; } = "";
        public string UnidadMedida { get; set; }
        public string Usuario { get; set; }
        public double Buro_Credito_Total_Cuentas { get; set; }
        public string Buro_Credito_Control_Consulta { get; set; }
        public int IdTarifaConvenio { get; set; }
        public string DetalleRenovaciones { get; set; }
        public double SaldoRenovar { get; set; }

        public List<CotizaIngresosEgresos> CotizaIngresosEgresos { get; set; }
        public List<Renovacion> CotizaSaldosRenovar { get; set; }
    }
}
