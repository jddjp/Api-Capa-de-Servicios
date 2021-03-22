using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Api_Capa_de_Servicios.Models.InputData.Solicitud;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Newtonsoft.Json;
using Originacion.Models.Catalogos.CatalogosDomicilios;
using Originacion.Models.Catalogos.CatalogosPersona;
using Originacion.Models.Cotizacion;
using Originacion.Models.Personas;
using Originacion.Models.Solicitudes;

namespace Api_Capa_de_Servicios.Controllers
{
    [Authorize]
    [Route("WSOriginacion/[controller]")]
    // [Route("[controller]")]
    // [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {
        /// <summary>
        /// Migrar Cotizacion a Solicitud
        /// </summary>
        /// <remarks>
        /// Consolida una Solicitud respecto a la Cotizacion Almacenada
        /// </remarks>
        /// <response code="200">OK</response>
        [HttpPost("CreteSolicitudByIdCotizacion")]
        public ActionResult CreateSolicitud(SolicitudMigracion solicitudMigracion)
        {
            SolicitudMigracion resSolicitudMigracion = new SolicitudMigracion();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));

            
            var content = new StringContent(JsonConvert.SerializeObject(solicitudMigracion).ToString(), Encoding.UTF8, "application/json");

            var request = httpClient.PostAsync("http://34.121.231.100:9003/APISolicitudes/postMigraCotizacion", content).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                resSolicitudMigracion = JsonConvert.DeserializeObject<SolicitudMigracion>(resulString);
                return StatusCode(200, resSolicitudMigracion);
            }
            else
            {
                return StatusCode(501);
            }

        }

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
           
            List<ItemListaSolicitudes> listaItemListaCotizaciones = new List<ItemListaSolicitudes>();

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://34.121.231.100:9003");

            var request = httpClient.GetAsync("/APISolicitudes/getListaSolicitudes?idUsuario=" + idUsuario.ToString()).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;

               // listaItemListaCotizaciones = JsonConvert.DeserializeObject<List<ItemListaSolicitudes>>(resulString);
                return StatusCode(200, resulString);
            }
            else
            {
                return StatusCode(501);
            }

         
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


            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://34.121.231.100:9003");

            var request = httpClient.GetAsync("/APISolicitudes/getSolicitud?idSolicitud=" + IdSolicitud.ToString()).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;

                solicitud = JsonConvert.DeserializeObject<Solicitud>(resulString);
                return StatusCode(200, solicitud);
            }
            else
            {
                return StatusCode(501);
            }

         
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
            DatosPersonalesPersona datosPersonalesPersona = new DatosPersonalesPersona();
          
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(persona.Id_Persona.ToString()), "id_Persona");
            data.Add(new StringContent(persona.Cod_Tipo_Persona), "cod_Tipo_Persona");
            data.Add(new StringContent(persona.Primer_Nombre), "primer_Nombre");
            data.Add(new StringContent(persona.Segundo_Nombre), "segundo_Nombre");
            data.Add(new StringContent(persona.Primer_Paterno), "primer_Paterno");
            data.Add(new StringContent(persona.Segundo_Apellido), "segundo_Apellido");
            data.Add(new StringContent(persona.Fecha_Nacimiento.ToString()), "fecha_Nacimiento");
            data.Add(new StringContent(persona.cod_Pais_Origen.ToString()), "cod_Pais_Origen");
            data.Add(new StringContent(persona.Cod_Pais_Nacimiento.ToString()), "cod_Pais_Nacimiento");
            data.Add(new StringContent(persona.Cod_Nivel_Estudios), "cod_Nivel_Estudios");
            data.Add(new StringContent(persona.Curp), "curp");
            data.Add(new StringContent(persona.Rfc), "rfc");
            data.Add(new StringContent(persona.Cod_Genero), "cod_Genero");
            data.Add(new StringContent(persona.Cod_Edo_Civil), "cod_Edo_Civil");
            data.Add(new StringContent(persona.Cod_Edo_Ocupacion), "cod_Edo_Ocupacion");
            data.Add(new StringContent(persona.Cod_Sit_Economica), "cod_Sit_Economica");
            data.Add(new StringContent(persona.Dep_Economicos.ToString()), "dep_Economicos");
            data.Add(new StringContent(persona.Fecha_Defuncion.ToString()), "fecha_Defuncion");
            data.Add(new StringContent(persona.Id_Suc_Reqistro.ToString()), "id_Suc_Reqistro");
            data.Add(new StringContent(persona.Fecha_Alta.ToString()), "fecha_Alta");
            data.Add(new StringContent(persona.Fecha_Modificacion.ToString()), "fecha_Modificacion");
            data.Add(new StringContent(persona.Fecha_Residencia.ToString()), "fecha_Residencia");
            data.Add(new StringContent(persona.Cod_Situacion_Domicilio.ToString()), "cod_Situacion_Domicilio");
            data.Add(new StringContent(persona.Alias.ToString()), "alias");
            data.Add(new StringContent(persona.Cod_Tipo_Ident_Pref.ToString()), "cod_Tipo_Ident_Pref");
            data.Add(new StringContent(persona.Folio_Identificacion.ToString()), "folio_Identificacion");
            data.Add(new StringContent(persona.Cod_ECV_Persona.ToString()), "cod_ECV_Persona");
            data.Add(new StringContent(persona.IdNacionalidad.ToString()), "idNacionalidad");
        
            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Solicitudes/GuardaPersona/", data).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                datosPersonalesPersona = JsonConvert.DeserializeObject<DatosPersonalesPersona>(resulString);
                return StatusCode(200, datosPersonalesPersona);
            }
            else
            {
                return StatusCode(501);
            }
           
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
            List<EdoRegion> edoRegion = new List<EdoRegion>();
            
           HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
         
            var request = httpClient.GetAsync("https://originacion.aprecia.com.mx:9201/Solicitudes/GetEstados/").Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
               // edoRegion = JsonConvert.DeserializeObject<List<EdoRegion>>(resulString);
                return StatusCode(200, resulString);
            }
            else
            {
                return StatusCode(501);
            }
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
            List<Municipio>  municipio = new List<Municipio>();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(IdEstado.ToString()), "idEstado");
            
          

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Solicitudes/GetMunicipios/", data).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                municipio = JsonConvert.DeserializeObject<List<Municipio>>(resulString);
                return StatusCode(200, municipio);
            }
            else
            {
                return StatusCode(501);
            }

          
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
            List<Colonia>  colonia = new List<Colonia>();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(CP.ToString()), "CP");

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Solicitudes/getColonias/", data).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                colonia = JsonConvert.DeserializeObject<List<Colonia>>(resulString);
                return StatusCode(200, colonia);
            }
            else
            {
                return StatusCode(501);
            }
           
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
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
          
            //data.Add(new StringContent(CP.ToString()), "CP");

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Solicitudes/getColonias/", data).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
               // colonia = JsonConvert.DeserializeObject<List<Colonia>>(resulString);
                return StatusCode(200 );
            }
            else
            {
                return StatusCode(501);
            }
         
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
            DirElectronica dirElectronica1 = new DirElectronica();
               HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();

            data.Add(new StringContent(dirElectronica.CodDirElectronica.ToString()), "CodDirElectronica");
            data.Add(new StringContent(dirElectronica.IdPersona.ToString()), "IdPersona");
            data.Add(new StringContent(dirElectronica.TxtDireccion.ToString()), "TxtDireccion");
            data.Add(new StringContent(dirElectronica.Extension.ToString()), "Extension");
            data.Add(new StringContent(dirElectronica.Observacion.ToString()), "Observacion");

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Solicitudes/postActualizaDireccionElectronica/", data).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                dirElectronica1 = JsonConvert.DeserializeObject<DirElectronica>(resulString);
                return StatusCode(200, dirElectronica1);
            }
            else
            {
                return StatusCode(501);
            }
           
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
            DatosPersonalesPersona datosPersonalesPersona = new DatosPersonalesPersona();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));

            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(persona.Id_Persona.ToString()), "id_Persona");
            data.Add(new StringContent(persona.Cod_Tipo_Persona), "cod_Tipo_Persona");
            data.Add(new StringContent(persona.Primer_Nombre), "primer_Nombre");
            data.Add(new StringContent(persona.Segundo_Nombre), "segundo_Nombre");
            data.Add(new StringContent(persona.Primer_Paterno), "primer_Paterno");
            data.Add(new StringContent(persona.Segundo_Apellido), "segundo_Apellido");
            data.Add(new StringContent(persona.Fecha_Nacimiento.ToString()), "fecha_Nacimiento");
            data.Add(new StringContent(persona.cod_Pais_Origen.ToString()), "cod_Pais_Origen");
            data.Add(new StringContent(persona.Cod_Pais_Nacimiento.ToString()), "cod_Pais_Nacimiento");
            data.Add(new StringContent(persona.Cod_Nivel_Estudios), "cod_Nivel_Estudios");
            data.Add(new StringContent(persona.Curp), "curp");
            data.Add(new StringContent(persona.Rfc), "rfc");
            data.Add(new StringContent(persona.Cod_Genero), "cod_Genero");
            data.Add(new StringContent(persona.Cod_Edo_Civil), "cod_Edo_Civil");
            data.Add(new StringContent(persona.Cod_Edo_Ocupacion), "cod_Edo_Ocupacion");
            data.Add(new StringContent(persona.Cod_Sit_Economica), "cod_Sit_Economica");
            data.Add(new StringContent(persona.Dep_Economicos.ToString()), "dep_Economicos");
            data.Add(new StringContent(persona.Fecha_Defuncion.ToString()), "fecha_Defuncion");
            data.Add(new StringContent(persona.Id_Suc_Reqistro.ToString()), "id_Suc_Reqistro");
            data.Add(new StringContent(persona.Fecha_Alta.ToString()), "fecha_Alta");
            data.Add(new StringContent(persona.Fecha_Modificacion.ToString()), "fecha_Modificacion");
            data.Add(new StringContent(persona.Fecha_Residencia.ToString()), "fecha_Residencia");
            data.Add(new StringContent(persona.Cod_Situacion_Domicilio.ToString()), "cod_Situacion_Domicilio");
            data.Add(new StringContent(persona.Alias.ToString()), "alias");
            data.Add(new StringContent(persona.Cod_Tipo_Ident_Pref.ToString()), "cod_Tipo_Ident_Pref");
            data.Add(new StringContent(persona.Folio_Identificacion.ToString()), "folio_Identificacion");
            data.Add(new StringContent(persona.Cod_ECV_Persona.ToString()), "cod_ECV_Persona");
            data.Add(new StringContent(persona.IdNacionalidad.ToString()), "idNacionalidad");

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Solicitudes/GuardaPersona/", data).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                datosPersonalesPersona = JsonConvert.DeserializeObject<DatosPersonalesPersona>(resulString);
                PersonaRelacionPersona relacionPersonas = new PersonaRelacionPersona();

                MultipartFormDataContent data1 = new MultipartFormDataContent();
                data1.Add(new StringContent(relacionPersonas.CodRelPersPers.ToString()), "codRelPersPers");
                data1.Add(new StringContent(relacionPersonas.IdPersona.ToString()), "idPersona");
                data1.Add(new StringContent(relacionPersonas.IdPersonaRel.ToString()), "idPersonaRel");
                data1.Add(new StringContent(relacionPersonas.FechaVigHasta.ToString()), "vigenciaHasta");


                var request2 = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Solicitudes/postPersonaRelacionPersona/", data1).Result;

                return StatusCode(200, request2);
            }
            else
            {
                return StatusCode(501);
            }
           
        }

    }
}