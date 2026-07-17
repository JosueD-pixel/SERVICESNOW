using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SERVICESNOW
{
    public partial class frm_trabjadores_ELIMINAR : Form
    {
        public frm_trabjadores_ELIMINAR()
        {
            InitializeComponent();
        }

        private void frm_trabjadores_ELIMINAR_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            cls_trabajadores t = new cls_trabajadores();
            dgv_Trabajadores.DataSource = t.ConsultarTodos();
            dgv_Trabajadores.ClearSelection();
        }

        private string ObtenerClaveSeleccionada()
        {
            if (dgv_Trabajadores.SelectedRows.Count > 0)
            {
                return dgv_Trabajadores.SelectedRows[0].Cells["Clave"].Value.ToString();
            }
            return null;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string clave = ObtenerClaveSeleccionada();

            if (clave == null)
            {
                MessageBox.Show("Seleccione un trabajador.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de eliminar al trabajador con clave {clave}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            cls_trabajadores t = new cls_trabajadores();
            t.Clave_trabajador = clave;

            string mensaje = t.Eliminar();

            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarGrid();
        }



        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            cls_trabajadores t = new cls_trabajadores();
            t.Clave_trabajador = txt_buscar.Text;

            dgv_Trabajadores.DataSource = t.Consultar();
        }
    }
}
