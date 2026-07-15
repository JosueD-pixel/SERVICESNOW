namespace SERVICESNOW
{
    partial class frmFuncionesEquipos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtID = new TextBox();
            label1 = new Label();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pnlEquipos = new Panel();
            btnLimpiar = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            chkRed = new CheckBox();
            chkProyector = new CheckBox();
            chkPantalla = new CheckBox();
            chkPizarron = new CheckBox();
            chkAudio = new CheckBox();
            txtNombreEquipamiento = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnModificar = new Button();
            label8 = new Label();
            txtNombreEquipos = new TextBox();
            dgvEquipos = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            label7 = new Label();
            label9 = new Label();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlEquipos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(38, 112);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 34);
            txtID.TabIndex = 0;
            txtID.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 81);
            label1.Name = "label1";
            label1.Size = new Size(266, 28);
            label1.TabIndex = 1;
            label1.Text = "ID equipamiento Automatico";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(92, 64, 51);
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(label4);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1432, 77);
            pnlSuperior.TabIndex = 2;
            // 
            // pictureBox1
            // 
            
            pictureBox1.Location = new Point(754, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 57);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(601, 19);
            label4.Name = "label4";
            label4.Size = new Size(147, 41);
            label4.TabIndex = 0;
            label4.Text = "EQUIPOS";
            // 
            // pnlEquipos
            // 
            pnlEquipos.BackColor = Color.FromArgb(217, 199, 184);
            pnlEquipos.Controls.Add(btnLimpiar);
            pnlEquipos.Controls.Add(label6);
            pnlEquipos.Controls.Add(label5);
            pnlEquipos.Controls.Add(label3);
            pnlEquipos.Controls.Add(chkRed);
            pnlEquipos.Controls.Add(chkProyector);
            pnlEquipos.Controls.Add(chkPantalla);
            pnlEquipos.Controls.Add(chkPizarron);
            pnlEquipos.Controls.Add(chkAudio);
            pnlEquipos.Controls.Add(txtNombreEquipamiento);
            pnlEquipos.Controls.Add(label2);
            pnlEquipos.Controls.Add(txtID);
            pnlEquipos.Controls.Add(label1);
            pnlEquipos.Location = new Point(29, 100);
            pnlEquipos.Name = "pnlEquipos";
            pnlEquipos.Size = new Size(509, 480);
            pnlEquipos.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(92, 64, 51);
            btnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            btnLimpiar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(298, 392);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(192, 68);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 235);
            label6.Name = "label6";
            label6.Size = new Size(168, 31);
            label6.TabIndex = 10;
            label6.Text = "Caracteristicas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 26);
            label5.Name = "label5";
            label5.Size = new Size(266, 31);
            label5.TabIndex = 9;
            label5.Text = "Registrar equipamiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 237);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 8;
            // 
            // chkRed
            // 
            chkRed.AutoSize = true;
            chkRed.Font = new Font("Segoe UI", 12F);
            chkRed.Location = new Point(38, 392);
            chkRed.Name = "chkRed";
            chkRed.Size = new Size(67, 32);
            chkRed.TabIndex = 7;
            chkRed.Text = "Red";
            chkRed.UseVisualStyleBackColor = true;
            // 
            // chkProyector
            // 
            chkProyector.AutoSize = true;
            chkProyector.Font = new Font("Segoe UI", 12F);
            chkProyector.Location = new Point(298, 284);
            chkProyector.Name = "chkProyector";
            chkProyector.Size = new Size(119, 32);
            chkProyector.TabIndex = 5;
            chkProyector.Text = "Proyector";
            chkProyector.UseVisualStyleBackColor = true;
            // 
            // chkPantalla
            // 
            chkPantalla.AutoSize = true;
            chkPantalla.Font = new Font("Segoe UI", 12F);
            chkPantalla.Location = new Point(298, 336);
            chkPantalla.Name = "chkPantalla";
            chkPantalla.Size = new Size(102, 32);
            chkPantalla.TabIndex = 6;
            chkPantalla.Text = "Pantalla";
            chkPantalla.UseVisualStyleBackColor = true;
            // 
            // chkPizarron
            // 
            chkPizarron.AutoSize = true;
            chkPizarron.Font = new Font("Segoe UI", 12F);
            chkPizarron.Location = new Point(38, 336);
            chkPizarron.Name = "chkPizarron";
            chkPizarron.Size = new Size(106, 32);
            chkPizarron.TabIndex = 5;
            chkPizarron.Text = "Pizarron";
            chkPizarron.UseVisualStyleBackColor = true;
            // 
            // chkAudio
            // 
            chkAudio.AutoSize = true;
            chkAudio.Font = new Font("Segoe UI", 12F);
            chkAudio.Location = new Point(38, 284);
            chkAudio.Name = "chkAudio";
            chkAudio.Size = new Size(184, 32);
            chkAudio.TabIndex = 4;
            chkAudio.Text = "Sistema de audio";
            chkAudio.UseVisualStyleBackColor = true;
            // 
            // txtNombreEquipamiento
            // 
            txtNombreEquipamiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreEquipamiento.Location = new Point(38, 188);
            txtNombreEquipamiento.Name = "txtNombreEquipamiento";
            txtNombreEquipamiento.Size = new Size(249, 34);
            txtNombreEquipamiento.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 157);
            label2.Name = "label2";
            label2.Size = new Size(239, 28);
            label2.TabIndex = 3;
            label2.Text = "Nombre de equipamiento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 199, 184);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtNombreEquipos);
            panel1.Controls.Add(dgvEquipos);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(553, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 480);
            panel1.TabIndex = 11;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(92, 64, 51);
            btnModificar.BackgroundImageLayout = ImageLayout.Zoom;
            btnModificar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.WhiteSmoke;
            btnModificar.Location = new Point(48, 403);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(192, 68);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(591, 16);
            label8.Name = "label8";
            label8.Size = new Size(255, 28);
            label8.TabIndex = 11;
            label8.Text = "Buscar equipamiento por ID";
            // 
            // txtNombreEquipos
            // 
            txtNombreEquipos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreEquipos.Location = new Point(597, 57);
            txtNombreEquipos.Name = "txtNombreEquipos";
            txtNombreEquipos.Size = new Size(249, 34);
            txtNombreEquipos.TabIndex = 11;
            txtNombreEquipos.TextChanged += txtNombreEquipos_TextChanged;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AllowUserToResizeColumns = false;
            dgvEquipos.AllowUserToResizeRows = false;
            dgvEquipos.BackgroundColor = Color.FromArgb(217, 199, 184);
            dgvEquipos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(92, 64, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(201, 123, 99);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(201, 123, 99);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEquipos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEquipos.Location = new Point(18, 112);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersVisible = false;
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.RowTemplate.Height = 32;
            dgvEquipos.Size = new Size(828, 243);
            dgvEquipos.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(92, 64, 51);
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.WhiteSmoke;
            btnGuardar.Location = new Point(274, 403);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(192, 68);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(92, 64, 51);
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(502, 403);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(192, 68);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 26);
            label7.Name = "label7";
            label7.Size = new Size(300, 31);
            label7.TabIndex = 11;
            label7.Text = "Equipamientos registrados";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 237);
            label9.Name = "label9";
            label9.Size = new Size(0, 28);
            label9.TabIndex = 8;
            // 
            // frmFuncionesEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(1432, 592);
            Controls.Add(panel1);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlEquipos);
            Name = "frmFuncionesEquipos";
            Text = "frmFuncionesEquipos";
            Load += frmFuncionesEquipos_Load;
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlEquipos.ResumeLayout(false);
            pnlEquipos.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtID;
        private Label label1;
        private Panel pnlSuperior;
        private Panel pnlEquipos;
        private Label label2;
        private CheckBox chkPantalla;
        private CheckBox chkPizarron;
        private CheckBox chkAudio;
        private CheckBox chkRed;
        private CheckBox chkProyector;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private DataGridView dgvEquipos;
        private Label label7;
        private Label label9;
        private Button btnGuardar;
        private Button btnEliminar;
        private TextBox txtNombreEquipamiento;
        private Label label8;
        private TextBox txtNombreEquipos;
        private Button btnLimpiar;
        private Button btnModificar;
    }
}