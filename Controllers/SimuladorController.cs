using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Api_Capa_de_Servicios.Models.InputData;
using Api_Capa_de_Servicios.Models.InputData.Cotizacion;
using Api_Capa_de_Servicios.Models.InputData.OutputData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Originacion.Models.Catalogos;
using Originacion.Models.Convenios;
using Originacion.Models.Cotizacion;
using Originacion.Models.CREDIERP;
using Originacion.Models.Personas;


namespace Api_Capa_de_Servicios.Controllers
{
    [Authorize]
    [Route("WSOriginacion/[controller]")]
    [ApiController]
    public class SimuladorController : ControllerBase
    {

        /// <summary>
        /// Obtiene una lista de Cotizaciones
        /// </summary>
        /// <remarks>
        /// Este servicio devuelve una lista de  todas las Cotizaciones previamente Guardadas 
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpPost("GetLisCotizaciones/{idUsuario}")]
        public IActionResult GetCotizaciones(int idUsuario)
        {
             List<ItemListaSolicitudes> listaItemListaCotizaciones = new List<ItemListaSolicitudes>();

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://originacion.aprecia.com.mx:9201/");
           
            var request = httpClient.GetAsync("Home/getListaCotizaciones/").Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;

                listaItemListaCotizaciones = JsonConvert.DeserializeObject<List<ItemListaSolicitudes>>(resulString);
                return StatusCode(200, listaItemListaCotizaciones);
            }
            else
            {
                return StatusCode(501);
            }

        }


        /// <summary>
        /// Obtiene una lista de Personas 
        /// </summary>
        /// <remarks>
        /// Buscar personas que cumplan con los parametros de entrada 
        /// </remarks>
        ///  /// <response code="401">Usuario No Ahutenticado </response>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpPost("GetListPersonas")]
        public IActionResult Get(Models.InputData.Persona buscaPersona)
        {
            List<PersonaNombre> oPersonaLista = new List<PersonaNombre>();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(buscaPersona.Nombre1), "Nombre1");
            data.Add(new StringContent(buscaPersona.Nombre2), "Nombre2");
            data.Add(new StringContent(buscaPersona.Apellido1), "Apellido1");
            data.Add(new StringContent(buscaPersona.Apellido2), "Apellido2");
            data.Add(new StringContent(buscaPersona.rfc), "rfc");
             var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/BuscaPersona/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                oPersonaLista = JsonConvert.DeserializeObject<List<PersonaNombre>>(resulString);
                return StatusCode(200, oPersonaLista);
            }
            else
            {
                return StatusCode(501);
            }
            
        }

        /// <summary>
        /// Obtiene un Objeto Persona
        /// </summary>
        /// <remarks>
        /// Buscar busca la Persona Correspondiente al ID  y devuelve un objeto persona con los campos correspondientes
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetPersonaByID/{id_Persona}")]
        public IActionResult GetPersonasByID(int id_Persona)
        {
            Originacion.Models.Personas.Persona oPersona = new Originacion.Models.Personas.Persona();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(id_Persona.ToString()),"id_Persona");
           

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/GetPersonabyId/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                oPersona = JsonConvert.DeserializeObject<Originacion.Models.Personas.Persona>(resulString);
                return StatusCode(200, oPersona);
            }
            else
            {
                return StatusCode(501);
            }


        }

        /// <summary>
        /// Busca si la persona Tiene un credito Vigente 
        /// </summary>
        /// <remarks>
        /// Busca Renovaciones correspondientes a las datos de la persona en los parametros de entrada
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpPost("GetRenovacionesByIdPersona/{JsonPersona}")]
        public IActionResult GetRenovacionesByPersona(PersonaRenovaciones personaRenovaciones)
        {
            List<InfoProspecto> listInfoProspecto = new List<InfoProspecto>();


            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(personaRenovaciones.sRFC), "sRFC");
            data.Add(new StringContent(personaRenovaciones.sPrimerNombre), "sPrimerNombre");
            data.Add(new StringContent(personaRenovaciones.sSegundoNombre), "sSegundoNombre");
            data.Add(new StringContent(personaRenovaciones.sPrimerApellido), "sPrimerApellido");
            data.Add(new StringContent(personaRenovaciones.sSegundoNombre), "sSegundoApellido");



            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getRenovacionesCrediERP/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                listInfoProspecto = JsonConvert.DeserializeObject<List<InfoProspecto>>(resulString);
                return StatusCode(200, listInfoProspecto);
            }
            else
            {
                return StatusCode(501);
            }
        }


        /// <summary>
        /// Obtiene una lista de Convenios Por usuario
        /// </summary>
        /// <remarks>
        /// Busca Los Convenios Correspondientes al Usuario
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetConveniosByIdUsuario/{IdUsuario}")]
        public IActionResult GetConveniosUsuario( int IdUsuario)
        {
            List<Convenio> listaConvenios = new List<Convenio>();
            return Ok();
        }

        /// <summary>
        /// Obtiene Los datos Correspondientes al ID Convenio
        /// </summary>
        /// <remarks>
        /// Busca La Informacion Correspondiente al ID Convenio y la Devuelve
        /// </remarks>
        /// <response code="200">OK. Devuelve la Informacion del Convenio:codigo, fecha_Fin, fecha_Inicio, idConvenio, indicadorVigencia, nombre</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetInfoConvenioByIdConvenio/{IdConvenio}")]
        public IActionResult GetInfoConvenioXId(String IdConvenio)
        {

            Convenio convenio = new Convenio();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(IdConvenio), "IdConvenio");




            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getConvenioXId/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                convenio = JsonConvert.DeserializeObject<Convenio>(resulString);
                return StatusCode(200, convenio);
            }
            else
            {
                return StatusCode(501);
            }

          
        }


        /// <summary>
        /// Obtiene la Finalidad del Credito
        /// </summary>
        /// <remarks>
        /// Busca los datos Correspondientes al ID Finalidad
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetFinalidadDelCredito")]
        public IActionResult GetFinalidadCredito()
        {
            List<FinalidadCredito> listaFinalidadCredito = new List<FinalidadCredito>();
            return StatusCode(200, listaFinalidadCredito);
        }

        /// <summary>
        /// Obtiene una Lista de los Tipos de Empleado Por Convenio
        /// </summary>
        /// <remarks>
        /// Busca una Lista de los Tipos de Empleado Registrados para el ID Convenio
        /// </remarks>
        /// <response code="200">OK. Devuelve Una Lista Con los datos de Tipo de Empleado Registrados para ese Convenio.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetListTipoEmpleadoByIdConvenio/{IdConvenio}")]
        public IActionResult GetTipoEmpleadoXConvenio(int IdConvenio)
        {
            List<TipoEmpleado> listaTipoEmpleado = new List<TipoEmpleado>();
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(IdConvenio.ToString()), "IdConvenio");




            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getTEmpXCon/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                listaTipoEmpleado = JsonConvert.DeserializeObject<List<TipoEmpleado>>(resulString);
                return StatusCode(200, listaTipoEmpleado);
            }
            else
            {
                return StatusCode(501);
            }

           
        }

        /// <summary>
        /// Obtiene una Lista de Ingresos y Egresos Por ID Convenio
        /// </summary>
        /// <remarks>
        /// Busca los datos Correspondientes al ID Finalidad
        /// </remarks>
        /// <response code="200">OK. Devuelve una lista de Ingresos y Egresos Correspondientes al Convenio.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetListIngresosByIdConvenio/{IdConvenio}")]
        public IActionResult GetIngresosEgresosXConvenio(int IdConvenio)
        {
            List<DescuentosXConvenio> listDescuentosXConvenio = new List<DescuentosXConvenio>();
           
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(IdConvenio.ToString()), "IdConvenio");


            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getIngresosXConvenio/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                listDescuentosXConvenio = JsonConvert.DeserializeObject<List<DescuentosXConvenio>>(resulString);
                return StatusCode(200, listDescuentosXConvenio);
            }
            else
            {
                return StatusCode(501);
            }


         
        }

        /// <summary>
        /// Obtiene Una lista Descuentos por ID Convenio
        /// </summary>
        /// <remarks>
        /// Busca los descuentos y devuelve una lista con los Descuentos Referentes al ID Convenio
        /// </remarks>
        /// <response code="200">OK. Devuelve el Objeto de Lista de Descuentos Por ID Convenio.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetListDescuentosByIdConvenio/{IdConvenio}")]
        public IActionResult GetDescuentosXConvenio(int IdConvenio)
        {
            List<DescuentosXConvenio> listDescuentosXConvenio = new List<DescuentosXConvenio>();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(IdConvenio.ToString()), "IdConvenio");


            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getDescuentosXConvenio/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                listDescuentosXConvenio = JsonConvert.DeserializeObject<List<DescuentosXConvenio>>(resulString);
                return StatusCode(200, listDescuentosXConvenio);
            }
            else
            {
                return StatusCode(501);
            }

         
        }

        /// <summary>
        /// Obtiene Una Lista de Productos Comerciales Por el ID Convenio y ID Tipo Empleado
        /// </summary>
        /// <remarks>
        /// Busca los Productos Comerciales Asignados al ID Convenio y el ID Tipo Empleado
        /// </remarks>
        /// <response code="200">OK. Devuelve Una Lista de Productos Comerciales.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetListProductosByIdConvenio/{IdConvenio},{idTipoEmpleado}")]
        public IActionResult GetProductosXConvenio(int IdConvenio, string idTipoEmpleado )
        {
            List<ProductoComercial> listaProductoComercial = new List<ProductoComercial>();


            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(IdConvenio.ToString()), "idConvenio");
            data.Add(new StringContent(idTipoEmpleado), "idTipoEmpleado");

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getProdComXCnv/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                listaProductoComercial = JsonConvert.DeserializeObject<List<ProductoComercial>>(resulString);
                return StatusCode(200, listaProductoComercial);
            }
            else
            {
                return StatusCode(501);
            }
         
        }
        /// <summary>
        /// Obtiene los datos de Limites Crediticios Por Tipo de Empleado
        /// </summary>
        /// <remarks>
        /// Busca los Datos Correspondientes al ID Convenio y ID Tipo de Empleado Para Devolver los Limites de Credito Correspondientes
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto Con los Limites Crediticios para el ID Y ID TIpo Empleado de Entrada.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetLimiteByIdTipoEmpleado/{IdConvenio},{IdTipoEmpleado}")]
        public IActionResult GetLimiteXTipoEmpleado(int IdConvenio ,string IdTipoEmpleado)
        {
            LimitesConvenioEmpleado limitesConvenioEmpleado = new LimitesConvenioEmpleado();


            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(IdConvenio.ToString()), "idConvenio");
            data.Add(new StringContent(IdTipoEmpleado), "idTipoEmpleado");

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getLimXTipoEmpleados/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                limitesConvenioEmpleado = JsonConvert.DeserializeObject<LimitesConvenioEmpleado>(resulString);
                return StatusCode(200, limitesConvenioEmpleado);
            }
            else
            {
                return StatusCode(501);
            }
         
        }

        /// <summary>
        /// Obtiene el Objeto Tarifa  Con los datos de la Tarifa Por ID Convenio Y ID Tipo De Empleado 
        /// </summary>
        /// <remarks>
        /// Busca los Datos Referentes a la Tarifa Por el Tipo de Empleado Ingresado
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto Con los datos de la Tarifa y Tarifa Por Empleado .</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetTarifa/{IdConvenio},{IdTipoEmpleado},{IdProductoComercial}")]
        public IActionResult GetTarifaXTipoEmpleado(int IdConvenio,string IdTipoEmpleado,string IdProductoComercial)
        {
            TarifaTIpoEmpleado tarifaXTEmpleado = new TarifaTIpoEmpleado();


            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(IdConvenio.ToString()), "idConvenio");
            data.Add(new StringContent(IdTipoEmpleado), "idTipoEmpleado");
            data.Add(new StringContent(IdProductoComercial), "idProductoComercial");

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getTarifaXTEmpleado/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                tarifaXTEmpleado = JsonConvert.DeserializeObject<TarifaTIpoEmpleado>(resulString);
                return StatusCode(200, tarifaXTEmpleado);
            }
            else
            {
                return StatusCode(501);
            }
           
        }

        //[ApiExplorerSettings(IgnoreApi = true)]

        /// <summary>
        /// Obtiene  Ingresos y Egresos Generales 
        /// </summary>
        /// <remarks>
        /// Busca los datos Correspondientes
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetIngresosEgresos/{IdConcepto},{CodiTipoIE}")]
        public IActionResult GetOtrosIngresosEgresos(int IdConcepto,string CodiTipoIE)
        {
            List<IngresosEgresos> listaIngresosEgresos = new List<IngresosEgresos>();
           
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(IdConcepto.ToString()), "idConcepto");
            data.Add(new StringContent(CodiTipoIE), "codTipoIE");
          

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getIngresosEgresos/", data).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                listaIngresosEgresos = JsonConvert.DeserializeObject<List<IngresosEgresos>>(resulString);
                return StatusCode(200, listaIngresosEgresos);
            }
            else
            {
                return StatusCode(501);
            }


        }

        //[ApiExplorerSettings(IgnoreApi = true)]

        /// <summary>
        /// Obtiene la Configuracion de Dominios por Tarifa 
        /// </summary>
        /// <remarks>
        /// Busca los datos Correspondientes al ID Finalidad
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetConfigDominios/{IdTarifa},{cod_Param_Producto}")]
        public IActionResult GetConfiguracionDominiosXTarifa(string IdTarifa,string  cod_Param_Producto)
        {
            List<DominiosXTarifa> listaDominiosXTarifa = new List<DominiosXTarifa>();
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            data.Add(new StringContent(IdTarifa), "idTarifa");
            data.Add(new StringContent(cod_Param_Producto), "cod_Param_Producto");

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getDomiProdTarifa/", data).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                listaDominiosXTarifa = JsonConvert.DeserializeObject<List<DominiosXTarifa>>(resulString);
                return StatusCode(200, listaDominiosXTarifa);
            }
            else
            {
                return StatusCode(501);
            }

        }

        /// <summary>
        /// Busca La Primera Amortizacion del Credito Por  ID Tarifa Convenio, Cod Frecuencia, Fecha Operacion 
        /// </summary>
        /// <remarks>
        /// Calcula la Primera Amortizacion deacuerdo a los Parametros de Entrada
        /// </remarks>
        /// <response code="200">OK. Devuelve el Dato de la Primera Amortizacion.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetFirtsAmortizacionCredito/{idTarifaConvenio},{codFrecuencia},{fechaOperacion}")]
        public IActionResult GetFechaPrimeraAmortizacion(int idTarifaConvenio,string codFrecuencia,string  fechaOperacion )
        {
            FechaPrimeraAmortizacion fechaPrimeraAmortizacion = null;

            return StatusCode(200,fechaPrimeraAmortizacion);
        }

        /// <summary>
        /// Obtener Formato De Consulta Buro de Credito 
        /// </summary>
        /// <remarks>
        /// Generar Formato de Consulta a Buro de Credito en Base 64
        /// </remarks>
        /// <response code="200">OK. Devuelve el Documento Generado en Base 64.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("CreateFormatoConsultaBC")]
        public IActionResult GetFormatoConsultaBC(Boolean vacio )
        {
            return StatusCode(200);
        }

        /// <summary>
        /// Obiene las Ofertas de La Simulacion Realizada
        /// </summary>
        /// <remarks>
        /// Calcula las Ofertas Adecuadas para la Simulacion Ejecutada y Devuelve una lista de ofertas
        /// </remarks>
        /// <response code="200">OK. Devuelve Una Lista De las Ofertas Ofrecidas .</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpPost("GetListOfertasSimulacion")]
        public IActionResult PostCotizar(ExtraeOfertas extraeOfertas)
        {
            List<Ofertas> listaOfertas = new List<Ofertas>();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            MultipartFormDataContent data = new MultipartFormDataContent();
            
            data.Add(new StringContent(extraeOfertas.IdCotizacion.ToString()), "vIdCotizacion");
            data.Add(new StringContent(extraeOfertas.IdProductoComercial), "vIdProductoComercial");
            data.Add(new StringContent(extraeOfertas.IdTarifa), "vIdTarifa");
            data.Add(new StringContent(extraeOfertas.Importe.ToString()), "vImporte");
            data.Add(new StringContent(extraeOfertas.Num_Cuotas.ToString()), "vNum_Cuotas");
            data.Add(new StringContent(extraeOfertas.Cod_UDM.ToString()), "vCod_UDM");
            data.Add(new StringContent(extraeOfertas.Tasa_Int_Mes.ToString()), "vTasa_Int_Mes");
            data.Add(new StringContent(extraeOfertas.Factor_Iva.ToString()), "vFactor_Iva");
            data.Add(new StringContent(extraeOfertas.Fecha_Inicio.ToString("yyyy-MM-dd")), "vFecha_Inicio");
            data.Add(new StringContent(extraeOfertas.Fecha_Prim_Liq.ToString("yyyy-MM-dd")), "vFecha_Prim_Liq");
            data.Add(new StringContent(extraeOfertas.Capacidad_Pago.ToString()), "vCapacidad_Pago");
            data.Add(new StringContent(extraeOfertas.Capacidad_Descuento.ToString()), "vCapacidad_Descuento");
            data.Add(new StringContent(extraeOfertas.Ind_Oferta_Plazo.ToString()), "vInd_Oferta_Plazo");
            data.Add(new StringContent(extraeOfertas.Ind_Oferta_Monto.ToString()), "vInd_Oferta_Monto");
            data.Add(new StringContent(extraeOfertas.Importe_Max.ToString()), "vImporte_Max");
            data.Add(new StringContent(extraeOfertas.Fecha_Limite.ToString("yyyy-MM-dd")), "vFecha_Limite");
            data.Add(new StringContent(extraeOfertas.Num_Cuotas_Max.ToString()), "vNum_Cuotas_Max");

            var request = httpClient.PostAsync("https://originacion.aprecia.com.mx:9201/Cotiza/getOfertas/",data).Result;
            if (request.IsSuccessStatusCode)
            {
                var resulString = request.Content.ReadAsStringAsync().Result;
                listaOfertas = JsonConvert.DeserializeObject<List<Ofertas>>(resulString);
                return StatusCode(200, listaOfertas);
            }
            else
            {
                return StatusCode(501);
            }

           
        }

        /// <summary>
        /// Guarda Una Cotizacion De la Simulacion Aceptada
        /// </summary>
        /// <remarks>
        /// Guarda una Cotizacion 
        /// </remarks>
        /// <response code="302"> Se Guardo la Cotizacion Realizada</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpPost("SaveCotizacion")]
        public IActionResult GetEstatusGuardarCotizacion( )
        {


            return StatusCode(200);
        }

        /// <summary>
        /// Cancelar Cotizacion Por ID Cotizacion
        /// </summary>
        /// <remarks>
        /// Permite Eliminar una Cotizacion 
        /// </remarks>
        /// <response code="302">Cancelo la Cotizacion</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpDelete("DeleteCotizacion/{IdCotizacion}")]
        public IActionResult DeleteCotizacionByID(int IdCotizacion)
        {
            return StatusCode(200);
        }


      
    }
}
