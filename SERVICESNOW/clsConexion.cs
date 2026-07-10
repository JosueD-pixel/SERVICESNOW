using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SERVICESNOW
{
    internal class clsConexion
    {
        private string host = "localhost";
        private string bd = "servicesnow";
        private string usuario = "root";
        private string password = "";
        private string puerto = "3306";

        private string cadenaConexion => $"server= {host};database={bd};user={usuario};password={password};port={puerto}";

        //Método Abrir conexcion
        public MySqlConnection AbrirConexion()
        {
            var conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectarse a la base de datos" + ex.Message, ex);
            }

        }
        //Netodo Cerrar Conexion
        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexion con la base de datos" + (ex.Message, ex));
            }
        }
    }
}
