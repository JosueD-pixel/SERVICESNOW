using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SERVICESNOW
{
    public partial class frm_trabajadores_AGREGAR : Form
    {


        cls_trabajadores trabajador = new cls_trabajadores();
        public frm_trabajadores_AGREGAR()
        {
            InitializeComponent();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txt_clave.Text))
                {
                    MessageBox.Show("Ingrese la clave del trabajador.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_clave.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del trabajador.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_nombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_APpaterno.Text))
                {
                    MessageBox.Show("Ingrese el apellido paterno.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_APpaterno.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_APmaterno.Text))
                {
                    MessageBox.Show("Ingrese el apellido materno.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_APmaterno.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_codigopostal.Text))
                {
                    MessageBox.Show("Ingrese el código postal.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_codigopostal.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_colonia.Text))
                {
                    MessageBox.Show("Ingrese la colonia.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_colonia.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_calle.Text))
                {
                    MessageBox.Show("Ingrese la calle.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_calle.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_correoE.Text))
                {
                    MessageBox.Show("Ingrese el correo electrónico.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_correoE.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_telefono.Text))
                {
                    MessageBox.Show("Ingrese el teléfono.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_telefono.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_contrasena.Text))
                {
                    MessageBox.Show("Ingrese la contraseña.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_contrasena.Focus();
                    return;
                }

                if (cmb_roles.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un rol.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmb_estado.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione el estado del trabajador.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 0 = guardar, 1 = actualizar
                int tipoOperacion = string.IsNullOrWhiteSpace(txt_clave.Text) ? 0 : 0;
                // En trabajadores, la clave NO es autonumérica, así que siempre es 0 (insertar)

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea guardar este registro?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta != DialogResult.Yes)
                {
                    return;
                }

                // Crear objeto
                cls_trabajadores trabajador = new cls_trabajadores();

                // Pasar datos del formulario a la clase
                trabajador.Clave_trabajador = txt_clave.Text.Trim();
                trabajador.Nombre = txt_nombre.Text.Trim();
                trabajador.ApellidoP = txt_APpaterno.Text.Trim();
                trabajador.ApellidoM = txt_APmaterno.Text.Trim();
                trabajador.Cp = txt_codigopostal.Text.Trim();
                trabajador.Colonia = txt_colonia.Text.Trim();
                trabajador.Calle = txt_calle.Text.Trim();
                trabajador.Correo = txt_correoE.Text.Trim();
                trabajador.Telefono = txt_telefono.Text.Trim();
                trabajador.Contrasena = txt_contrasena.Text.Trim();

                trabajador.IdRol = Convert.ToInt32(cmb_roles.SelectedValue);
                trabajador.Estado = cmb_estado.SelectedIndex; // 0 = Inactivo, 1 = Activo

                // Guardar en BD
                string mensaje = trabajador.GuardarActualizar(0);

                MessageBox.Show(
                    mensaje,
                    "Trabajadores",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Limpiar campos
                LimpiarCampos();

                // Regresar al modo guardar
                btn_guardar.Text = "Guardar";

                txt_clave.Focus();
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

        private void LimpiarCampos()
        {
            txt_clave.Text = "";
            txt_nombre.Text = "";
            txt_APpaterno.Text = "";
            txt_APmaterno.Text = "";
            txt_codigopostal.Text = "";
            txt_colonia.Text = "";
            txt_calle.Text = "";
            txt_correoE.Text = "";
            txt_telefono.Text = "";
            txt_contrasena.Text = "";
            cmb_estado.SelectedIndex = -1;
            cmb_roles.SelectedIndex = -1;
        }


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frm_trabajadores_AGREGAR_Load(object sender, EventArgs e)
        {
            // Estado del trabajador
            cmb_estado.Items.Add("Inactivo"); // 0
            cmb_estado.Items.Add("Activo");   // 1

            // Cargar roles desde la BD
            cls_roles roles = new cls_roles();
            DataTable tablaRoles = roles.ConsultarTodos(); // O la función que tengas

            cmb_roles.DataSource = tablaRoles;
            cmb_roles.DisplayMember = "nombre_rol";
            cmb_roles.ValueMember = "id_rol";

            // Opcional: dejar sin selección
            cmb_estado.SelectedIndex = -1;
            cmb_roles.SelectedIndex = -1;
        }

        private void btn_agregarol_Click(object sender, EventArgs e)
        {
            string nuevoRol = Microsoft.VisualBasic.Interaction.InputBox(
                  "Ingrese el nombre del nuevo rol:",
                  "Agregar rol",
                   ""
                   );

            if (string.IsNullOrWhiteSpace(nuevoRol))
            {
                MessageBox.Show("Debe ingresar un nombre de rol.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cls_roles roles = new cls_roles();
            string resultado = roles.InsertarRol(nuevoRol.Trim());

            MessageBox.Show(resultado, "Roles", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recargar ComboBox
            DataTable tablaRoles = roles.ConsultarTodos();
            cmb_roles.DataSource = tablaRoles;
            cmb_roles.DisplayMember = "nombre_rol";
            cmb_roles.ValueMember = "id_rol";
        }
    }
}
