using System;
using MySql.Data.MySqlClient; // Referencia OBLIGATORIA a la librería que instalamos en el Paso 2

namespace ClubDeportivo.Datos
{
    public class Conexion   // La clase DEBE ser pública
    {
        // Declaramos las variables privadas con los datos de nuestro servidor
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;

        private Conexion()  // Constructor: Asignamos valores a las variables
        {
            this.baseDatos = "Proyecto"; // El nombre exacto de la base de datos que creamos
            this.servidor = "localhost";
            this.puerto = "3306"; // Puerto por defecto de MySQL en XAMPP
            this.usuario = "root";
            this.clave = "12345678";
        }

        // Proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // Instanciamos una conexión
            MySqlConnection cadena = new MySqlConnection();

            // El bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        // Para evaluar la instancia de la conectividad (Patrón Singleton)
        public static Conexion getInstancia()
        {
            if (con == null) // Si la conexión está cerrada o no existe...
            {
                con = new Conexion(); // Se crea una nueva
            }
            return con;
        }
    }
}