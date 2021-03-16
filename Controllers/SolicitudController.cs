using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Capa_de_Servicios.Models.InputData.Solicitud;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Originacion.Models.Personas;
using Originacion.Models.Solicitudes;

namespace Api_Capa_de_Servicios.Controllers
{
    [Route("WSOriginacion/[controller]")]
    // [Route("[controller]")]
    // [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {
        /// <summary>
        /// Obtiene una lista de Solicitudes
        /// </summary>
        /// <remarks>
        /// Este servicio devuelve una lista de  todas las Solicitudes previamente Guardadas 
        /// </remarks>
        /// <response code="200">OK. Devuelve una Lista de Solicitudes.</response>
        [HttpGet("GetListSolicitudes")]
        public  IActionResult GetSolicitudes(int idUsuario)
        {
            SolicitudLista listaSolicitudes = new SolicitudLista();

            return Ok(listaSolicitudes);
        }

        /// <summary>
        /// Migrar Cotizacion a Solicitud
        /// </summary>
        /// <remarks>
        /// Consolida una Solicitud respecto a la Cotizacion Almacenada
        /// </remarks>
        /// <response code="200">OK</response>
        [HttpGet("CreteSolicitudByIdCotizacion")]
        public ActionResult CreateSolicitud(SolicitudMigracion solicitudMigracion)
        {
            SolicitudMigracion resSolicitudMigracion = new SolicitudMigracion();
            return StatusCode(200,resSolicitudMigracion);
        }

        /// <summary>
        /// Obtener Solicitud por ID Solicitud
        /// </summary>
        /// <remarks>
        /// Devuelve Codigo Html Solicitud Por ID
        /// </remarks>
        /// <response code="200">OK. Devuelve HTML Solicitud Por ID.</response>
        [HttpGet("GetSolicitudByIdSolicitud/{IdSolicitud}")]
        public IActionResult GetSolicitudByID(int IdSolicitud)
        {
            Solicitud solicitud = new Solicitud();

            return StatusCode(200,solicitud);
        }




        /// <summary>
        /// Guardar Datos Personales por ID Persona
        /// </summary>
        /// <remarks>
        /// Devuelve un Objeto Persona Con los Datos Registrados
        /// </remarks>
        /// <response code="200">OK. Devuelve un Objeto Persona.</response>
        [HttpPost("SaveDatosPersonales")]
        public IActionResult SaveToPersonaByID(DatosPersonalesPersona persona)
        {
            return StatusCode(200);
        }

        /// <summary>
        /// Obtiene una Lista de Estados
        /// </summary>
        /// <remarks>
        /// Devuelve los Estados
        /// </remarks>
        /// <response code="200">OK. Lista de Estados </response>
        [HttpGet("CatalogosAddDomicilio/GetEstados")]
        public IActionResult GetEstados()
        {
            return StatusCode(200);
        }

        /// <summary>
        /// Obtener Municipios Por ID Estado
        /// </summary>
        /// <remarks>
        /// Devuelve los Municipios Correspondientes al ID Estado
        /// </remarks>
        /// <response code="200">OK. Lista de Colonias </response>
        [HttpGet("CatalogosAddDomicilio/GetMunicipiosByIdEstado/{IdEstado}")]
        public IActionResult GetMunicipios(int IdEstado)
        {
            return StatusCode(200);
        }

        /// <summary>
        /// Obtener Colonias Por Codigo Postal
        /// </summary>
        /// <remarks>
        /// Devuelve las Colonias Correspondientes al Codigo Postal Ingresado 
        /// </remarks>
        /// <response code="200">OK. Lista de Colonias </response>
        [HttpGet("CatalogosAddDomicilio/GetColoniasByCP/{CP}")]
        public IActionResult GetColonias(int CP)
        {
            return StatusCode(200);
        }



        /// <summary>
        /// Registra Domicilios Por ID Persona
        /// </summary>
        /// <remarks>
        /// Registra un nuevo Domicilio a una Persona por el ID Persona
        /// </remarks>
        /// <response code="200">OK </response>
        [HttpPost("AddDomicilioPersona")]
        public IActionResult SaveDomicilosPersona(Domicilio domicilio)
        {
            return StatusCode(200);
        }

        /// <summary>
        /// Actualiza Datos de Un Domicilio
        /// </summary>
        /// <remarks>
        ///Actualiza los Datos de Un Domicilio Correspondiente a una Persona
        /// </remarks>
        /// <response code="200">OK </response>
        [HttpPut("UpdateDomicilioPersona")]
        public IActionResult UpdateDomicilosPersona(Domicilio domicilio)
        {
            return StatusCode(200);
        }



        /// <summary>
        /// Registra Direcciones Electronicas Por ID Persona
        /// </summary>
        /// <remarks>
        /// Registra  Direcciones Electronicas a una Persona por el ID Persona
        /// </remarks>
        /// <response code="200">OK </response>
        [HttpPost("AddDireccionesElectronicasPersona")]
        public IActionResult SaveDireccionesElectronicasByIDPersona(DirElectronica dirElectronica)
        {
            return StatusCode(200);
        }

        /// <summary>
        /// Carga Documentos Por ID Credito 
        /// </summary>
        /// <remarks>
        /// Carga Los documentos de una Solicitud y los Guarda en el expediente del ID Credito y si no tiene Expediente Registra Uno nuevo
        /// </remarks>
        /// <response code="200">OK </response>
        [HttpPost("CargaDocumentosSolicitud")]
        public IActionResult SaveDOcsByIDCreditoSolicitud(CargaDocumento cargaDocumento)
        {
            return StatusCode(200);
        }

      


        /// <summary>
        /// Obtener Lista Areas Por ID Dependencia
        /// </summary>
        /// <remarks>
        /// Devuelve Las Areas Existentes de la Dependencia
        /// </remarks>
        /// <response code="200">OK. </response>
        [HttpGet("CatalogosAddEmpleos/GetListAreasByIdDependencia")]
        public IActionResult GetListaAreas(int IdDependencia)
        {
            return StatusCode(200);
        }

        /// <summary>
        ///Registra Un Empleo Por ID Persona
        /// </summary>
        /// <remarks>
        /// Devuelve Los Datos del Empleo Registrado
        /// </remarks>
        /// <response code="200">OK. </response>
        [HttpPost("AddEmpleoPersona")]
        public IActionResult SaveEmpleosPersona(Empleo empleo)
        {
            return StatusCode(200);
        }


        /// <summary>
        ///Registra Domicilio Del Empleo
        /// </summary>
        /// <remarks>
        /// Devuelve Los Datos del Domicilio  Registrado
        /// </remarks>
        /// <response code="200">OK. </response>
        [HttpPost("AddDomicilioEmpleoPersona")]
        public IEnumerable<string> SaveDomicilioEmpleoPersona(EmpleoDomicilios empleoDomicilios)
        {
            return new string[] { "value1", "value2" };
        }


        /// <summary>
        ///Registra Datos Domiciliacion Por ID Persona
        /// </summary>
        /// <remarks>
        /// Devuelve Los Datos Domiciliacion Registrados y El Estatus
        /// </remarks>
        /// <response code="200">OK. </response>
        [HttpPost("AddDatosDomiciliacionPersona")]
        public IEnumerable<string> RegistraDatosDomiciliacionPersona(DatosDomiciliacion datosDomiciliacion)
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Agregar Referencia de Persona 
        /// </summary>
        /// <remarks>
        ///Agrega una Referencia de persona de una solicitud de credito 
        /// </remarks>
        [HttpPost("AddReferenciaPersona")]
        public IActionResult AddReferenciasDePersona(ReferenciaPersona persona)
        {
            return StatusCode(200);
        }

    }
}