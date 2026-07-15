namespace SERVICESNOW
{
    partial class frm_administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_administrador));
            pnl_superior = new Panel();
            pnl_logo = new Panel();
            label1 = new Label();
            pbc_boton = new PictureBox();
            lbl_usuario = new Label();
            pbc_user = new PictureBox();
            btn_menu = new PictureBox();
            pnl_menu = new Panel();
            pnl_consultas = new Panel();
            pbc_reservas = new PictureBox();
            pbc_consultas = new PictureBox();
            pnl_funciones = new Panel();
            pbc_equipos = new PictureBox();
            pbc_horarios = new PictureBox();
            pbc_funciones = new PictureBox();
            pnl_trabajadores = new Panel();
            pbcTrabajadores_modificar = new PictureBox();
            pbcTrabajadores_eliminar = new PictureBox();
            pbcTrabajadores_agregar = new PictureBox();
            pbc_trabajadores = new PictureBox();
            pnl_salones = new Panel();
            pbcSalones_modificar = new PictureBox();
            pbc_Saloneseliminar = new PictureBox();
            pbc_Salonesagregar = new PictureBox();
            pbc_salones = new PictureBox();
            pnl_logo1 = new Panel();
            pbc_logo = new PictureBox();
            pbc_cerrarsesion = new PictureBox();
            pnl_fromularios = new Panel();
            pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbc_boton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbc_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_menu).BeginInit();
            pnl_menu.SuspendLayout();
            pnl_consultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbc_reservas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbc_consultas).BeginInit();
            pnl_funciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbc_equipos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbc_horarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbc_funciones).BeginInit();
            pnl_trabajadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbcTrabajadores_modificar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbcTrabajadores_eliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbcTrabajadores_agregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbc_trabajadores).BeginInit();
            pnl_salones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbcSalones_modificar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbc_Saloneseliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbc_Salonesagregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbc_salones).BeginInit();
            pnl_logo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbc_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbc_cerrarsesion).BeginInit();
            SuspendLayout();
            // 
            // pnl_superior
            // 
            pnl_superior.BackColor = Color.FromArgb(92, 64, 51);
            pnl_superior.Controls.Add(pnl_logo);
            pnl_superior.Controls.Add(label1);
            pnl_superior.Controls.Add(pbc_boton);
            pnl_superior.Controls.Add(lbl_usuario);
            pnl_superior.Controls.Add(pbc_user);
            pnl_superior.Controls.Add(btn_menu);
            pnl_superior.Dock = DockStyle.Top;
            pnl_superior.Location = new Point(0, 0);
            pnl_superior.Name = "pnl_superior";
            pnl_superior.Size = new Size(1634, 60);
            pnl_superior.TabIndex = 0;
            // 
            // pnl_logo
            // 
            pnl_logo.Location = new Point(3, 60);
            pnl_logo.Name = "pnl_logo";
            pnl_logo.Size = new Size(250, 125);
            pnl_logo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(92, 64, 51);
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(246, 240, 230);
            label1.Location = new Point(73, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 38);
            label1.TabIndex = 5;
            label1.Text = "Menu principal";
            // 
            // pbc_boton
            // 
            pbc_boton.Image = Properties.Resources.icn_userbajo;
            pbc_boton.Location = new Point(1850, 6);
            pbc_boton.Name = "pbc_boton";
            pbc_boton.Size = new Size(58, 54);
            pbc_boton.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_boton.TabIndex = 5;
            pbc_boton.TabStop = false;
            pbc_boton.Click += pbc_boton_Click;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.FromArgb(92, 64, 51);
            lbl_usuario.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = Color.FromArgb(246, 240, 230);
            lbl_usuario.Location = new Point(1655, 9);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(201, 38);
            lbl_usuario.TabIndex = 4;
            lbl_usuario.Text = "Administrador";
            // 
            // pbc_user
            // 
            pbc_user.Image = Properties.Resources.ChatGPT_Image_5_jul_2026__01_51_17_p_m_;
            pbc_user.Location = new Point(1591, 3);
            pbc_user.Name = "pbc_user";
            pbc_user.Size = new Size(58, 54);
            pbc_user.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_user.TabIndex = 3;
            pbc_user.TabStop = false;
            // 
            // btn_menu
            // 
            btn_menu.Image = Properties.Resources.icono_menu;
            btn_menu.Location = new Point(12, 0);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(55, 60);
            btn_menu.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_menu.TabIndex = 2;
            btn_menu.TabStop = false;
            btn_menu.Click += btn_menu_Click;
            // 
            // pnl_menu
            // 
            pnl_menu.BackColor = Color.FromArgb(92, 64, 51);
            pnl_menu.Controls.Add(pnl_consultas);
            pnl_menu.Controls.Add(pbc_consultas);
            pnl_menu.Controls.Add(pnl_funciones);
            pnl_menu.Controls.Add(pbc_funciones);
            pnl_menu.Controls.Add(pnl_trabajadores);
            pnl_menu.Controls.Add(pbc_trabajadores);
            pnl_menu.Controls.Add(pnl_salones);
            pnl_menu.Controls.Add(pbc_salones);
            pnl_menu.Controls.Add(pnl_logo1);
            pnl_menu.Dock = DockStyle.Left;
            pnl_menu.Location = new Point(0, 60);
            pnl_menu.Name = "pnl_menu";
            pnl_menu.Size = new Size(250, 728);
            pnl_menu.TabIndex = 1;
            // 
            // pnl_consultas
            // 
            pnl_consultas.Controls.Add(pbc_reservas);
            pnl_consultas.Dock = DockStyle.Top;
            pnl_consultas.Location = new Point(0, 736);
            pnl_consultas.Name = "pnl_consultas";
            pnl_consultas.Size = new Size(250, 125);
            pnl_consultas.TabIndex = 12;
            // 
            // pbc_reservas
            // 
            pbc_reservas.Image = Properties.Resources.img_reservas2;
            pbc_reservas.Location = new Point(98, 0);
            pbc_reservas.Name = "pbc_reservas";
            pbc_reservas.Size = new Size(149, 39);
            pbc_reservas.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_reservas.TabIndex = 8;
            pbc_reservas.TabStop = false;
            // 
            // pbc_consultas
            // 
            pbc_consultas.Dock = DockStyle.Top;
            pbc_consultas.Image = Properties.Resources.img_consultas;
            pbc_consultas.Location = new Point(0, 686);
            pbc_consultas.Name = "pbc_consultas";
            pbc_consultas.Size = new Size(250, 50);
            pbc_consultas.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_consultas.TabIndex = 11;
            pbc_consultas.TabStop = false;
            pbc_consultas.Click += pbc_consultas_Click;
            // 
            // pnl_funciones
            // 
            pnl_funciones.Controls.Add(pbc_equipos);
            pnl_funciones.Controls.Add(pbc_horarios);
            pnl_funciones.Dock = DockStyle.Top;
            pnl_funciones.Location = new Point(0, 549);
            pnl_funciones.Name = "pnl_funciones";
            pnl_funciones.Size = new Size(250, 137);
            pnl_funciones.TabIndex = 10;
            // 
            // pbc_equipos
            // 
            pbc_equipos.Image = Properties.Resources.img;
            pbc_equipos.Location = new Point(98, 0);
            pbc_equipos.Name = "pbc_equipos";
            pbc_equipos.Size = new Size(149, 39);
            pbc_equipos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_equipos.TabIndex = 6;
            pbc_equipos.TabStop = false;
            pbc_equipos.Click += pbc_equipos_Click;
            // 
            // pbc_horarios
            // 
            pbc_horarios.Image = Properties.Resources.img_horarios1;
            pbc_horarios.Location = new Point(98, 45);
            pbc_horarios.Name = "pbc_horarios";
            pbc_horarios.Size = new Size(149, 39);
            pbc_horarios.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_horarios.TabIndex = 7;
            pbc_horarios.TabStop = false;
            pbc_horarios.Click += pbc_horarios_Click;
            // 
            // pbc_funciones
            // 
            pbc_funciones.Dock = DockStyle.Top;
            pbc_funciones.Image = Properties.Resources.img_funciones;
            pbc_funciones.Location = new Point(0, 499);
            pbc_funciones.Name = "pbc_funciones";
            pbc_funciones.Size = new Size(250, 50);
            pbc_funciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_funciones.TabIndex = 9;
            pbc_funciones.TabStop = false;
            pbc_funciones.Click += pbc_funciones_Click;
            // 
            // pnl_trabajadores
            // 
            pnl_trabajadores.Controls.Add(pbcTrabajadores_modificar);
            pnl_trabajadores.Controls.Add(pbcTrabajadores_eliminar);
            pnl_trabajadores.Controls.Add(pbcTrabajadores_agregar);
            pnl_trabajadores.Dock = DockStyle.Top;
            pnl_trabajadores.Location = new Point(0, 362);
            pnl_trabajadores.Name = "pnl_trabajadores";
            pnl_trabajadores.Size = new Size(250, 137);
            pnl_trabajadores.TabIndex = 8;
            // 
            // pbcTrabajadores_modificar
            // 
            pbcTrabajadores_modificar.Image = Properties.Resources.boton_modificar;
            pbcTrabajadores_modificar.Location = new Point(98, 96);
            pbcTrabajadores_modificar.Name = "pbcTrabajadores_modificar";
            pbcTrabajadores_modificar.Size = new Size(149, 39);
            pbcTrabajadores_modificar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcTrabajadores_modificar.TabIndex = 5;
            pbcTrabajadores_modificar.TabStop = false;
            // 
            // pbcTrabajadores_eliminar
            // 
            pbcTrabajadores_eliminar.Image = Properties.Resources.boton_eliminar;
            pbcTrabajadores_eliminar.Location = new Point(98, 51);
            pbcTrabajadores_eliminar.Name = "pbcTrabajadores_eliminar";
            pbcTrabajadores_eliminar.Size = new Size(149, 39);
            pbcTrabajadores_eliminar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcTrabajadores_eliminar.TabIndex = 4;
            pbcTrabajadores_eliminar.TabStop = false;
            // 
            // pbcTrabajadores_agregar
            // 
            pbcTrabajadores_agregar.Image = Properties.Resources.boton_agregar;
            pbcTrabajadores_agregar.Location = new Point(98, 6);
            pbcTrabajadores_agregar.Name = "pbcTrabajadores_agregar";
            pbcTrabajadores_agregar.Size = new Size(149, 39);
            pbcTrabajadores_agregar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcTrabajadores_agregar.TabIndex = 3;
            pbcTrabajadores_agregar.TabStop = false;
            // 
            // pbc_trabajadores
            // 
            pbc_trabajadores.Dock = DockStyle.Top;
            pbc_trabajadores.Image = Properties.Resources.img_trabajadores;
            pbc_trabajadores.Location = new Point(0, 312);
            pbc_trabajadores.Name = "pbc_trabajadores";
            pbc_trabajadores.Size = new Size(250, 50);
            pbc_trabajadores.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_trabajadores.TabIndex = 7;
            pbc_trabajadores.TabStop = false;
            pbc_trabajadores.Click += pbc_Trabajadores_Click;
            // 
            // pnl_salones
            // 
            pnl_salones.Controls.Add(pbcSalones_modificar);
            pnl_salones.Controls.Add(pbc_Saloneseliminar);
            pnl_salones.Controls.Add(pbc_Salonesagregar);
            pnl_salones.Dock = DockStyle.Top;
            pnl_salones.Location = new Point(0, 175);
            pnl_salones.Name = "pnl_salones";
            pnl_salones.Size = new Size(250, 137);
            pnl_salones.TabIndex = 4;
            // 
            // pbcSalones_modificar
            // 
            pbcSalones_modificar.Image = Properties.Resources.boton_modificar;
            pbcSalones_modificar.Location = new Point(98, 90);
            pbcSalones_modificar.Name = "pbcSalones_modificar";
            pbcSalones_modificar.Size = new Size(149, 39);
            pbcSalones_modificar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcSalones_modificar.TabIndex = 2;
            pbcSalones_modificar.TabStop = false;
            // 
            // pbc_Saloneseliminar
            // 
            pbc_Saloneseliminar.Image = Properties.Resources.boton_eliminar;
            pbc_Saloneseliminar.Location = new Point(98, 45);
            pbc_Saloneseliminar.Name = "pbc_Saloneseliminar";
            pbc_Saloneseliminar.Size = new Size(149, 39);
            pbc_Saloneseliminar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_Saloneseliminar.TabIndex = 1;
            pbc_Saloneseliminar.TabStop = false;
            // 
            // pbc_Salonesagregar
            // 
            pbc_Salonesagregar.Image = Properties.Resources.boton_agregar;
            pbc_Salonesagregar.Location = new Point(98, 3);
            pbc_Salonesagregar.Name = "pbc_Salonesagregar";
            pbc_Salonesagregar.Size = new Size(149, 39);
            pbc_Salonesagregar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_Salonesagregar.TabIndex = 0;
            pbc_Salonesagregar.TabStop = false;
            // 
            // pbc_salones
            // 
            pbc_salones.Dock = DockStyle.Top;
            pbc_salones.Image = Properties.Resources.img_salas;
            pbc_salones.Location = new Point(0, 125);
            pbc_salones.Name = "pbc_salones";
            pbc_salones.Size = new Size(250, 50);
            pbc_salones.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_salones.TabIndex = 3;
            pbc_salones.TabStop = false;
            pbc_salones.Click += pbc_salones_Click;
            // 
            // pnl_logo1
            // 
            pnl_logo1.Controls.Add(pbc_logo);
            pnl_logo1.Dock = DockStyle.Top;
            pnl_logo1.Location = new Point(0, 0);
            pnl_logo1.Name = "pnl_logo1";
            pnl_logo1.Size = new Size(250, 125);
            pnl_logo1.TabIndex = 2;
            // 
            // pbc_logo
            // 
            pbc_logo.Image = Properties.Resources.lg_services;
            pbc_logo.Location = new Point(59, 6);
            pbc_logo.Name = "pbc_logo";
            pbc_logo.Size = new Size(120, 120);
            pbc_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbc_logo.TabIndex = 0;
            pbc_logo.TabStop = false;
            // 
            // pbc_cerrarsesion
            // 
            pbc_cerrarsesion.BackColor = Color.FromArgb(92, 64, 51);
            pbc_cerrarsesion.Image = Properties.Resources.img_elisesion;
            pbc_cerrarsesion.Location = new Point(1591, 60);
            pbc_cerrarsesion.Name = "pbc_cerrarsesion";
            pbc_cerrarsesion.Size = new Size(317, 44);
            pbc_cerrarsesion.SizeMode = PictureBoxSizeMode.Zoom;
            pbc_cerrarsesion.TabIndex = 3;
            pbc_cerrarsesion.TabStop = false;
            pbc_cerrarsesion.Visible = false;
            pbc_cerrarsesion.Click += pbc_cerrarsesion_Click;
            // 
            // pnl_fromularios
            // 
            pnl_fromularios.BackColor = Color.White;
            pnl_fromularios.Location = new Point(256, 110);
            pnl_fromularios.Name = "pnl_fromularios";
            pnl_fromularios.Size = new Size(1652, 835);
            pnl_fromularios.TabIndex = 4;
            // 
            // frm_administrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 240, 230);
            ClientSize = new Size(1634, 788);
            Controls.Add(pnl_fromularios);
            Controls.Add(pbc_cerrarsesion);
            Controls.Add(pnl_menu);
            Controls.Add(pnl_superior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            pnl_superior.ResumeLayout(false);
            pnl_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbc_boton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbc_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_menu).EndInit();
            pnl_menu.ResumeLayout(false);
            pnl_consultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbc_reservas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbc_consultas).EndInit();
            pnl_funciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbc_equipos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbc_horarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbc_funciones).EndInit();
            pnl_trabajadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbcTrabajadores_modificar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbcTrabajadores_eliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbcTrabajadores_agregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbc_trabajadores).EndInit();
            pnl_salones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbcSalones_modificar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbc_Saloneseliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbc_Salonesagregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbc_salones).EndInit();
            pnl_logo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbc_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbc_cerrarsesion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_superior;
        private PictureBox pbc_boton;
        private Label lbl_usuario;
        private PictureBox pbc_user;
        private PictureBox btn_menu;
        private Label label1;
        private Panel pnl_logo;
        private Panel pnl_menu;
        private Panel pnl_logo1;
        private PictureBox pbc_logo;
        private PictureBox pbc_salones;
        private Panel pnl_salones;
        private Panel pnl_funciones;
        private PictureBox pbc_funciones;
        private Panel pnl_trabajadores;
        private PictureBox pbc_trabajadores;
        private PictureBox pbcSalones_modificar;
        private PictureBox pbc_Saloneseliminar;
        private PictureBox pbc_Salonesagregar;
        private PictureBox pbcTrabajadores_modificar;
        private PictureBox pbcTrabajadores_eliminar;
        private PictureBox pbcTrabajadores_agregar;
        private PictureBox pbc_equipos;
        private PictureBox pbc_horarios;
        private PictureBox pbc_cerrarsesion;
        private Panel pnl_fromularios;
        private Panel pnl_consultas;
        private PictureBox pbc_reservas;
        private PictureBox pbc_consultas;
    }
}