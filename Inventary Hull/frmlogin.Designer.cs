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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblusuario.Location = new Point(80, 116);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(76, 25);
            lblusuario.TabIndex = 0;
            lblusuario.Text = "Usuario";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblpassword.Location = new Point(80, 194);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(106, 25);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(192, 117);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(198, 27);
            txtusuario.TabIndex = 2;
            // 
            // mtxtpassword
            // 
            mtxtpassword.Location = new Point(192, 194);
            mtxtpassword.Name = "mtxtpassword";
            mtxtpassword.PasswordChar = '*';
            mtxtpassword.Size = new Size(198, 27);
            mtxtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(62, 340);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(139, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "INICIAR SESION";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(296, 340);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(94, 29);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1121;
            pictureBox1.Location = new Point(451, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 301);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(btncancelar);
            Controls.Add(btnlogin);
            Controls.Add(mtxtpassword);
            Controls.Add(txtusuario);
            Controls.Add(lblpassword);
            Controls.Add(lblusuario);
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONTROL DE ACCESO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}