using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SERVICESNOW
{
    internal class cls_roles
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }

        // Consultar todos los roles
        public DataTable ConsultarTodos()
        {
            DataTable tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_rol, nombre_rol FROM tbl_roles;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar roles: " + ex.Message);
            }

            return tabla;
        }

        public string InsertarRol(string nombreRol)
        {
            string msg = "";

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Verificar si existe
                    string sqlExiste = "SELECT COUNT(*) FROM tbl_roles WHERE nombre_rol = @nombre;";
                    using (var cmdExiste = new MySqlCommand(sqlExiste, conexion))
                    {
                        cmdExiste.Parameters.AddWithValue("@nombre", nombreRol);
                        int existe = Convert.ToInt32(cmdExiste.ExecuteScalar());

                        if (existe > 0)
                        {
                            return "El rol ya existe.";
                        }
                    }

                    // Insertar
                    string sqlInsert = "INSERT INTO tbl_roles(nombre_rol) VALUES(@nombre);";
                    using (var cmdInsert = new MySqlCommand(sqlInsert, conexion))
                    {
                        cmdInsert.Parameters.AddWithValue("@nombre", nombreRol);
                        int filas = cmdInsert.ExecuteNonQuery();

                        msg = filas > 0 ? "Rol agregado correctamente." : "No se pudo agregar el rol.";
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "Error: " + ex.Message;
            }

            return msg;
        }

    }
}
