using System;
using System.Collections.Generic;
using Originacion.Models.Cotizacion;
using Originacion.Models.General;
using Originacion.Models.Catalogos;
using Originacion.Models.Catalogos.CatalogosDomicilios;
using Originacion.Models.Personas;

namespace Originacion.Models.Solicitudes
{
    public partial class Solicitud : OriginaBase
    {
        public int IdCredito { get; set; }
        public int? IdDisposicion { get; set; }
        public int? IdPersona { get; set; }
        public int? IdCreditoAnt { get; set; }
        public int IdConvenio { get; set; }
        public string NomConvenio { get; set; }
        public string CodProducto { get; set; }
        public string CodEtapa { get; set; }
        public string CodEstatus { get; set; }
        public string CodFormaPago { get; set; }
        public string CodFrecuenciaPago { get; set; }
        public int? Plazo { get; set; }
        public string CodUdmPlazo { get; set; }
        public string CodTarifa { get; set; }
        public string TarifaNombre { get; set; }
        public int? DiasGracia { get; set; }
        public string IndAmorzPrimLiq { get; set; }
        public string CodTipoCuota { get; set; }
        public string CodBaseCalculo { get; set; }
        public string CodCompDias { get; set; }
        public string CodFormaLiquidacion { get; set; }
        public string CodFrecLiquidacion { get; set; }
        public string CodModLiquidacion { get; set; }
        public decimal? TasaIntOrd { get; set; }
        public decimal? CodBaseIntOrd { get; set; }
        public decimal? TasaIntMora { get; set; }
        public decimal? PorcIva { get; set; }
        public string CodEcvCredito { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Cat { get; set; }
        public DateTime? FechaOperacion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdCotizacion { get; set; }
        public string CodTipoEmpleado { get; set; }
        public string CodFinalidadCredito { get; set; }
        public decimal? Ingresos { get; set; }
        public decimal? Egresos { get; set; }
        public decimal? PorcMaxEndeudamiento { get; set; }
        public decimal? PorcMaxDescuento { get; set; }
        public decimal? NomiNeto { get; set; }
        public decimal? NomiTotalIngresos { get; set; }
        public decimal? NomiTotalEgresos { get; set; }
        public decimal? NomiMontoDisponible { get; set; }
        public decimal? NomiPorcDescuento { get; set; }
        public decimal? TotalNeto { get; set; }
        public decimal? TotalIngresos { get; set; }
        public decimal? TotalEgresos { get; set; }
        public decimal? TotalMontoDisponible { get; set; }
        public decimal? TotalPorcDescuento { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaPrimLiq { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal? BuroCreditoTotalCuentas { get; set; }
        public string BuroCreditoControlConsulta { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public string DescFormaPago { get; set; }
        public string DescFrecuenciaPago { get; set; }
        public string DescTipoCuota { get; set; }
        public string DescBaseCalculo { get; set; }
        public string DescCompDias { get; set; }
        public string DescFormaLiquidacion { get; set; }
        public string DescFrecLiquidacion { get; set; }
        public string DescModLiquidacion { get; set; }
        public string DescBaseIntOrd { get; set; }
        public string DescUdmPlazo { get; set; }
        public string DescFinalidad { get; set; }
        public string DescTipoEmpleado { get; set; }
        public string DescProductoComercial { get; set; }
        public ListaDomiclio ListaDomicilios { get; set; }
        public SolicitudListaRenovacion ListaRenovaciones { get; set; }
        public Persona Persona { get; set; }
        public PersonaReferencia Conyuge { get; set; }
        public PersonaReferencia ReferenciaFamilia { get; set; }
        public PersonaReferencia ReferenciaPersona2 { get; set; }
        public PersonaReferencia ReferenciaPersona3 { get; set; }

    }
}
