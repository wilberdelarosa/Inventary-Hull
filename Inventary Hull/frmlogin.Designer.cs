namespace Inventary_Hull
{
    partial class frmlogin
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
            lblusuario = new Label();
            lblpassword = new Label();
            txtusuario = new TextBox();
            mtxtpassword = new MaskedTextBox();
            btnlogin = new Button();
            btncancelar = new Button();
            panel1 = new Panel();
            pictureBoxlogo = new PictureBox();
            label1 = new Label();
            Lbltitulo = new Label();
            lblogin = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnAdmin = new Button();
            btnInvitado = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblusuario.ForeColor = SystemColors.ControlLightLight;
            lblusuario.Location = new Point(350, 151);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(64, 23);
            lblusuario.TabIndex = 0;
            lblusuario.Text = "Usuario";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblpassword.ForeColor = SystemColors.ControlLightLight;
            lblpassword.Location = new Point(341, 199);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(90, 23);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.BackColor = SystemColors.ActiveBorder;
            txtusuario.Enabled = false;
            txtusuario.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuario.Location = new Point(469, 151);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(198, 30);
            txtusuario.TabIndex = 2;
            txtusuario.TextAlign = HorizontalAlignment.Center;
            txtusuario.TextChanged += txtusuario_TextChanged;
            txtusuario.KeyDown += CheckEnterKeyPress;
            // 
            // mtxtpassword
            // 
            mtxtpassword.BackColor = SystemColors.ActiveBorder;
            mtxtpassword.Enabled = false;
            mtxtpassword.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtpassword.Location = new Point(469, 199);
            mtxtpassword.Name = "mtxtpassword";
            mtxtpassword.PasswordChar = 'x';
            mtxtpassword.Size = new Size(198, 30);
            mtxtpassword.TabIndex = 3;
            mtxtpassword.TextAlign = HorizontalAlignment.Center;
            mtxtpassword.KeyDown += CheckEnterKeyPress1;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.ControlLightLight;
            btnlogin.Font = new Font("Tw Cen MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.Location = new Point(350, 293);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(139, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "INICIAR SESION";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = SystemColors.ControlLightLight;
            btncancelar.Font = new Font("Tw Cen MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btncancelar.Location = new Point(573, 293);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(94, 29);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(pictureBoxlogo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Lbltitulo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 350);
            panel1.TabIndex = 7;
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.Image = Properties.Resources.inventory_logoo_04;
            pictureBoxlogo.Location = new Point(12, 124);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(254, 221);
            pictureBoxlogo.TabIndex = 11;
            pictureBoxlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(83, 85);
            label1.Name = "label1";
            label1.Size = new Size(115, 39);
            label1.TabIndex = 10;
            label1.Text = "HALL";
            // 
            // Lbltitulo
            // 
            Lbltitulo.AutoSize = true;
            Lbltitulo.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Lbltitulo.ForeColor = SystemColors.ControlLightLight;
            Lbltitulo.Location = new Point(29, 40);
            Lbltitulo.Name = "Lbltitulo";
            Lbltitulo.Size = new Size(225, 45);
            Lbltitulo.TabIndex = 9;
            Lbltitulo.Text = "INVENTORY";
            // 
            // lblogin
            // 
            lblogin.AutoSize = true;
            lblogin.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblogin.ForeColor = SystemColors.ControlLightLight;
            lblogin.Location = new Point(493, 40);
            lblogin.Name = "lblogin";
            lblogin.Size = new Size(139, 39);
            lblogin.TabIndex = 8;
            lblogin.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inventory_logoo_05;
            pictureBox1.Location = new Point(402, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.SALIR;
            pictureBox2.Location = new Point(743, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.minimizar;
            pictureBox3.Location = new Point(713, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Gray;
            btnAdmin.Font = new Font("Tw Cen MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.Location = new Point(520, 110);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(47, 24);
            btnAdmin.TabIndex = 12;
            btnAdmin.Text = "ADM";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnInvitado
            // 
            btnInvitado.BackColor = Color.Gray;
            btnInvitado.Font = new Font("Tw Cen MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInvitado.Location = new Point(573, 110);
            btnInvitado.Name = "btnInvitado";
            btnInvitado.Size = new Size(47, 24);
            btnInvitado.TabIndex = 13;
            btnInvitado.Text = "USER";
            btnInvitado.UseVisualStyleBackColor = false;
            btnInvitado.Click += btnInvitado_Click;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(780, 350);
            ControlBox = false;
            Controls.Add(btnInvitado);
            Controls.Add(btnAdmin);
            Controls.Add(pictureBox3);
            Controls.Add(lblogin);
            Controls.Add(panel1);
            Controls.Add(btncancelar);
            Controls.Add(btnlogin);
            Controls.Add(mtxtpassword);
            Controls.Add(txtusuario);
            Controls.Add(lblpassword);
            Controls.Add(lblusuario);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmlogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONTROL DE ACCESO";
            Load += frmlogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusuario;
        private Label lblpassword;
        private TextBox txtusuario;
        private MaskedTextBox mtxtpassword;
        private Button btnlogin;
        private Button btncancelar;
        private Panel panel1;
        private Label lblogin;
        private Label label1;
        private Label Lbltitulo;
        private PictureBox pictureBoxlogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Button btnAdmin;
        private Button btnInvitado;
    }
}