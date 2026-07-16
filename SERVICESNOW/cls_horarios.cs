using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SERVICESNOW
{
    internal class cls_horarios
    {
        private string horaInicio;
        private string horaFinal;

        private int idHorario;

        private MySqlDataAdapter consulta;
        //usamos un command para actualizar o insertar 
        private MySqlCommand comando;
        //usamos una tabla temporal
        private DataTable tabla;

        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string HoraFinal { get => horaFinal; set => horaFinal = value; }
        public int IdHorario { get => idHorario; set => idHorario = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_horario AS Clave, hora_inicio AS 'Hora de inicio', hora_fin AS 'Hora de finalizacion' from tbl_horario;";
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
                    string sql = "SELECT id_horario AS Clave, hora_inicio AS 'Hora de inicio', hora_fin AS 'Hora de finalizacion' from tbl_horario WHERE id_horario LIKE @id_horario;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@id_horario", "%" + idHorario + "%");
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
                    string sql = @"SELECT id_horario AS Clave, hora_inicio AS 'Hora de inicio', hora_fin AS 'Hora de finalizacion' from tbl_horario;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los equipos: " + ex.Message);
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
                    string sql = "DELETE FROM tbl_horario WHERE id_horario = @id_horario;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_horario", idHorario);
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
                            string sqlN = "INSERT INTO tbl_horario(hora_inicio, hora_fin) VALUES (@hora_inicio, @hora_fin);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("hora_inicio", horaInicio);
                                comando.Parameters.AddWithValue("hora_fin", horaFinal);

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
                            string sqlA = "UPDATE tbl_horario C SET C.hora_inicio = @hora_inicio, C.hora_fin = @hora_fin WHERE C.id_horario = @id_horario;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("id_horario", idHorario);
                                comando.Parameters.AddWithValue("hora_inicio", horaInicio);
                                comando.Parameters.AddWithValue("hora_fin", horaFinal);
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
