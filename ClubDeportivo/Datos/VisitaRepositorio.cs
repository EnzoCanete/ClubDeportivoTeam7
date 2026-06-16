using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class VisitaRepositorio
    {
        /// <summary>
        /// Llama al procedimiento Cobrar_Visita_NoSocio para registrar pago de una visita.
        /// Devuelve: "1" pago ok, "0" no existe o ya pagada, "-1: ..." error.
        /// </summary>
        public string CobrarVisitaNoSocio(int idVisitaActividad, DateTime fechaPago)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Cobrar_Visita_NoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_idVisitaActividad", MySqlDbType.Int32).Value = idVisitaActividad;
                comando.Parameters.Add("p_fechaPago", MySqlDbType.DateTime).Value = fechaPago;

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
