using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using Originacion.Models.BuroCredito;
using System.Data.SqlClient;

namespace Originacion.Models.Catalogos.BuroCredito
{
    public class GestorBuroCredito
    {
        public IConfiguration configuration;

        public GestorBuroCredito(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public int postBuroCreditoNombre(List<CnsBcNombre> cnsBcNombre)
        {

            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "proc_Orgn_BC_Nombre_Add_Update";

                foreach (CnsBcNombre item in cnsBcNombre)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@pk_Nombre", SqlDbType.Int).Value = item.PkNombre;
                    cmd.Parameters.Add("@NumeroControlConsulta", SqlDbType.VarChar).Value = item.NumeroControlConsulta;
                    cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar).Value = item.ApellidoPaterno;
                    cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar).Value = item.ApellidoMaterno;
                    cmd.Parameters.Add("@ApellidoAdicional", SqlDbType.VarChar).Value = item.ApellidoAdicional;
                    cmd.Parameters.Add("@PrimerNombre", SqlDbType.VarChar).Value = item.PrimerNombre;
                    cmd.Parameters.Add("@SegundoNombre", SqlDbType.VarChar).Value = item.SegundoNombre;
                    cmd.Parameters.Add("@FechaNacimiento", SqlDbType.VarChar).Value = item.FechaNacimiento;
                    cmd.Parameters.Add("@RFC", SqlDbType.VarChar).Value = item.Rfc;
                    cmd.Parameters.Add("@Prefijo", SqlDbType.VarChar).Value = item.Prefijo;
                    cmd.Parameters.Add("@Sufijo", SqlDbType.VarChar).Value = item.Sufijo;
                    cmd.Parameters.Add("@Nacionalidad", SqlDbType.VarChar).Value = item.Nacionalidad;
                    cmd.Parameters.Add("@Residencia", SqlDbType.VarChar).Value = item.Residencia;
                    cmd.Parameters.Add("@NumeroLicenciaConducir", SqlDbType.VarChar).Value = item.NumeroLicenciaConducir;
                    cmd.Parameters.Add("@EstadoCivil", SqlDbType.VarChar).Value = item.EstadoCivil;
                    cmd.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = item.Sexo;
                    cmd.Parameters.Add("@NumeroCedulaProfesional", SqlDbType.VarChar).Value = item.NumeroCedulaProfesional;
                    cmd.Parameters.Add("@NumeroRegistroElectoral", SqlDbType.VarChar).Value = item.NumeroRegistroElectoral;
                    cmd.Parameters.Add("@ClaveImpuestosOtroPais", SqlDbType.VarChar).Value = item.ClaveImpuestosOtroPais;
                    cmd.Parameters.Add("@ClaveOtroPais", SqlDbType.VarChar).Value = item.ClaveOtroPais;
                    cmd.Parameters.Add("@NumeroDependientes", SqlDbType.VarChar).Value = item.NumeroDependientes;
                    cmd.Parameters.Add("@EdadesDependientes", SqlDbType.VarChar).Value = item.EdadesDependientes;
                    cmd.Parameters.Add("@FechaRecepcionInformacionDependientes", SqlDbType.VarChar).Value = item.FechaRecepcionInformacionDependientes;
                    cmd.Parameters.Add("@FechaDefuncion", SqlDbType.VarChar).Value = item.FechaDefuncion;
                    res += cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return res;
        }


        public int postBuroCreditoResumen(List<CnsBcResumenReporte> cnsBcResumenReporte)
        {

            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.CommandText = "proc_Orgn_BC_Resumen_Add_Update";
                conn.Open();
                foreach (CnsBcResumenReporte item in cnsBcResumenReporte)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@pk_ResumenReporte", SqlDbType.Int).Value = item.PkResumenReporte;
                    cmd.Parameters.Add("@NumeroControlConsulta", SqlDbType.VarChar).Value = item.NumeroControlConsulta;
                    cmd.Parameters.Add("@FechaIngresoBD", SqlDbType.VarChar).Value = item.FechaIngresoBd;
                    cmd.Parameters.Add("@NumeroMOP7", SqlDbType.VarChar).Value = item.NumeroMop7;
                    cmd.Parameters.Add("@NumeroMOP6", SqlDbType.VarChar).Value = item.NumeroMop6;
                    cmd.Parameters.Add("@NumeroMOP5", SqlDbType.VarChar).Value = item.NumeroMop5;
                    cmd.Parameters.Add("@NumeroMOP4", SqlDbType.VarChar).Value = item.NumeroMop4;
                    cmd.Parameters.Add("@NumeroMOP3", SqlDbType.VarChar).Value = item.NumeroMop3;
                    cmd.Parameters.Add("@NumeroMOP2", SqlDbType.VarChar).Value = item.NumeroMop2;
                    cmd.Parameters.Add("@NumeroMOP1", SqlDbType.VarChar).Value = item.NumeroMop1;
                    cmd.Parameters.Add("@NumeroMOP0", SqlDbType.VarChar).Value = item.NumeroMop0;
                    cmd.Parameters.Add("@NumeroMOPUR", SqlDbType.VarChar).Value = item.NumeroMopur;
                    cmd.Parameters.Add("@NumeroCuentas", SqlDbType.VarChar).Value = item.NumeroCuentas;
                    cmd.Parameters.Add("@CuentasPagosFijosHipotecas", SqlDbType.VarChar).Value = item.CuentasPagosFijosHipotecas;
                    cmd.Parameters.Add("@CuentasRevolventesAbiertas", SqlDbType.VarChar).Value = item.CuentasRevolventesAbiertas;
                    cmd.Parameters.Add("@CuentasCerradas", SqlDbType.VarChar).Value = item.CuentasCerradas;
                    cmd.Parameters.Add("@CuentasNegativasActuales", SqlDbType.VarChar).Value = item.CuentasNegativasActuales;
                    cmd.Parameters.Add("@CuentasClavesHistoriaNegativa", SqlDbType.VarChar).Value = item.CuentasClavesHistoriaNegativa;
                    cmd.Parameters.Add("@CuentasDisputa", SqlDbType.VarChar).Value = item.CuentasDisputa;
                    cmd.Parameters.Add("@NumeroSolicitudesUltimos6Meses", SqlDbType.VarChar).Value = item.NumeroSolicitudesUltimos6Meses;
                    cmd.Parameters.Add("@NuevaDireccionReportadaUltimos60Dias", SqlDbType.VarChar).Value = item.NuevaDireccionReportadaUltimos60Dias;
                    cmd.Parameters.Add("@MensajesAlerta", SqlDbType.VarChar).Value = item.MensajesAlerta;
                    cmd.Parameters.Add("@ExistenciaDeclaracionesConsumidor", SqlDbType.VarChar).Value = item.ExistenciaDeclaracionesConsumidor;
                    cmd.Parameters.Add("@TipoMoneda", SqlDbType.VarChar).Value = item.TipoMoneda;
                    cmd.Parameters.Add("@TotalCreditosMaximosRevolventes", SqlDbType.VarChar).Value = item.TotalCreditosMaximosRevolventes;
                    cmd.Parameters.Add("@TotalLimitesCreditoRevolventes", SqlDbType.VarChar).Value = item.TotalLimitesCreditoRevolventes;
                    cmd.Parameters.Add("@TotalSaldosActualesRevolventes", SqlDbType.VarChar).Value = item.TotalSaldosActualesRevolventes;
                    cmd.Parameters.Add("@TotalSaldosVencidosRevolventes", SqlDbType.VarChar).Value = item.TotalSaldosVencidosRevolventes;
                    cmd.Parameters.Add("@TotalPagosRevolventes", SqlDbType.VarChar).Value = item.TotalPagosRevolventes;
                    cmd.Parameters.Add("@PctLimiteCreditoUtilizadoRevolventes", SqlDbType.VarChar).Value = item.PctLimiteCreditoUtilizadoRevolventes;
                    cmd.Parameters.Add("@TotalCreditosMaximosPagosFijos", SqlDbType.VarChar).Value = item.TotalCreditosMaximosPagosFijos;
                    cmd.Parameters.Add("@TotalSaldosActualesPagosFijos", SqlDbType.VarChar).Value = item.TotalSaldosActualesPagosFijos;
                    cmd.Parameters.Add("@TotalSaldosVencidosPagosFijos", SqlDbType.VarChar).Value = item.TotalSaldosVencidosPagosFijos;
                    cmd.Parameters.Add("@TotalPagosPagosFijos", SqlDbType.VarChar).Value = item.TotalPagosPagosFijos;
                    cmd.Parameters.Add("@NumeroMOP96", SqlDbType.VarChar).Value = item.NumeroMop96;
                    cmd.Parameters.Add("@NumeroMOP97", SqlDbType.VarChar).Value = item.NumeroMop97;
                    cmd.Parameters.Add("@NumeroMOP99", SqlDbType.VarChar).Value = item.NumeroMop99;
                    cmd.Parameters.Add("@FechaAperturaCuentaMasAntigua", SqlDbType.VarChar).Value = item.FechaAperturaCuentaMasAntigua;
                    cmd.Parameters.Add("@FechaAperturaCuentaMasReciente", SqlDbType.VarChar).Value = item.FechaAperturaCuentaMasReciente;
                    cmd.Parameters.Add("@TotalSolicitudesReporte", SqlDbType.VarChar).Value = item.TotalSolicitudesReporte;
                    cmd.Parameters.Add("@FechaSolicitudReporteMasReciente", SqlDbType.VarChar).Value = item.FechaSolicitudReporteMasReciente;
                    cmd.Parameters.Add("@NumeroTotalCuentasDespachoCobranza", SqlDbType.VarChar).Value = item.NumeroTotalCuentasDespachoCobranza;
                    cmd.Parameters.Add("@FechaAperturaCuentaMasRecienteDespachoCobranza", SqlDbType.VarChar).Value = item.FechaAperturaCuentaMasRecienteDespachoCobranza;
                    cmd.Parameters.Add("@NumeroTotalSolicitudesDespachosCobranza", SqlDbType.VarChar).Value = item.NumeroTotalSolicitudesDespachosCobranza;
                    cmd.Parameters.Add("@FechaSolicitudMasRecienteDespachoCobranza", SqlDbType.VarChar).Value = item.FechaSolicitudMasRecienteDespachoCobranza;
                    res += cmd.ExecuteNonQuery();
                }



                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return res;
        }

        public int postBuroCuenta(List<CnsBcCuenta> cnsBcCuentas)
        {

            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.CommandText = "proc_Orgn_BC_Cuenta_Add_Update";
                conn.Open();
                foreach (CnsBcCuenta item in cnsBcCuentas)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@pk_Cuenta", SqlDbType.Int).Value = item.pkCuenta;
                    cmd.Parameters.Add("@NumeroControlConsulta", SqlDbType.VarChar).Value = item.numeroControlConsulta;
                    cmd.Parameters.Add("@FechaActualizacion", SqlDbType.VarChar).Value = item.fechaActualizacion;
                    cmd.Parameters.Add("@NombreOtorgante", SqlDbType.VarChar).Value = item.nombreOtorgante;
                    cmd.Parameters.Add("@TipoCuenta", SqlDbType.VarChar).Value = item.tipoCuenta;
                    cmd.Parameters.Add("@TipoContrato", SqlDbType.VarChar).Value = item.tipoContrato;
                    cmd.Parameters.Add("@NumeroPagos", SqlDbType.VarChar).Value = item.numeroPagos;
                    cmd.Parameters.Add("@FrecuenciaPagos", SqlDbType.VarChar).Value = item.frecuenciaPagos;
                    cmd.Parameters.Add("@MontoPagar", SqlDbType.VarChar).Value = item.montoPagar;
                    cmd.Parameters.Add("@FechaAperturaCuenta", SqlDbType.VarChar).Value = item.fechaAperturaCuenta;
                    cmd.Parameters.Add("@FechaUltimoPago", SqlDbType.VarChar).Value = item.fechaUltimoPago;
                    cmd.Parameters.Add("@FechaUltimaCompra", SqlDbType.VarChar).Value = item.fechaUltimaCompra;
                    cmd.Parameters.Add("@FechaCierreCuenta", SqlDbType.VarChar).Value = item.fechaCierreCuenta;
                    cmd.Parameters.Add("@FechaReporte", SqlDbType.VarChar).Value = item.fechaReporte;
                    cmd.Parameters.Add("@FormaPagoActual", SqlDbType.VarChar).Value = item.formaPagoActual;
                    cmd.Parameters.Add("@HistoricoPagos", SqlDbType.VarChar).Value = item.historicoPagos;
                    cmd.Parameters.Add("@ClaveObservacion", SqlDbType.VarChar).Value = item.claveObservacion == null ? "" : item.claveObservacion.ToString();
                    cmd.Parameters.Add("@pagoMensual", SqlDbType.VarChar).Value = item.pagoMensual;
                    cmd.Parameters.Add("@indicador", SqlDbType.VarChar).Value = item.indicador;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return res;
        }

        public int postBuroCreditoScoreBC(List<CnsBcScoreBc> cnsBcScoreBc)
        {

            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.CommandText = "proc_Orgn_BC_ScoreBC_Add_Update";
                conn.Open();
                foreach (CnsBcScoreBc item in cnsBcScoreBc)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@pk_ScoreBC", SqlDbType.Int).Value = item.PkScoreBc;
                    cmd.Parameters.Add("@NumeroControlConsulta", SqlDbType.VarChar).Value = item.NumeroControlConsulta;
                    cmd.Parameters.Add("@nombreScore", SqlDbType.VarChar).Value = item.NombreScore;
                    cmd.Parameters.Add("@CodigoScore", SqlDbType.VarChar).Value = item.CodigoScore;
                    cmd.Parameters.Add("@ValorScore", SqlDbType.VarChar).Value = item.ValorScore;
                    cmd.Parameters.Add("@CodigoRazon", SqlDbType.VarChar).Value = item.CodigoRazon;
                    cmd.Parameters.Add("@CodigoError", SqlDbType.VarChar).Value = item.CodigoError;
                    res = cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return res;
        }

        public List<CnsBcNombre> getBuroCreditoNombre(string numeroControlConsulta)
        {
            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);

            List<CnsBcNombre> listCnsBcNombres = new List<CnsBcNombre>();
            CnsBcNombre cnsBcNombre = new CnsBcNombre();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_Orgn_BC_Nombre_Extrae";
                cmd.Parameters.Add("@numeroControlConsulta", SqlDbType.Int).Value = numeroControlConsulta;

                cmd.Connection = conn;
                conn.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cnsBcNombre = new CnsBcNombre();

                    cnsBcNombre.PkNombre = (int)reader["pk_Nombre"];
                    cnsBcNombre.NumeroControlConsulta = reader["NumeroControlConsulta"].ToString();
                    cnsBcNombre.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                    cnsBcNombre.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                    cnsBcNombre.ApellidoAdicional = reader["ApellidoAdicional"].ToString();
                    cnsBcNombre.PrimerNombre = reader["PrimerNombre"].ToString();
                    cnsBcNombre.SegundoNombre = reader["SegundoNombre"].ToString();
                    cnsBcNombre.FechaNacimiento = reader["FechaNacimiento"].ToString();
                    cnsBcNombre.Rfc = reader["RFC"].ToString();
                    cnsBcNombre.Prefijo = reader["Prefijo"].ToString();
                    cnsBcNombre.Sufijo = reader["Sufijo"].ToString();
                    cnsBcNombre.Nacionalidad = reader["Nacionalidad"].ToString();
                    cnsBcNombre.Residencia = reader["Residencia"].ToString();
                    cnsBcNombre.NumeroLicenciaConducir = reader["NumeroLicenciaConducir"].ToString();
                    cnsBcNombre.EstadoCivil = reader["EstadoCivil"].ToString();
                    cnsBcNombre.Sexo = reader["Sexo"].ToString();
                    cnsBcNombre.NumeroCedulaProfesional = reader["NumeroCedulaProfesional"].ToString();
                    cnsBcNombre.NumeroRegistroElectoral = reader["NumeroRegistroElectoral"].ToString();
                    cnsBcNombre.ClaveImpuestosOtroPais = reader["ClaveImpuestosOtroPais"].ToString();
                    cnsBcNombre.ClaveOtroPais = reader["ClaveOtroPais"].ToString();
                    cnsBcNombre.NumeroDependientes = reader["NumeroDependientes"].ToString();
                    cnsBcNombre.EdadesDependientes = reader["EdadesDependientes"].ToString();
                    cnsBcNombre.FechaRecepcionInformacionDependientes = reader["FechaRecepcionInformacionDependientes"].ToString();
                    cnsBcNombre.FechaDefuncion = reader["FechaDefuncion"].ToString();

                    listCnsBcNombres.Add(cnsBcNombre);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return listCnsBcNombres;
        }


        public List<CnsBcResumenReporte> getBuroCreditoResumen(string numeroControlConsulta)
        {
            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);

            List<CnsBcResumenReporte> listCnsBcResumenReporte = new List<CnsBcResumenReporte>();
            CnsBcResumenReporte cnsBcResumenReporte = new CnsBcResumenReporte();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_Orgn_BC_ResumenReporte_Extrae";
                cmd.Parameters.Add("@numeroControlConsulta", SqlDbType.Int).Value = numeroControlConsulta;

                cmd.Connection = conn;
                conn.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cnsBcResumenReporte = new CnsBcResumenReporte();

                    cnsBcResumenReporte.PkResumenReporte = (int)reader["pk_ResumenReporte"];
                    cnsBcResumenReporte.NumeroControlConsulta = reader["NumeroControlConsulta"].ToString();
                    cnsBcResumenReporte.FechaIngresoBd = reader["FechaIngresoBD"].ToString();
                    cnsBcResumenReporte.NumeroMop7 = reader["NumeroMOP7"].ToString();
                    cnsBcResumenReporte.NumeroMop6 = reader["NumeroMOP6"].ToString();
                    cnsBcResumenReporte.NumeroMop5 = reader["NumeroMOP5"].ToString();
                    cnsBcResumenReporte.NumeroMop4 = reader["NumeroMOP4"].ToString();
                    cnsBcResumenReporte.NumeroMop3 = reader["NumeroMOP3"].ToString();
                    cnsBcResumenReporte.NumeroMop2 = reader["NumeroMOP2"].ToString();
                    cnsBcResumenReporte.NumeroMop1 = reader["NumeroMOP1"].ToString();
                    cnsBcResumenReporte.NumeroMop0 = reader["NumeroMOP0"].ToString();
                    cnsBcResumenReporte.NumeroMopur = reader["NumeroMOPUR"].ToString();
                    cnsBcResumenReporte.NumeroCuentas = reader["NumeroCuentas"].ToString();
                    cnsBcResumenReporte.CuentasPagosFijosHipotecas = reader["CuentasPagosFijosHipotecas"].ToString();
                    cnsBcResumenReporte.CuentasRevolventesAbiertas = reader["CuentasRevolventesAbiertas"].ToString();
                    cnsBcResumenReporte.CuentasCerradas = reader["CuentasCerradas"].ToString();
                    cnsBcResumenReporte.CuentasNegativasActuales = reader["CuentasNegativasActuales"].ToString();
                    cnsBcResumenReporte.CuentasClavesHistoriaNegativa = reader["CuentasClavesHistoriaNegativa"].ToString();
                    cnsBcResumenReporte.CuentasDisputa = reader["CuentasDisputa"].ToString();
                    cnsBcResumenReporte.NumeroSolicitudesUltimos6Meses = reader["NumeroSolicitudesUltimos6Meses"].ToString();
                    cnsBcResumenReporte.NuevaDireccionReportadaUltimos60Dias = reader["NuevaDireccionReportadaUltimos60Dias"].ToString();
                    cnsBcResumenReporte.MensajesAlerta = reader["MensajesAlerta"].ToString();
                    cnsBcResumenReporte.ExistenciaDeclaracionesConsumidor = reader["ExistenciaDeclaracionesConsumidor"].ToString();
                    cnsBcResumenReporte.TipoMoneda = reader["TipoMoneda"].ToString();
                    cnsBcResumenReporte.TotalCreditosMaximosRevolventes = reader["TotalCreditosMaximosRevolventes"].ToString();
                    cnsBcResumenReporte.TotalLimitesCreditoRevolventes = reader["TotalLimitesCreditoRevolventes"].ToString();
                    cnsBcResumenReporte.TotalSaldosActualesRevolventes = reader["TotalSaldosActualesRevolventes"].ToString();
                    cnsBcResumenReporte.TotalSaldosVencidosRevolventes = reader["TotalSaldosVencidosRevolventes"].ToString();
                    cnsBcResumenReporte.TotalPagosRevolventes = reader["TotalPagosRevolventes"].ToString();
                    cnsBcResumenReporte.PctLimiteCreditoUtilizadoRevolventes = reader["PctLimiteCreditoUtilizadoRevolventes"].ToString();
                    cnsBcResumenReporte.TotalCreditosMaximosPagosFijos = reader["TotalCreditosMaximosPagosFijos"].ToString();
                    cnsBcResumenReporte.TotalSaldosActualesPagosFijos = reader["TotalSaldosActualesPagosFijos"].ToString();
                    cnsBcResumenReporte.TotalSaldosVencidosPagosFijos = reader["TotalSaldosVencidosPagosFijos"].ToString();
                    cnsBcResumenReporte.TotalPagosPagosFijos = reader["TotalPagosPagosFijos"].ToString();
                    cnsBcResumenReporte.NumeroMop96 = reader["NumeroMOP96"].ToString();
                    cnsBcResumenReporte.NumeroMop97 = reader["NumeroMOP97"].ToString();
                    cnsBcResumenReporte.NumeroMop99 = reader["NumeroMOP99"].ToString();
                    cnsBcResumenReporte.FechaAperturaCuentaMasAntigua = reader["FechaAperturaCuentaMasAntigua"].ToString();
                    cnsBcResumenReporte.FechaAperturaCuentaMasReciente = reader["FechaAperturaCuentaMasReciente"].ToString();
                    cnsBcResumenReporte.TotalSolicitudesReporte = reader["TotalSolicitudesReporte"].ToString();
                    cnsBcResumenReporte.FechaSolicitudReporteMasReciente = reader["FechaSolicitudReporteMasReciente"].ToString();
                    cnsBcResumenReporte.NumeroTotalCuentasDespachoCobranza = reader["NumeroTotalCuentasDespachoCobranza"].ToString();
                    cnsBcResumenReporte.FechaAperturaCuentaMasRecienteDespachoCobranza = reader["FechaAperturaCuentaMasRecienteDespachoCobranza"].ToString();
                    cnsBcResumenReporte.NumeroTotalSolicitudesDespachosCobranza = reader["NumeroTotalSolicitudesDespachosCobranza"].ToString();
                    cnsBcResumenReporte.FechaSolicitudMasRecienteDespachoCobranza = reader["FechaSolicitudMasRecienteDespachoCobranza"].ToString();

                    listCnsBcResumenReporte.Add(cnsBcResumenReporte);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return listCnsBcResumenReporte;
        }

        public List<CnsBcCuenta> getBuroCreditoCuenta(string numeroControlConsulta)
        {
            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);

            List<CnsBcCuenta> listCnsBcCuentas = new List<CnsBcCuenta>();
            CnsBcCuenta cnsBcCuenta = new CnsBcCuenta();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_Orgn_BC_Cuenta_Extrae";
                cmd.Parameters.Add("@numeroControlConsulta", SqlDbType.Int).Value = numeroControlConsulta;

                cmd.Connection = conn;
                conn.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cnsBcCuenta = new CnsBcCuenta();

                    cnsBcCuenta.pkCuenta = (int)reader["pk_Cuenta"];
                    cnsBcCuenta.numeroControlConsulta = reader["NumeroControlConsulta"].ToString();
                    cnsBcCuenta.fechaActualizacion = reader["FechaActualizacion"].ToString();
                    cnsBcCuenta.nombreOtorgante = reader["NombreOtorgante"].ToString();
                    cnsBcCuenta.tipoCuenta = reader["TipoCuenta"].ToString();
                    cnsBcCuenta.tipoContrato = reader["TipoContrato"].ToString();
                    cnsBcCuenta.numeroPagos = reader["NumeroPagos"].ToString();
                    cnsBcCuenta.frecuenciaPagos = reader["FrecuenciaPagos"].ToString();
                    cnsBcCuenta.montoPagar = reader["MontoPagar"].ToString();
                    cnsBcCuenta.fechaAperturaCuenta = reader["FechaAperturaCuenta"].ToString();
                    cnsBcCuenta.fechaUltimoPago = reader["FechaUltimoPago"].ToString();
                    cnsBcCuenta.fechaUltimaCompra = reader["FechaUltimaCompra"].ToString();
                    cnsBcCuenta.fechaCierreCuenta = reader["FechaCierreCuenta"].ToString();
                    cnsBcCuenta.fechaReporte = reader["FechaReporte"].ToString();
                    cnsBcCuenta.formaPagoActual = reader["FormaPagoActual"].ToString();
                    cnsBcCuenta.historicoPagos = reader["HistoricoPagos"].ToString();
                    cnsBcCuenta.claveObservacion = reader["ClaveObservacion"].ToString();
                    cnsBcCuenta.pagoMensual = Convert.ToDouble(reader["pagoMensual"]);
                    cnsBcCuenta.indicador = reader["indicador"].ToString();

                    listCnsBcCuentas.Add(cnsBcCuenta);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return listCnsBcCuentas;
        }

        public List<CnsBcScoreBc> getBuroCreditoScoreBC(string numeroControlConsulta)
        {
            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);

            List<CnsBcScoreBc> listcnsBcScoreBc = new List<CnsBcScoreBc>();
            CnsBcScoreBc cnsBcScoreBc = new CnsBcScoreBc();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_Orgn_BC_ScoreBC_Extrae";
                cmd.Parameters.Add("@numeroControlConsulta", SqlDbType.Int).Value = numeroControlConsulta;

                cmd.Connection = conn;
                conn.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cnsBcScoreBc = new CnsBcScoreBc();

                    cnsBcScoreBc.PkScoreBc = (int)reader["pk_ScoreBC"];
                    cnsBcScoreBc.NumeroControlConsulta = reader["NumeroControlConsulta"].ToString();
                    cnsBcScoreBc.NombreScore = reader["nombreScore"].ToString();
                    cnsBcScoreBc.CodigoScore = reader["CodigoScore"].ToString();
                    cnsBcScoreBc.ValorScore = reader["ValorScore"].ToString();
                    cnsBcScoreBc.CodigoRazon = reader["CodigoRazon"].ToString();
                    cnsBcScoreBc.CodigoError = reader["CodigoError"].ToString();
                    listcnsBcScoreBc.Add(cnsBcScoreBc);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return listcnsBcScoreBc;
        }


        public bool deleteBuroCreditoConsulta(string numeroControlConsulta)
        {
            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);

            List<CnsBcScoreBc> listcnsBcScoreBc = new List<CnsBcScoreBc>();
            CnsBcScoreBc cnsBcScoreBc = new CnsBcScoreBc();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_Orgn_BC_Consulta_Anterior_Eliminar";
                cmd.Parameters.Add("@numeroControlConsulta", SqlDbType.Int).Value = numeroControlConsulta;

                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return true;
        }

        public List<cat_PuntualidadPagoMOP> GetCat_PuntualidadPagoMOPs(string Codigo = "")
        {
            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);

            List<cat_PuntualidadPagoMOP> listacat_PuntualidadPagoMOP = new List<cat_PuntualidadPagoMOP>();
            cat_PuntualidadPagoMOP itemcat_PuntualidadPagoMOP = new cat_PuntualidadPagoMOP();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_Orgn_BC_cat_PuntualidadPagoMOP_Extrae";
                cmd.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Codigo;
                cmd.Connection = conn;
                conn.Open();
                var reader = cmd.ExecuteReader();

                UnidadMedida unidadMedida = new UnidadMedida();

                while (reader.Read())
                {
                    itemcat_PuntualidadPagoMOP = new cat_PuntualidadPagoMOP();

                    itemcat_PuntualidadPagoMOP.Codigo = reader["Codigo"].ToString();
                    itemcat_PuntualidadPagoMOP.Descripcion = reader["Descripcion"].ToString();
                    itemcat_PuntualidadPagoMOP.Descripcion_Abreviada = reader["Descripcion_Abreviada"].ToString();

                    listacat_PuntualidadPagoMOP.Add(itemcat_PuntualidadPagoMOP);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return listacat_PuntualidadPagoMOP;
        }

        public List<LineaFondeo> GetBCValidaRestricciones(
            int idConvenio
            ,string codProducto
            ,string codTipoEmpleado
            ,string numeroControlConsulta
            )
        {
            string connString = this.configuration.GetConnectionString("DBOriginacion");
            var conn = new SqlConnection(connString);

            List<LineaFondeo> listaLineaFondeos = new List<LineaFondeo>();
            LineaFondeo lineaFondeo = new LineaFondeo();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_Orgn_BC_Valida_Restricciones";
                cmd.Parameters.Add("@Id_Convenio", SqlDbType.Int).Value = idConvenio;
                cmd.Parameters.Add("@Cod_Producto", SqlDbType.Char).Value = codProducto;
                cmd.Parameters.Add("@Cod_Tipo_Empleado", SqlDbType.Char).Value = codTipoEmpleado;
                cmd.Parameters.Add("@NumeroControlConsulta", SqlDbType.VarChar).Value = numeroControlConsulta;

                cmd.Connection = conn;
                conn.Open();
                var reader = cmd.ExecuteReader();

                UnidadMedida unidadMedida = new UnidadMedida();

                while (reader.Read())
                {
                    lineaFondeo = new LineaFondeo();

                    lineaFondeo.ID_Linea_Fondeo = (int)reader["ID_Linea_Fondeo"];

                    listaLineaFondeos.Add(lineaFondeo);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Dispose();
            }

            return listaLineaFondeos;
        }
    }
}
