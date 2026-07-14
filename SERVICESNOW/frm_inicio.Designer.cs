namespace SERVICESNOW
{
    partial class frm_inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            pnl_control = new Panel();
            btn_ocultar = new PictureBox();
            btn_salir = new PictureBox();
            pbx_fondo = new PictureBox();
            pbx_inicio = new PictureBox();
            txt_matricula = new TextBox();
            txt_contraseña = new TextBox();
            btn_ingresar = new PictureBox();
            pictureBox1 = new PictureBox();
            pnl_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_ocultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_salir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_fondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_inicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_ingresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_control
            // 
            pnl_control.BackColor = Color.FromArgb(92, 64, 51);
            pnl_control.Controls.Add(btn_ocultar);
            pnl_control.Controls.Add(btn_salir);
            pnl_control.Dock = DockStyle.Top;
            pnl_control.Location = new Point(0, 0);
            pnl_control.Name = "pnl_control";
            pnl_control.Size = new Size(1011, 30);
            pnl_control.TabIndex = 0;
            pnl_control.MouseDown += pnl_control_MouseDown;
            // 
            // btn_ocultar
            // 
            btn_ocultar.Image = Properties.Resources.icn_mini;
            btn_ocultar.Location = new Point(941, 0);
            btn_ocultar.Name = "btn_ocultar";
            btn_ocultar.Size = new Size(35, 29);
            btn_ocultar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_ocultar.TabIndex = 1;
            btn_ocultar.TabStop = false;
            btn_ocultar.Click += btn_ocultar_Click;
            btn_ocultar.MouseEnter += btn_ocultar_MouseEnter;
            btn_ocultar.MouseLeave += btn_ocultar_MouseLeave;
            // 
            // btn_salir
            // 
            btn_salir.Image = Properties.Resources.icono_Cerrar;
            btn_salir.Location = new Point(973, 0);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(35, 29);
            btn_salir.SizeMode = PictureBoxSizeMode.Zoom;
            btn_salir.TabIndex = 0;
            btn_salir.TabStop = false;
            btn_salir.Click += btn_salir_Click;
            btn_salir.MouseEnter += btn_salir_MouseEnter;
            btn_salir.MouseLeave += btn_salir_MouseLeave;
            // 
            // pbx_fondo
            // 
            pbx_fondo.Image = Properties.Resources.img_inicio;
            pbx_fondo.Location = new Point(12, 36);
            pbx_fondo.Name = "pbx_fondo";
            pbx_fondo.Size = new Size(460, 350);
            pbx_fondo.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_fondo.TabIndex = 1;
            pbx_fondo.TabStop = false;
            // 
            // pbx_inicio
            // 
            pbx_inicio.Image = Properties.Resources.img_Sesion;
            pbx_inicio.Location = new Point(478, 36);
            pbx_inicio.Name = "pbx_inicio";
            pbx_inicio.Size = new Size(498, 582);
            pbx_inicio.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_inicio.TabIndex = 2;
            pbx_inicio.TabStop = false;
            // 
            // txt_matricula
            // 
            txt_matricula.Location = new Point(720, 332);
            txt_matricula.Name = "txt_matricula";
            txt_matricula.Size = new Size(195, 27);
            txt_matricula.TabIndex = 3;
            // 
            // txt_contraseña
            // 
            txt_contraseña.Location = new Point(720, 387);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(195, 27);
            txt_contraseña.TabIndex = 4;
            txt_contraseña.UseSystemPasswordChar = true;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Image = Properties.Resources.btn_ingresar;
            btn_ingresar.Location = new Point(655, 482);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(204, 103);
            btn_ingresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_ingresar.TabIndex = 6;
            btn_ingresar.TabStop = false;
            btn_ingresar.Click += btn_ingresar_Click;
            btn_ingresar.MouseEnter += btn_ingresar_MouseEnter;
            btn_ingresar.MouseLeave += btn_ingresar_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img_hojacafe;
            pictureBox1.Location = new Point(0, 408);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frm_inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 240, 232);
            ClientSize = new Size(1011, 608);
            Controls.Add(pictureBox1);
            Controls.Add(btn_ingresar);
            Controls.Add(txt_contraseña);
            Controls.Add(txt_matricula);
            Controls.Add(pbx_inicio);
            Controls.Add(pbx_fondo);
            Controls.Add(pnl_control);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_inicio";
            Text = "Form1";
            pnl_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_ocultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_salir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_fondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_inicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_ingresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_control;
        private PictureBox btn_ocultar;
        private PictureBox btn_salir;
        private PictureBox pbx_fondo;
        private PictureBox pbx_inicio;
        private TextBox txt_matricula;
        private TextBox txt_contraseña;
        private PictureBox btn_ingresar;
        private PictureBox pictureBox1;
    }
}
