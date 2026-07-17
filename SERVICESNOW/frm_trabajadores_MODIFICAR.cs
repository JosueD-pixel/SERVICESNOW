using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SERVICESNOW
{
    public partial class frm_trabajadores_MODIFICAR : Form
    {


        public frm_trabajadores_MODIFICAR()
        {
            InitializeComponent();
        }

        private void frm_trabajadores_MODIFICAR_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarCombos();
            dgv_Trabajadores.AutoGenerateColumns = true;
        }
        private void CargarGrid()
        {
            cls_trabajadores t = new cls_trabajadores();
            dgv_Trabajadores.DataSource = t.ConsultarTodos();
            dgv_Trabajadores.ClearSelection();
        }

        private void CargarCombos()
        {
            cmb_estado.Items.Add("Inactivo"); // 0
            cmb_estado.Items.Add("Activo");   // 1

            cls_roles roles = new cls_roles();
            DataTable tablaRoles = roles.ConsultarTodos();

            cmb_roles.DataSource = tablaRoles;
            cmb_roles.DisplayMember = "nombre_rol"; // Lo que se muestra
            cmb_roles.ValueMember = "id_rol";       // Lo que se usa internamente

        }

        private void dgv_Trabajadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txt_clave.Text = dgv_Trabajadores.Rows[e.RowIndex].Cells["Clave"].Value.ToString();
            txt_nombre.Text = dgv_Trabajadores.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txt_APpaterno.Text = dgv_Trabajadores.Rows[e.RowIndex].Cells["Paterno"].Value.ToString();
            txt_APmaterno.Text = dgv_Trabajadores.Rows[e.RowIndex].Cells["Materno"].Value.ToString();
            txt_codigopostal.Text = dgv_Trabajadores.Rows[e.RowIndex].Cells["CP"].Value.ToString();
            txt_colonia.Text = dgv_Trabajadores.Rows[e.RowIndex].Cells["Colonia"].Value.ToString();
            txt_calle.Text = dgv_Trabajadores.Rows[e.RowIndex].Cells["Calle"].Value.ToString();
            txt_correoE.Text = dgv_Trabajadores.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            txt_telefono.Text = dgv_Trabajadores.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

            // Estado
            cmb_estado.SelectedIndex = Convert.ToInt32(dgv_Trabajadores.Rows[e.RowIndex].Cells["Estado"].Value);

            // Rol (usando IdRol)
            cmb_roles.SelectedValue = Convert.ToInt32(dgv_Trabajadores.Rows[e.RowIndex].Cells["IdRol"].Value);

            // CONTRASEÑA (la línea que faltaba)
            txt_contrasena.Text = dgv_Trabajadores.Rows[e.RowIndex].Cells["Contrasena"].Value.ToString();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_clave.Text))
            {
                MessageBox.Show("Seleccione un trabajador.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea modificar este trabajador?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            cls_trabajadores t = new cls_trabajadores();

            t.Clave_trabajador = txt_clave.Text;
            t.Nombre = txt_nombre.Text;
            t.ApellidoP = txt_APpaterno.Text;
            t.ApellidoM = txt_APmaterno.Text;
            t.Cp = txt_codigopostal.Text;
            t.Colonia = txt_colonia.Text;
            t.Calle = txt_calle.Text;
            t.Correo = txt_correoE.Text;
            t.Telefono = txt_telefono.Text;
            t.Contrasena = txt_contrasena.Text;
            t.Estado = cmb_estado.SelectedIndex;
            t.IdRol = Convert.ToInt32(cmb_roles.SelectedValue);

            string mensaje = t.GuardarActualizar(1);

            MessageBox.Show(mensaje, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarGrid();
        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            cls_trabajadores t = new cls_trabajadores();
            t.Clave_trabajador = txt_buscador.Text;

            dgv_Trabajadores.DataSource = t.Consultar();
        }
    }
}

