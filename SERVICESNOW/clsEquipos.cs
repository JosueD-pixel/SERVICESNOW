using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SERVICESNOW
{
    internal class clsEquipos
    {
        private string nombreEquipo;
        private bool sistemaAudio;
        private bool pizarron;
        private bool pantalla;
        private bool proyector;
        private bool red;

        private int idEquipo;

        private MySqlDataAdapter consulta;
        //usamos un command para actualizar o insertar 
        private MySqlCommand comando;
        //usamos una tabla temporal
        private DataTable tabla;

        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public bool SistemaAudio { get => sistemaAudio; set => sistemaAudio = value; }
        public bool Pizarron { get => pizarron; set => pizarron = value; }
        public bool Pantalla { get => pantalla; set => pantalla = value; }
        public bool Proyector { get => proyector; set => proyector = value; }
        public bool Red { get => red; set => red = value; }
        public int IdEquipo { get => idEquipo; set => idEquipo = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select id_equipo AS Clave, nombre AS Equipo, sistema_audio AS Audio, pizarron AS Pizarron, pantalla AS Pantalla, proyector AS Proyector, red AS Red from tbl_equipos;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberarla conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion " + ex.Message);
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
                    string sql = "select id_equipo AS Clave, nombre_equipamiento AS Equipo, sistema_audio AS Audio, pizarron AS Pizarron, pantalla AS Pantalla, proyector AS Proyector, red AS Red from tbl_equipos WHERE id_equipo LIKE @id_equipo;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@id_equipo", "%" + idEquipo + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//Liberar el adaptador
                    }//Liberar la consulta
                }//Liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos " + ex.Message);
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
                    string sql = @"
                SELECT
                    id_equipo AS Clave,
                    nombre AS Equipo,
                    sistema_audio AS Audio,
                    pizarron AS Pizarron,
                    pantalla AS Pantalla,
                    proyector AS Proyector,
                    red AS Red
                FROM tbl_equipos;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al consultar los equipos: " + ex.Message
                );
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
                    string sql = "DELETE FROM tbl_equipos WHERE id_equipo = @id_equipo;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_equipo", idEquipo);
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
                        case 0://insertarNEW
                            string sqlN = "INSERT INTO tbl_equipos(nombre, sistema_audio, pizarron, pantalla, proyector, red) VALUES (@nombre, @sistema_audio, @pizarron, @pantalla, @proyector, @red);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombre_equipamiento", nombreEquipo);
                                comando.Parameters.AddWithValue("sistema_audio", sistemaAudio);
                                comando.Parameters.AddWithValue("pizarron", pizarron);
                                comando.Parameters.AddWithValue("pantalla", pantalla);
                                comando.Parameters.AddWithValue("proyector", proyector);
                                comando.Parameters.AddWithValue("red", red);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se guardaron los datos";
                                }
                            }//Liberar la operacion de insercion
                            break;
                        case 1://ActualizarOLD
                            string sqlA = "UPDATE tbl_equipo C SET C.nombre_equipamiento = @nombre_equipamiento, C.sistema_audio = @sistema_audio, C.pizarron = @pizarron, C.pantalla = @pantalla, C.proyector = @proyector, C.red = @red WHERE C.id_equipo = @id_equipo;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("id_equipo", idEquipo);
                                comando.Parameters.AddWithValue("nombre_equipamiento", nombreEquipo);
                                comando.Parameters.AddWithValue("sistema_audio", sistemaAudio);
                                comando.Parameters.AddWithValue("pizarron", pizarron);
                                comando.Parameters.AddWithValue("pantalla", pantalla);
                                comando.Parameters.AddWithValue("proyector", proyector);
                                comando.Parameters.AddWithValue("red", red);
                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se actualizo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se actualizaron los datos";
                                }
                            }//Liberar la operacion de actualizacion
                            break;
                    }
                }//Libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        
        }
    }
}
