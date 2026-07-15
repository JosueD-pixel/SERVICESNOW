using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SERVICESNOW
{
    public partial class frmFuncionesEquipos : Form
    {
        clsEquipos equipos;
        int idEquipo;
        public frmFuncionesEquipos()
        {
            InitializeComponent();
        }
        private void frmFuncionesEquipos_Load(object sender, EventArgs e)
        {
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // ajusta columnas al ancho
            dgvEquipos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // ajusta filas
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.MultiSelect = false;
            CargarGrid();
        }
        public void CargarGrid()
        {
            equipos = new clsEquipos();
            dgvEquipos.DataSource = null;
            try
            {
                dgvEquipos.SuspendLayout();
                dgvEquipos.DataSource = equipos.CargarDataGrid();
                dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEquipos.ClearSelection();
                dgvEquipos.CurrentCell = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtNombreEquipos_TextChanged(object sender, EventArgs e)
        {
            equipos = new clsEquipos();
            string texto = txtNombreEquipos.Text.Trim();
            dgvEquipos.DataSource = null;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                // Cuando el TextBox queda vacío, mostrar todos los equipos
                if (string.IsNullOrWhiteSpace(texto))
                {
                    dgvEquipos.DataSource = equipos.ConsultarTodos();
                    dgvEquipos.ClearSelection();
                    dgvEquipos.CurrentCell = null;
                    return;
                }

                // Verificar que sea un número antes de convertirlo
                if (!int.TryParse(texto, out int idEquipo))
                {
                    return;
                }
                //Buscar por id
                equipos.IdEquipo = int.Parse(txtNombreEquipos.Text);
                dgvEquipos.DataSource = equipos.Consultar();
                dgvEquipos.ClearSelection();
                dgvEquipos.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idEquipo = 0;
            equipos.LimpiarPanel(pnlEquipos);
            txtNombreEquipamiento.Focus();
            dgvEquipos.ClearSelection();
            dgvEquipos.CurrentCell = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar nombre
                if (string.IsNullOrWhiteSpace(txtNombreEquipamiento.Text))
                {
                    MessageBox.Show( "Ingrese el nombre del equipamiento.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtNombreEquipamiento.Focus();
                    return;
                }

                // Validar características
                if (!chkAudio.Checked &&
                    !chkPizarron.Checked &&
                    !chkPantalla.Checked &&
                    !chkProyector.Checked &&
                    !chkRed.Checked)
                {
                    MessageBox.Show("Seleccione al menos una característica del equipamiento.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                // 0 = guardar, 1 = actualizar
                int tipoOperacion = idEquipo == 0 ? 0 : 1;

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

                equipos = new clsEquipos();

                equipos.IdEquipo = idEquipo;
                equipos.NombreEquipo = txtNombreEquipamiento.Text.Trim();

                equipos.SistemaAudio = chkAudio.Checked;
                equipos.Pizarron = chkPizarron.Checked;
                equipos.Pantalla = chkPantalla.Checked;
                equipos.Proyector = chkProyector.Checked;
                equipos.Red = chkRed.Checked;

                string mensaje = equipos.GuardarActualizar(tipoOperacion);

                MessageBox.Show(
                    mensaje,
                    "Equipamientos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Recargar tabla
                CargarGrid();

                // Limpiar campos y CheckBox
                equipos.LimpiarPanel(pnlEquipos);

                // Regresar al modo guardar
                idEquipo = 0;
                txtID.Clear();
                btnGuardar.Text = "Guardar";

                // Deseleccionar tabla
                dgvEquipos.ClearSelection();
                dgvEquipos.CurrentCell = null;

                txtNombreEquipamiento.Focus();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Comprobar que realmente haya una fila seleccionada
                if (dgvEquipos.SelectedRows.Count == 0)
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
                    dgvEquipos.SelectedRows[0].Cells["Clave"].Value
                );

                DialogResult resp = MessageBox.Show(
                    $"¿Está seguro de eliminar el equipo con ID {idSeleccionado}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resp != DialogResult.Yes)
                {
                    return;
                }

                equipos.IdEquipo = idSeleccionado;

                string mensaje = equipos.Eliminar();

                MessageBox.Show(
                    mensaje,
                    "Equipos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarGrid();

                idEquipo = 0;
                dgvEquipos.ClearSelection();
                dgvEquipos.CurrentCell = null;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya una fila seleccionada
                if (dgvEquipos.SelectedRows.Count == 0)
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
                DataGridViewRow fila = dgvEquipos.SelectedRows[0];

                // Guardar el ID para indicar que será una actualización
                idEquipo = Convert.ToInt32(fila.Cells["Clave"].Value);

                // Mostrar los datos en los controles
                txtID.Text = idEquipo.ToString();

                txtNombreEquipamiento.Text =fila.Cells["Equipo"].Value.ToString();

                chkAudio.Checked = Convert.ToBoolean(fila.Cells["Audio"].Value);

                chkPizarron.Checked = Convert.ToBoolean(fila.Cells["Pizarron"].Value);

                chkPantalla.Checked = Convert.ToBoolean(fila.Cells["Pantalla"].Value);

                chkProyector.Checked = Convert.ToBoolean(fila.Cells["Proyector"].Value);

                chkRed.Checked = Convert.ToBoolean(fila.Cells["Red"].Value);

                // Cambiar el texto para indicar que se actualizará
                btnGuardar.Text = "Actualizar";

                txtNombreEquipamiento.Focus();
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
