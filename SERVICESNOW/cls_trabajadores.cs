 using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SERVICESNOW
{
    internal class cls_trabajadores
    {
        
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private string telefono;
        private string correo;
        private string cp;
        private string colonia;
        private string calle;

        private string clave_trabajador;
        private string contrasena;
        private int estado; 
        private int idRol;

        
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Clave_trabajador { get => clave_trabajador; set => clave_trabajador = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public int Estado { get => estado; set => estado = value; }




        //Adaptadores y tabla virtuales de la clase

        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;




        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"SELECT 
                             t.clave_trabajador AS Clave,
                             t.nombre AS Nombre,
                             t.apellido_paterno AS Paterno,
                             t.apellido_materno AS Materno,
                             t.telefono AS Telefono,
                             t.correo AS Correo,
                             t.codigo_postal AS CP,
                             t.calle AS Calle,
                             t.colonia AS Colonia,
                             t.estado AS Estado,
                             r.id_rol AS IdRol,
                             r.nombre_rol AS Rol,
                             t.password AS Contrasena
                      FROM tbl_trabajadores t
                      INNER JOIN tbl_roles r ON t.id_rol = r.id_rol;";


                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión: " + ex.Message);
            }
            return tabla;
        }


        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"SELECT 
                             t.clave_trabajador AS Clave,
                             t.nombre AS Nombre,
                             t.apellido_paterno AS Paterno,
                             t.apellido_materno AS Materno,
                             t.telefono AS Telefono,
                             t.correo AS Correo,
                             t.codigo_postal AS CP,
                             t.calle AS Calle,
                             t.colonia AS Colonia,
                             t.estado AS Estado,
                             r.id_rol AS IdRol,
                             r.nombre_rol AS Rol,
                             t.password AS Contrasena
                      FROM tbl_trabajadores t
                      INNER JOIN tbl_roles r ON t.id_rol = r.id_rol;";


                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@clave", "%" + clave_trabajador + "%");

                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        } // Liberar adaptador
                    } // Liberar comando
                } // Liberar conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión de la base de datos: " + ex.Message);
            }
            return tabla;
        }

        public DataTable ConsultarTodos()
        {
            DataTable tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"SELECT 
                             t.clave_trabajador AS Clave,
                             t.nombre AS Nombre,
                             t.apellido_paterno AS Paterno,
                             t.apellido_materno AS Materno,
                             t.telefono AS Telefono,
                             t.correo AS Correo,
                             t.codigo_postal AS CP,
                             t.calle AS Calle,
                             t.colonia AS Colonia,
                             t.estado AS Estado,
                             r.id_rol AS IdRol,
                             r.nombre_rol AS Rol,
                             t.password AS Contrasena
                      FROM tbl_trabajadores t
                      INNER JOIN tbl_roles r ON t.id_rol = r.id_rol;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los trabajadores: " + ex.Message);
            }

            return tabla;
        }


        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;

                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }

            }
        }

        public string Eliminar()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                { 
                    string sql = "DELETE FROM tbl_trabajadores WHERE clave_trabajador = @clave_trabajador;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@clave_trabajador", clave_trabajador);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar";
                        }
                    }//liberar las conexiones
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }

        public string GuardarActualizar(int TipoOperacion)
        {
            string msg = "";

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    switch (TipoOperacion)
                    {
                        case 0: // INSERTAR NUEVO
                            string sqlN = @"INSERT INTO tbl_trabajadores
                                   (clave_trabajador, nombre, apellido_paterno, apellido_materno,
                                    telefono, correo, password, codigo_postal, calle, colonia,
                                    estado, id_rol)
                                   VALUES
                                   (@clave, @nombre, @ap, @am, @tel, @correo, @pass,
                                    @cp, @calle, @colonia, @estado, @rol);";

                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("@clave", Clave_trabajador);
                                comando.Parameters.AddWithValue("@nombre", Nombre);
                                comando.Parameters.AddWithValue("@ap", ApellidoP);
                                comando.Parameters.AddWithValue("@am", ApellidoM);
                                comando.Parameters.AddWithValue("@tel", Telefono);
                                comando.Parameters.AddWithValue("@correo", Correo);
                                comando.Parameters.AddWithValue("@pass", Contrasena);
                                comando.Parameters.AddWithValue("@cp", Cp);
                                comando.Parameters.AddWithValue("@calle", Calle);
                                comando.Parameters.AddWithValue("@colonia", Colonia);
                                comando.Parameters.AddWithValue("@estado", Estado);
                                comando.Parameters.AddWithValue("@rol", IdRol);

                                int filas = comando.ExecuteNonQuery();
                                msg = filas > 0 ? "Registro guardado correctamente" : "No se pudo guardar el registro";
                            }
                            break;

                        case 1: // ACTUALIZAR EXISTENTE
                            string sqlA = @"UPDATE tbl_trabajadores SET
                                    nombre = @nombre,
                                    apellido_paterno = @ap,
                                    apellido_materno = @am,
                                    telefono = @tel,
                                    correo = @correo,
                                    password = @pass,
                                    codigo_postal = @cp,
                                    calle = @calle,
                                    colonia = @colonia,
                                    estado = @estado,
                                    id_rol = @rol
                                    WHERE clave_trabajador = @clave;";

                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("@clave", Clave_trabajador);
                                comando.Parameters.AddWithValue("@nombre", Nombre);
                                comando.Parameters.AddWithValue("@ap", ApellidoP);
                                comando.Parameters.AddWithValue("@am", ApellidoM);
                                comando.Parameters.AddWithValue("@tel", Telefono);
                                comando.Parameters.AddWithValue("@correo", Correo);
                                comando.Parameters.AddWithValue("@pass", Contrasena);
                                comando.Parameters.AddWithValue("@cp", Cp);
                                comando.Parameters.AddWithValue("@calle", Calle);
                                comando.Parameters.AddWithValue("@colonia", Colonia);
                                comando.Parameters.AddWithValue("@estado", Estado);
                                comando.Parameters.AddWithValue("@rol", IdRol);

                                int filas = comando.ExecuteNonQuery();
                                msg = filas > 0 ? "Registro actualizado correctamente" : "No se pudo actualizar el registro";
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en GuardarActualizar: " + ex.Message);
            }

            return msg;
        }




    }
}
