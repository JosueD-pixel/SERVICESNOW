namespace SERVICESNOW
{
    partial class frm_salas_ELIMINAR
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            btnEliminar = new Button();
            txtBuscarSala = new TextBox();
            dgvSalas = new DataGridView();
            label5 = new Label();
            label8 = new Label();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).BeginInit();
            SuspendLayout();
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
            pnlSuperior.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.salas;
            pictureBox1.Location = new Point(765, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 65);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(649, 19);
            label4.Name = "label4";
            label4.Size = new Size(110, 41);
            label4.TabIndex = 5;
            label4.Text = "SALAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 199, 184);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtBuscarSala);
            panel1.Controls.Add(dgvSalas);
            panel1.Location = new Point(23, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(1386, 449);
            panel1.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(193, 4);
            label13.Name = "label13";
            label13.Size = new Size(192, 31);
            label13.TabIndex = 40;
            label13.Text = "Salas registradas";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(92, 64, 51);
            btnEliminar.BackgroundImage = Properties.Resources.boton_eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1005, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(192, 68);
            btnEliminar.TabIndex = 38;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarSala
            // 
            txtBuscarSala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarSala.Location = new Point(948, 3);
            txtBuscarSala.Name = "txtBuscarSala";
            txtBuscarSala.Size = new Size(249, 34);
            txtBuscarSala.TabIndex = 40;
            // 
            // dgvSalas
            // 
            dgvSalas.AllowUserToAddRows = false;
            dgvSalas.AllowUserToDeleteRows = false;
            dgvSalas.AllowUserToResizeColumns = false;
            dgvSalas.AllowUserToResizeRows = false;
            dgvSalas.BackgroundColor = Color.Silver;
            dgvSalas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(92, 64, 51);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(201, 123, 99);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(201, 123, 99);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSalas.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSalas.EnableHeadersVisualStyles = false;
            dgvSalas.Location = new Point(193, 43);
            dgvSalas.MultiSelect = false;
            dgvSalas.Name = "dgvSalas";
            dgvSalas.ReadOnly = true;
            dgvSalas.RowHeadersVisible = false;
            dgvSalas.RowHeadersWidth = 51;
            dgvSalas.RowTemplate.Height = 32;
            dgvSalas.Size = new Size(1004, 327);
            dgvSalas.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 78);
            label5.Name = "label5";
            label5.Size = new Size(196, 41);
            label5.TabIndex = 13;
            label5.Text = "Eliminar sala";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1054, 100);
            label8.Name = "label8";
            label8.Size = new Size(166, 28);
            label8.TabIndex = 39;
            label8.Text = "Buscar sala por ID";
            // 
            // frm_salas_ELIMINAR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 592);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(pnlSuperior);
            Name = "frm_salas_ELIMINAR";
            Text = "frm_salas_ELIMINAR";
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private DataGridView dgvSalas;
        private Button btnEliminar;
        private Label label8;
        private TextBox txtBuscarSala;
        private Label label13;
    }
}