namespace MySQLConexion
{
    partial class Form1
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
            btnConectar = new Button();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBaseDeDatos = new TextBox();
            txtHost = new TextBox();
            label5 = new Label();
            txtPuerto = new TextBox();
            dgvDatos = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.FromArgb(53, 47, 68);
            btnConectar.Cursor = Cursors.Hand;
            btnConectar.FlatStyle = FlatStyle.Flat;
            btnConectar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConectar.ForeColor = Color.White;
            btnConectar.Location = new Point(232, 296);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(121, 35);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtUsuario.BackColor = Color.FromArgb(185, 180, 199);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(208, 81);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(195, 28);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtContrasena.BackColor = Color.FromArgb(185, 180, 199);
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.Location = new Point(208, 122);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(195, 28);
            txtContrasena.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 81);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 122);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 205);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 8;
            label3.Text = "Base de Datos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(128, 164);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 7;
            label4.Text = "Host:";
            // 
            // txtBaseDeDatos
            // 
            txtBaseDeDatos.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtBaseDeDatos.BackColor = Color.FromArgb(185, 180, 199);
            txtBaseDeDatos.BorderStyle = BorderStyle.None;
            txtBaseDeDatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBaseDeDatos.Location = new Point(208, 207);
            txtBaseDeDatos.Name = "txtBaseDeDatos";
            txtBaseDeDatos.Size = new Size(195, 28);
            txtBaseDeDatos.TabIndex = 6;
            // 
            // txtHost
            // 
            txtHost.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtHost.BackColor = Color.FromArgb(185, 180, 199);
            txtHost.BorderStyle = BorderStyle.None;
            txtHost.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtHost.Location = new Point(208, 166);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(195, 28);
            txtHost.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(107, 249);
            label5.Name = "label5";
            label5.Size = new Size(86, 30);
            label5.TabIndex = 10;
            label5.Text = "Puerto:";
            // 
            // txtPuerto
            // 
            txtPuerto.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtPuerto.BackColor = Color.FromArgb(185, 180, 199);
            txtPuerto.BorderStyle = BorderStyle.None;
            txtPuerto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPuerto.Location = new Point(208, 251);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(195, 28);
            txtPuerto.TabIndex = 9;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = Color.LavenderBlush;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.GridColor = Color.FromArgb(53, 47, 68);
            dgvDatos.Location = new Point(435, 93);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(438, 211);
            dgvDatos.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 47, 68);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 52);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.No;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(171, 9);
            label6.Name = "label6";
            label6.Size = new Size(600, 32);
            label6.TabIndex = 0;
            label6.Text = "Actividad 2: Interfaz gráfica con conexión a MySQL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(92, 84, 112);
            ClientSize = new Size(900, 362);
            Controls.Add(panel1);
            Controls.Add(dgvDatos);
            Controls.Add(label5);
            Controls.Add(txtPuerto);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtBaseDeDatos);
            Controls.Add(txtHost);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(btnConectar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBaseDeDatos;
        private TextBox txtHost;
        private Label label5;
        private TextBox txtPuerto;
        private DataGridView dgvDatos;
        private Panel panel1;
        private Label label6;
    }
}