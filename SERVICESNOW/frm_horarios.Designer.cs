namespace SERVICESNOW
{
    partial class frm_horarios
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
            pnl_superior = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            pn_formulario = new Panel();
            btnLimpiar = new Button();
            txtID = new TextBox();
            label6 = new Label();
            cmb_horafinal = new ComboBox();
            cmb_horaInicio = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            dgv_horarios = new DataGridView();
            txt_buscar = new TextBox();
            label8 = new Label();
            pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pn_formulario.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_horarios).BeginInit();
            SuspendLayout();
            // 
            // pnl_superior
            // 
            pnl_superior.BackColor = Color.FromArgb(92, 64, 51);
            pnl_superior.Controls.Add(pictureBox4);
            pnl_superior.Controls.Add(label5);
            pnl_superior.Controls.Add(label4);
            pnl_superior.Dock = DockStyle.Top;
            pnl_superior.Location = new Point(0, 0);
            pnl_superior.Margin = new Padding(2);
            pnl_superior.Name = "pnl_superior";
            pnl_superior.Size = new Size(1432, 77);
            pnl_superior.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.alarm_50dp_E3E3E3_FILL0_wght400_GRAD0_opsz48;
            pictureBox4.Location = new Point(729, 11);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 58);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(550, 21);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(175, 41);
            label5.TabIndex = 1;
            label5.Text = "HORARIOS";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 320);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // pn_formulario
            // 
            pn_formulario.BackColor = Color.FromArgb(217, 199, 184);
            pn_formulario.Controls.Add(btnLimpiar);
            pn_formulario.Controls.Add(txtID);
            pn_formulario.Controls.Add(label6);
            pn_formulario.Controls.Add(cmb_horafinal);
            pn_formulario.Controls.Add(cmb_horaInicio);
            pn_formulario.Controls.Add(label3);
            pn_formulario.Controls.Add(label2);
            pn_formulario.Controls.Add(label1);
            pn_formulario.Location = new Point(61, 96);
            pn_formulario.Margin = new Padding(2);
            pn_formulario.Name = "pn_formulario";
            pn_formulario.Size = new Size(545, 485);
            pn_formulario.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(92, 64, 51);
            btnLimpiar.BackgroundImage = Properties.Resources.btn_limpiar;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            btnLimpiar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(333, 413);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(192, 68);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btn_limpiar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(105, 96);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 6;
            txtID.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(60, 92);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(40, 28);
            label6.TabIndex = 5;
            label6.Text = "ID:";
            // 
            // cmb_horafinal
            // 
            cmb_horafinal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_horafinal.FormattingEnabled = true;
            cmb_horafinal.Items.AddRange(new object[] { "08:00:00", "09:00:00", "10:00:00", "11:00:00", "12:00:00", "13:00:00", "14:00:00", "15:00:00", "16:00:00" });
            cmb_horafinal.Location = new Point(201, 245);
            cmb_horafinal.Margin = new Padding(2);
            cmb_horafinal.Name = "cmb_horafinal";
            cmb_horafinal.Size = new Size(272, 28);
            cmb_horafinal.TabIndex = 4;
            // 
            // cmb_horaInicio
            // 
            cmb_horaInicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_horaInicio.FormattingEnabled = true;
            cmb_horaInicio.Items.AddRange(new object[] { "08:00:00", "09:00:00", "10:00:00", "11:00:00", "12:00:00", "13:00:00", "14:00:00", "15:00:00", "16:00:00" });
            cmb_horaInicio.Location = new Point(201, 170);
            cmb_horaInicio.Margin = new Padding(2);
            cmb_horaInicio.Name = "cmb_horaInicio";
            cmb_horaInicio.Size = new Size(272, 28);
            cmb_horaInicio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 245);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 2;
            label3.Text = "Hora final:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 168);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 1;
            label2.Text = "Hora inicio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 0;
            label1.Text = "Horarios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 199, 184);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(dgv_horarios);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(686, 96);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 485);
            panel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(440, 34);
            label7.Name = "label7";
            label7.Size = new Size(197, 28);
            label7.TabIndex = 20;
            label7.Text = "Buscar horario por ID";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(92, 64, 51);
            btnGuardar.BackgroundImage = Properties.Resources.btn_guardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.WhiteSmoke;
            btnGuardar.Location = new Point(27, 413);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(192, 68);
            btnGuardar.TabIndex = 19;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btn_agregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(92, 64, 51);
            btnEliminar.BackgroundImage = Properties.Resources.boton_eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(445, 413);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(192, 68);
            btnEliminar.TabIndex = 18;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btn_eliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(92, 64, 51);
            btnModificar.BackgroundImage = Properties.Resources.boton_modificar;
            btnModificar.BackgroundImageLayout = ImageLayout.Zoom;
            btnModificar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.WhiteSmoke;
            btnModificar.Location = new Point(235, 413);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(192, 68);
            btnModificar.TabIndex = 17;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btn_modificar_Click;
            // 
            // dgv_horarios
            // 
            dgv_horarios.AllowUserToAddRows = false;
            dgv_horarios.AllowUserToDeleteRows = false;
            dgv_horarios.AllowUserToResizeColumns = false;
            dgv_horarios.AllowUserToResizeRows = false;
            dgv_horarios.BackgroundColor = Color.FromArgb(217, 199, 184);
            dgv_horarios.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(92, 64, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(201, 123, 99);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_horarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(201, 123, 99);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_horarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_horarios.EnableHeadersVisualStyles = false;
            dgv_horarios.Location = new Point(27, 96);
            dgv_horarios.MultiSelect = false;
            dgv_horarios.Name = "dgv_horarios";
            dgv_horarios.RowHeadersVisible = false;
            dgv_horarios.RowHeadersWidth = 51;
            dgv_horarios.RowTemplate.Height = 32;
            dgv_horarios.Size = new Size(617, 286);
            dgv_horarios.TabIndex = 13;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(379, 64);
            txt_buscar.Margin = new Padding(2);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(258, 27);
            txt_buscar.TabIndex = 5;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 13);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(249, 32);
            label8.TabIndex = 0;
            label8.Text = "Horarios registrados";
            // 
            // frm_horarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1432, 592);
            Controls.Add(panel1);
            Controls.Add(pn_formulario);
            Controls.Add(pnl_superior);
            Margin = new Padding(2);
            Name = "frm_horarios";
            Load += frm_horarios_Load;
            pnl_superior.ResumeLayout(false);
            pnl_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pn_formulario.ResumeLayout(false);
            pn_formulario.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_horarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_superior;
        private Panel pn_formulario;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox txtID;
        private Label label3;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btn_modificar;
        private PictureBox pictureBox4;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmb_horafinal;
        private ComboBox cmb_horaInicio;
        private TextBox txt_buscar;
        private DataGridView dgv_horarios;
        private Button btnModificar;
        private Button btn_agregar;
        private Button btn_eliminar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}