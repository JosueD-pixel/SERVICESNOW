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
            pnl_superior = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            pn_formulario = new Panel();
            cmb_horafinal = new ComboBox();
            cmb_horaInicio = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_modificar = new PictureBox();
            panel1 = new Panel();
            txt_buscar = new TextBox();
            dgv_horarios = new DataGridView();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pn_formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_modificar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_horarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            pnl_superior.Margin = new Padding(2, 2, 2, 2);
            pnl_superior.Name = "pnl_superior";
            pnl_superior.Size = new Size(1304, 61);
            pnl_superior.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.alarm_50dp_E3E3E3_FILL0_wght400_GRAD0_opsz48;
            pictureBox4.Location = new Point(721, 2);
            pictureBox4.Margin = new Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(551, 7);
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
            pn_formulario.BackColor = Color.FromArgb(246, 240, 232);
            pn_formulario.Controls.Add(cmb_horafinal);
            pn_formulario.Controls.Add(cmb_horaInicio);
            pn_formulario.Controls.Add(label3);
            pn_formulario.Controls.Add(label2);
            pn_formulario.Controls.Add(label1);
            pn_formulario.Location = new Point(88, 102);
            pn_formulario.Margin = new Padding(2, 2, 2, 2);
            pn_formulario.Name = "pn_formulario";
            pn_formulario.Size = new Size(441, 425);
            pn_formulario.TabIndex = 1;
            // 
            // cmb_horafinal
            // 
            cmb_horafinal.FormattingEnabled = true;
            cmb_horafinal.Location = new Point(197, 166);
            cmb_horafinal.Margin = new Padding(2, 2, 2, 2);
            cmb_horafinal.Name = "cmb_horafinal";
            cmb_horafinal.Size = new Size(215, 28);
            cmb_horafinal.TabIndex = 4;
            // 
            // cmb_horaInicio
            // 
            cmb_horaInicio.FormattingEnabled = true;
            cmb_horaInicio.Location = new Point(197, 91);
            cmb_horaInicio.Margin = new Padding(2, 2, 2, 2);
            cmb_horaInicio.Name = "cmb_horaInicio";
            cmb_horaInicio.Size = new Size(215, 28);
            cmb_horaInicio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 166);
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
            label2.Location = new Point(56, 89);
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
            label1.Location = new Point(15, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 0;
            label1.Text = "Horarios";
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(92, 64, 51);
            btn_modificar.Image = Properties.Resources.boton_modificar;
            btn_modificar.Location = new Point(551, 548);
            btn_modificar.Margin = new Padding(2, 2, 2, 2);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(142, 56);
            btn_modificar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_modificar.TabIndex = 5;
            btn_modificar.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 240, 232);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(dgv_horarios);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(551, 105);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 425);
            panel1.TabIndex = 5;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(271, 9);
            txt_buscar.Margin = new Padding(2, 2, 2, 2);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(232, 27);
            txt_buscar.TabIndex = 5;
            // 
            // dgv_horarios
            // 
            dgv_horarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_horarios.Location = new Point(15, 46);
            dgv_horarios.Margin = new Padding(2, 2, 2, 2);
            dgv_horarios.Name = "dgv_horarios";
            dgv_horarios.RowHeadersWidth = 62;
            dgv_horarios.Size = new Size(487, 368);
            dgv_horarios.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 2);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(90, 32);
            label8.TabIndex = 0;
            label8.Text = "Buscar";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(92, 64, 51);
            pictureBox3.Image = Properties.Resources.boton_eliminar;
            pictureBox3.Location = new Point(736, 548);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(92, 64, 51);
            pictureBox5.Image = Properties.Resources.boton_agregar;
            pictureBox5.Location = new Point(925, 548);
            pictureBox5.Margin = new Padding(2, 2, 2, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(142, 56);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // frm_horarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1304, 623);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(btn_modificar);
            Controls.Add(pn_formulario);
            Controls.Add(pnl_superior);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frm_horarios";
            Load += frm_horarios_Load;
            pnl_superior.ResumeLayout(false);
            pnl_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pn_formulario.ResumeLayout(false);
            pn_formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_modificar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_horarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_superior;
        private Panel pn_formulario;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
    }
}