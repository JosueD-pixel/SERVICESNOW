using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SERVICESNOW
{
    public partial class frm_horarios : Form
    {
        cls_horarios horarios;
        int idHorario;
        public frm_horarios()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frm_horarios_Load(object sender, EventArgs e)
        {
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            dgv_horarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // ajusta columnas al ancho
            dgv_horarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // ajusta filas
            dgv_horarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_horarios.MultiSelect = false;
            CargarGrid();

        }
        public void CargarGrid()
        {
            horarios = new cls_horarios();
            dgv_horarios.DataSource = null;
            try
            {
                dgv_horarios.SuspendLayout();
                dgv_horarios.DataSource = horarios.CargarDataGrid();
                dgv_horarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_horarios.ClearSelection();
                dgv_horarios.CurrentCell = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            horarios = new cls_horarios();
            string texto = txt_buscar.Text.Trim();
            dgv_horarios.DataSource = null;
            dgv_horarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                // Cuando el TextBox queda vacío, mostrar todos los equipos
                if (string.IsNullOrWhiteSpace(texto))
                {
                    dgv_horarios.DataSource = horarios.ConsultarTodos();
                    dgv_horarios.ClearSelection();
                    dgv_horarios.CurrentCell = null;
                    return;
                }

                // Verificar que sea un número antes de convertirlo
                if (!int.TryParse(texto, out int idEquipo))
                {
                    return;
                }
                //Buscar por id
                horarios.IdHorario = int.Parse(txt_buscar.Text);
                dgv_horarios.DataSource = horarios.Consultar();
                dgv_horarios.ClearSelection();
                dgv_horarios.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Comprobar que realmente haya una fila seleccionada
                if (dgv_horarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Seleccione el equipo que desea eliminar.",
                        "Datos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                int idSeleccionado = Convert.ToInt32(
                    dgv_horarios.SelectedRows[0].Cells["Clave"].Value
                );

                DialogResult resp = MessageBox.Show(
                    $"¿Está seguro de eliminar el horario con ID {idSeleccionado}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resp != DialogResult.Yes)
                {
                    return;
                }

                horarios.IdHorario = idSeleccionado;

                string mensaje = horarios.Eliminar();

                MessageBox.Show(
                    mensaje,
                    "Equipos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarGrid();

                idHorario = 0;
                dgv_horarios.ClearSelection();
                dgv_horarios.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                //validar combos
                if (cmb_horaInicio.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione una hora de inicio.",
                        "Datos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmb_horaInicio.Focus();
                    return;

                }
                if (cmb_horafinal.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione una hora de finalizacion.",
                        "Datos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmb_horafinal.Focus();
                    return;
                }
                // 0 = guardar, 1 = actualizar
                int tipoOperacion = idHorario == 0 ? 0 : 1;

                string accion = tipoOperacion == 0
                    ? "guardar"
                    : "actualizar";

                DialogResult respuesta = MessageBox.Show(
                    $"¿Está seguro de que desea {accion} este registro?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si responde No, detener todo
                if (respuesta != DialogResult.Yes)
                {
                    return;
                }

                horarios = new cls_horarios();

                horarios.IdHorario = idHorario;

                horarios.HoraInicio = cmb_horaInicio.Text;
                horarios.HoraFinal = cmb_horafinal.Text;


                string mensaje = horarios.GuardarActualizar(tipoOperacion);

                MessageBox.Show(
                    mensaje,
                    "Equipamientos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Recargar tabla
                CargarGrid();

                // Limpiar campos y CheckBox
                horarios.LimpiarPanel(pn_formulario);

                // Deseleccionar tabla
                dgv_horarios.ClearSelection();
                dgv_horarios.CurrentCell = null;

                cmb_horaInicio.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya una fila seleccionada
                if (dgv_horarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Seleccione el equipo que desea modificar.",
                        "Datos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Obtener la fila seleccionada
                DataGridViewRow fila = dgv_horarios.SelectedRows[0];

                // Guardar el ID para indicar que será una actualización
                idHorario = Convert.ToInt32(fila.Cells["Clave"].Value);

                // Mostrar los datos en los controles

                cmb_horaInicio.Text = fila.Cells["Hora de inicio"].Value.ToString();

                cmb_horafinal.Text = fila.Cells["Hora de finalizacion"].Value.ToString();

                cmb_horaInicio.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos del equipo.\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
