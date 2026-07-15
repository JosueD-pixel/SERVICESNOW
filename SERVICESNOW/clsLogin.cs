using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVICESNOW
{
    internal class clsLogin
    {
        private string matricula;
        private string password;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Password { get => password; set => password = value; }

        private static int rol;
        public string nombreRol;
        //atributo estatico
        private static bool esAdministrador;
        private static bool esRecepcionista;
        private static bool esTrabajador;

        //propiedad estatica
        public static bool EsAdministrador { get => esAdministrador; }
        public static bool EsRecepcionista { get => esRecepcionista; }
        public static bool EsTrabajador { get => EsTrabajador;  }
        public static int Rol { get => rol; set => rol = value; }

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_rol FROM tbl_trabajadores " +
                                 "WHERE clave_trabajador = @clave_trabajador AND contrasena = @contrasena;";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@clave_trabajador", matricula);
                        consulta.Parameters.AddWithValue("@contrasena", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                 rol = resultado.GetInt32("id_rol");

                                nombreRol = rol switch
                                {
                                    1 => "Administrador",
                                    2 => "Recepcionista",
                                    _ => "Desconocido"
                                };
                                AsignarPermisos();
                                if (!esAdministrador && !esRecepcionista)
                                {
                                    throw new Exception($"El perfil {nombreRol} no tiene permisos para acceder");
                                }
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña incorrectos");
                            }
                        }//Liberar MySqlDataReader
                    }//Liberar MySqlCommand
                }//Liberar MySqlConnection a traves de tu clase
            }
            catch (Exception ex)
            {
                //Si ocurre un error, lo reelanzamos para que lo capture el formulario 
                throw new Exception(ex.Message, ex);
            }
        }//fin del metodo

        public void AsignarPermisos()
        {
            switch (nombreRol)
            {
                case "Administrador":
                    esAdministrador = true;
                    esRecepcionista = false;
                    esTrabajador = false; 
                    break;
                case "Recepcionista":
                    esAdministrador = false;
                    esRecepcionista = true;
                    esTrabajador = false;
                    break;
                case "Trabajador":
                    esAdministrador = false;
                    esRecepcionista = false;
                    esTrabajador = true;
                    break;
                default:
                    esAdministrador = false;
                    esRecepcionista = false;
                    break;
            }
        }
    }
}
