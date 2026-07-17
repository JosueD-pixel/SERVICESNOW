namespace SERVICESNOW
{
    partial class frm_salas_MODIFICAR
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
            pnlSuperior = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pnlSalasModificar = new Panel();
            txtUbicacion = new TextBox();
            label12 = new Label();
            label8 = new Label();
            label10 = new Label();
            label7 = new Label();
            label4 = new Label();
            cmbEquipamiento = new ComboBox();
            txtIDSala = new TextBox();
            txtCantSillas = new TextBox();
            label2 = new Label();
            txtEquipamiento = new Label();
            txtNombreSala = new TextBox();
            cmbTipoSala = new ComboBox();
            label3 = new Label();
            label9 = new Label();
            txtDescripcionSala = new TextBox();
            label6 = new Label();
            txtCantMesas = new TextBox();
            txtCapacidadSala = new TextBox();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            label5 = new Label();
            dgvSalas = new DataGridView();
            pnlDgvSalas = new Panel();
            txtBuscarSala = new TextBox();
            label14 = new Label();
            label13 = new Label();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlSalasModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).BeginInit();
            pnlDgvSalas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(92, 64, 51);
            pnlSuperior.Controls.Add(pictureBox2);
            pnlSuperior.Controls.Add(label1);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1432, 77);
            pnlSuperior.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.salas;
            pictureBox2.Location = new Point(765, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 65);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(649, 19);
            label1.Name = "label1";
            label1.Size = new Size(110, 41);
            label1.TabIndex = 2;
            label1.Text = "SALAS";
            // 
            // pnlSalasModificar
            // 
            pnlSalasModificar.BackColor = Color.FromArgb(217, 199, 184);
            pnlSalasModificar.Controls.Add(txtUbicacion);
            pnlSalasModificar.Controls.Add(label12);
            pnlSalasModificar.Controls.Add(label8);
            pnlSalasModificar.Controls.Add(label10);
            pnlSalasModificar.Controls.Add(label7);
            pnlSalasModificar.Controls.Add(label4);
            pnlSalasModificar.Controls.Add(cmbEquipamiento);
            pnlSalasModificar.Controls.Add(txtIDSala);
            pnlSalasModificar.Controls.Add(txtCantSillas);
            pnlSalasModificar.Controls.Add(label2);
            pnlSalasModificar.Controls.Add(txtEquipamiento);
            pnlSalasModificar.Controls.Add(txtNombreSala);
            pnlSalasModificar.Controls.Add(cmbTipoSala);
            pnlSalasModificar.Controls.Add(label3);
            pnlSalasModificar.Controls.Add(label9);
            pnlSalasModificar.Controls.Add(txtDescripcionSala);
            pnlSalasModificar.Controls.Add(label6);
            pnlSalasModificar.Controls.Add(txtCantMesas);
            pnlSalasModificar.Controls.Add(txtCapacidadSala);
            pnlSalasModificar.Location = new Point(22, 132);
            pnlSalasModificar.Name = "pnlSalasModificar";
            pnlSalasModificar.Size = new Size(367, 759);
            pnlSalasModificar.TabIndex = 11;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUbicacion.Location = new Point(16, 546);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.ReadOnly = true;
            txtUbicacion.Size = new Size(271, 34);
            txtUbicacion.TabIndex = 56;
            txtUbicacion.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(16, 12);
            label12.Name = "label12";
            label12.Size = new Size(180, 31);
            label12.TabIndex = 32;
            label12.Text = "Datos de la sala";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 447);
            label8.Name = "label8";
            label8.Size = new Size(164, 28);
            label8.TabIndex = 55;
            label8.Text = "Cantidad de sillas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(16, 583);
            label10.Name = "label10";
            label10.Size = new Size(116, 28);
            label10.TabIndex = 51;
            label10.Text = "Tipo de sala";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 515);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 47;
            label7.Text = "Ubicacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 50);
            label4.Name = "label4";
            label4.Size = new Size(180, 28);
            label4.TabIndex = 40;
            label4.Text = "ID Sala Automatico";
            // 
            // cmbEquipamiento
            // 
            cmbEquipamiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEquipamiento.FormattingEnabled = true;
            cmbEquipamiento.Location = new Point(16, 684);
            cmbEquipamiento.Name = "cmbEquipamiento";
            cmbEquipamiento.Size = new Size(271, 36);
            cmbEquipamiento.TabIndex = 54;
            // 
            // txtIDSala
            // 
            txtIDSala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIDSala.Location = new Point(16, 81);
            txtIDSala.Name = "txtIDSala";
            txtIDSala.ReadOnly = true;
            txtIDSala.Size = new Size(113, 34);
            txtIDSala.TabIndex = 39;
            txtIDSala.TabStop = false;
            // 
            // txtCantSillas
            // 
            txtCantSillas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantSillas.Location = new Point(16, 478);
            txtCantSillas.Name = "txtCantSillas";
            txtCantSillas.ReadOnly = true;
            txtCantSillas.Size = new Size(113, 34);
            txtCantSillas.TabIndex = 49;
            txtCantSillas.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 118);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 42;
            label2.Text = "Nombre de la sala";
            // 
            // txtEquipamiento
            // 
            txtEquipamiento.AutoSize = true;
            txtEquipamiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEquipamiento.Location = new Point(16, 653);
            txtEquipamiento.Name = "txtEquipamiento";
            txtEquipamiento.Size = new Size(134, 28);
            txtEquipamiento.TabIndex = 53;
            txtEquipamiento.Text = "Equipamiento";
            // 
            // txtNombreSala
            // 
            txtNombreSala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreSala.Location = new Point(16, 149);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.ReadOnly = true;
            txtNombreSala.Size = new Size(271, 34);
            txtNombreSala.TabIndex = 41;
            txtNombreSala.TabStop = false;
            // 
            // cmbTipoSala
            // 
            cmbTipoSala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTipoSala.FormattingEnabled = true;
            cmbTipoSala.Location = new Point(16, 614);
            cmbTipoSala.Name = "cmbTipoSala";
            cmbTipoSala.Size = new Size(271, 36);
            cmbTipoSala.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 186);
            label3.Name = "label3";
            label3.Size = new Size(199, 28);
            label3.TabIndex = 44;
            label3.Text = "Descripción de la sala";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 367);
            label9.Name = "label9";
            label9.Size = new Size(176, 28);
            label9.TabIndex = 50;
            label9.Text = "Cantidad de mesas";
            // 
            // txtDescripcionSala
            // 
            txtDescripcionSala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcionSala.Location = new Point(16, 217);
            txtDescripcionSala.Multiline = true;
            txtDescripcionSala.Name = "txtDescripcionSala";
            txtDescripcionSala.ReadOnly = true;
            txtDescripcionSala.Size = new Size(271, 59);
            txtDescripcionSala.TabIndex = 43;
            txtDescripcionSala.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 290);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 46;
            label6.Text = "Capacidad";
            // 
            // txtCantMesas
            // 
            txtCantMesas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantMesas.Location = new Point(16, 398);
            txtCantMesas.Name = "txtCantMesas";
            txtCantMesas.ReadOnly = true;
            txtCantMesas.Size = new Size(113, 34);
            txtCantMesas.TabIndex = 48;
            txtCantMesas.TabStop = false;
            // 
            // txtCapacidadSala
            // 
            txtCapacidadSala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCapacidadSala.Location = new Point(16, 321);
            txtCapacidadSala.Name = "txtCapacidadSala";
            txtCapacidadSala.ReadOnly = true;
            txtCapacidadSala.Size = new Size(113, 34);
            txtCapacidadSala.TabIndex = 45;
            txtCapacidadSala.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(92, 64, 51);
            btnLimpiar.BackgroundImage = Properties.Resources.btn_limpiar;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            btnLimpiar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(568, 630);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(192, 68);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(92, 64, 51);
            btnGuardar.BackgroundImage = Properties.Resources.btn_guardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.WhiteSmoke;
            btnGuardar.Location = new Point(785, 630);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(192, 68);
            btnGuardar.TabIndex = 34;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 80);
            label5.Name = "label5";
            label5.Size = new Size(218, 41);
            label5.TabIndex = 12;
            label5.Text = "Modificar sala";
            // 
            // dgvSalas
            // 
            dgvSalas.AllowUserToAddRows = false;
            dgvSalas.AllowUserToDeleteRows = false;
            dgvSalas.AllowUserToResizeColumns = false;
            dgvSalas.AllowUserToResizeRows = false;
            dgvSalas.BackgroundColor = Color.Silver;
            dgvSalas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(92, 64, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(201, 123, 99);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(201, 123, 99);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSalas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSalas.EnableHeadersVisualStyles = false;
            dgvSalas.Location = new Point(21, 164);
            dgvSalas.MultiSelect = false;
            dgvSalas.Name = "dgvSalas";
            dgvSalas.ReadOnly = true;
            dgvSalas.RowHeadersVisible = false;
            dgvSalas.RowHeadersWidth = 51;
            dgvSalas.RowTemplate.Height = 32;
            dgvSalas.Size = new Size(956, 348);
            dgvSalas.TabIndex = 36;
            // 
            // pnlDgvSalas
            // 
            pnlDgvSalas.BackColor = Color.FromArgb(217, 199, 184);
            pnlDgvSalas.Controls.Add(txtBuscarSala);
            pnlDgvSalas.Controls.Add(label14);
            pnlDgvSalas.Controls.Add(label13);
            pnlDgvSalas.Controls.Add(dgvSalas);
            pnlDgvSalas.Controls.Add(btnLimpiar);
            pnlDgvSalas.Controls.Add(btnGuardar);
            pnlDgvSalas.Location = new Point(421, 132);
            pnlDgvSalas.Name = "pnlDgvSalas";
            pnlDgvSalas.Size = new Size(999, 709);
            pnlDgvSalas.TabIndex = 36;
            // 
            // txtBuscarSala
            // 
            txtBuscarSala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarSala.Location = new Point(728, 112);
            txtBuscarSala.Name = "txtBuscarSala";
            txtBuscarSala.Size = new Size(249, 34);
            txtBuscarSala.TabIndex = 38;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(811, 81);
            label14.Name = "label14";
            label14.Size = new Size(166, 28);
            label14.TabIndex = 37;
            label14.Text = "Buscar sala por ID";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(21, 12);
            label13.Name = "label13";
            label13.Size = new Size(192, 31);
            label13.TabIndex = 37;
            label13.Text = "Salas registradas";
            // 
            // frm_salas_MODIFICAR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 853);
            Controls.Add(pnlDgvSalas);
            Controls.Add(pnlSalasModificar);
            Controls.Add(label5);
            Controls.Add(pnlSuperior);
            Name = "frm_salas_MODIFICAR";
            Text = "frm_salas_MODIFICAR";
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlSalasModificar.ResumeLayout(false);
            pnlSalasModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).EndInit();
            pnlDgvSalas.ResumeLayout(false);
            pnlDgvSalas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel pnlSalasModificar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Label label12;
        private Label label5;
        private DataGridView dgvSalas;
        private Panel pnlDgvSalas;
        private Label label13;
        private Label label14;
        private TextBox txtBuscarSala;
        private TextBox txtUbicacion;
        private Label label8;
        private Label label10;
        private Label label7;
        private Label label4;
        private ComboBox cmbEquipamiento;
        private TextBox txtIDSala;
        private TextBox txtCantSillas;
        private Label label2;
        private Label txtEquipamiento;
        private TextBox txtNombreSala;
        private ComboBox cmbTipoSala;
        private Label label3;
        private Label label9;
        private TextBox txtDescripcionSala;
        private Label label6;
        private TextBox txtCantMesas;
        private TextBox txtCapacidadSala;
    }
}