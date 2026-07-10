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

        public static int rol;

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idRol FROM usuarios " +
                                 "WHERE matricula = @matricula AND contrasena = @contrasena;";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@matricula", matricula);
                        consulta.Parameters.AddWithValue("@contrasena", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                 rol = resultado.GetInt32("idRol");

                                string nombreRol = rol switch
                                {
                                    1 => "Administrador",
                                    2 => "Recepcionista",
                                    _ => "Desconocido"
                                };

                                MessageBox.Show("Tu perfil es: " + nombreRol, "Sistema");
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
    }
}
