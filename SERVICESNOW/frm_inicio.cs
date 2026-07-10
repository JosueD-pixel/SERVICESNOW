using System.Runtime.InteropServices;
namespace SERVICESNOW
{
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_control_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_salir_MouseEnter(object sender, EventArgs e)
        {
            btn_salir.BackColor = Color.FromArgb(201, 123, 99);
        }

        private void btn_salir_MouseLeave(object sender, EventArgs e)
        {
            btn_salir.BackColor = Color.Transparent;
        }

        private void btn_ocultar_MouseLeave(object sender, EventArgs e)
        {
            btn_ocultar.BackColor = Color.Transparent;
        }

        private void btn_ocultar_MouseEnter(object sender, EventArgs e)
        {
            btn_ocultar.BackColor = Color.FromArgb(201, 123, 99);
        }

        private void btn_ocultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ingresar_MouseEnter(object sender, EventArgs e)
        {
            btn_ingresar.Image = Properties.Resources.btn_selection_ingresar;
        }

        private void btn_ingresar_MouseLeave(object sender, EventArgs e)
        {
            btn_ingresar.Image = Properties.Resources.btn_ingresar;
        }

        private void frm_inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                clsLogin login = new clsLogin();
                login.Matricula = txt_matricula.Text;
                login.Password = txt_contraseña.Text;

                bool resp = login.ValidarAcceso();
                if (resp == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();//Cierra el login y abre el formulario principal
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_matricula.Text = "";
                txt_contraseña.Text = "";
            }

        }
    }
}
