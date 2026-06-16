using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class CuotaRepositorio
    {
        /// <summary>
        /// Llama al procedimiento Cobrar_Cuota_Socio para registrar pago de la cuota más próxima.
        /// Devuelve: "1" pago ok, "0" no hay cuotas pendientes, "-1: ..." error.
        /// </summary>
        public string CobrarCuotaSocio(int idSocio, DateTime fechaPago)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Cobrar_Cuota_Socio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_idSocio", MySqlDbType.Int32).Value = idSocio;
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
