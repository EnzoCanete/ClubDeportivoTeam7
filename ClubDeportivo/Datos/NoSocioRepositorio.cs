using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class NoSocioRepositorio
    {
        public string NuevoNoSocioConRegistro(string dni, string nombre, string apellido, string telefono, string actividadAsignada)
        {
            try
            {
                using (var conn = Conexion.GetInstancia().CrearConexion())
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        // check persona exists
                        using (var check = new MySqlCommand("SELECT COUNT(*) FROM persona WHERE dni = @dni", conn, tran))
                        {
                            check.Parameters.Add("@dni", MySqlDbType.VarChar).Value = dni;
                            var existe = Convert.ToInt32(check.ExecuteScalar());
                            if (existe > 0)
                            {
                                tran.Rollback();
                                return "1"; // already exists
                            }
                        }

                        // insert persona
                        using (var insP = new MySqlCommand("INSERT INTO persona (dni, nombre, apellido, telefono) VALUES (@dni,@nom,@ape,@tel)", conn, tran))
                        {
                            insP.Parameters.Add("@dni", MySqlDbType.VarChar).Value = dni;
                            insP.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nombre;
                            insP.Parameters.Add("@ape", MySqlDbType.VarChar).Value = apellido;
                            insP.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telefono ?? string.Empty;
                            insP.ExecuteNonQuery();
                        }

                        // insert nosocio (schema only has persona_dni now)
                        using (var insN = new MySqlCommand("INSERT INTO nosocio (persona_dni) VALUES (@dni)", conn, tran))
                        {
                            insN.Parameters.Add("@dni", MySqlDbType.VarChar).Value = dni;
                            insN.ExecuteNonQuery();
                        }

                        // get last inserted id (nroVisita)
                        long lastId = 0;
                        using (var idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn, tran))
                        {
                            lastId = Convert.ToInt64(idCmd.ExecuteScalar());
                        }

                        tran.Commit();
                        return Convert.ToString(lastId);
                    }
                }
            }
            catch (Exception ex)
            {
                return "-1: " + ex.Message;
            }
        }

        /// <summary>
        /// Llama al procedimiento almacenado Nuevo_NoSocio_Visita para registrar una visita de no socio.
        /// Devuelve: "-1: ..." en error o el nroVisita creado como string en caso de éxito.
        /// </summary>
        public string NuevoNoSocioVisita(string dni, string nombre, string apellido, string telefono, int idHorario, DateTime fechaAsistencia, decimal importe)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Nuevo_NoSocio_Visita", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_dni", MySqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value = apellido;
                comando.Parameters.Add("p_telefono", MySqlDbType.VarChar).Value = telefono ?? string.Empty;

                comando.Parameters.Add("p_idHorario", MySqlDbType.Int32).Value = idHorario;
                comando.Parameters.Add("p_fechaAsistencia", MySqlDbType.Date).Value = fechaAsistencia.Date;
                comando.Parameters.Add("p_importe", MySqlDbType.Decimal).Value = importe;

                MySqlParameter parRespuesta = new MySqlParameter();
                parRespuesta.ParameterName = "r_respuesta";
                parRespuesta.MySqlDbType = MySqlDbType.Int32;
                parRespuesta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parRespuesta);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                salida = Convert.ToString(parRespuesta.Value);
            }
            catch (Exception ex)
            {
                salida = "-1: " + ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }
    }
}
