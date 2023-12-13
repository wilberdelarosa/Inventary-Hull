namespace Inventary_Hull
{
    partial class agrempleado
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
            nombretxt = new TextBox();
            entreadoempleadoLB = new Label();
            nombreLB = new Label();
            apellidoLB = new Label();
            apellidotxt = new TextBox();
            direccionLB = new Label();
            direcciontxt = new TextBox();
            dniLB = new Label();
            maskeddni = new MaskedTextBox();
            emailLB = new Label();
            emailtxt = new TextBox();
            maskedtel = new MaskedTextBox();
            telefonoLB = new Label();
            maskedcel = new MaskedTextBox();
            celularLB = new Label();
            cargoLB = new Label();
            cargotxt = new TextBox();
            nuevobtn = new Button();
            guardarbtn = new Button();
            SuspendLayout();
            // 
            // nombretxt
            // 
            nombretxt.BackColor = SystemColors.ScrollBar;
            nombretxt.Enabled = false;
            nombretxt.Location = new Point(121, 104);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(144, 27);
            nombretxt.TabIndex = 0;
            // 
            // entreadoempleadoLB
            // 
            entreadoempleadoLB.AutoSize = true;
            entreadoempleadoLB.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            entreadoempleadoLB.Location = new Point(246, 28);
            entreadoempleadoLB.Name = "entreadoempleadoLB";
            entreadoempleadoLB.Size = new Size(238, 25);
            entreadoempleadoLB.TabIndex = 1;
            entreadoempleadoLB.Text = "ENTRADA DE EMPLEADOS";
            // 
            // nombreLB
            // 
            nombreLB.AutoSize = true;
            nombreLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nombreLB.Location = new Point(39, 104);
            nombreLB.Name = "nombreLB";
            nombreLB.Size = new Size(67, 20);
            nombreLB.TabIndex = 2;
            nombreLB.Text = "Nombre";
            // 
            // apellidoLB
            // 
            apellidoLB.AutoSize = true;
            apellidoLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            apellidoLB.Location = new Point(39, 170);
            apellidoLB.Name = "apellidoLB";
            apellidoLB.Size = new Size(67, 20);
            apellidoLB.TabIndex = 4;
            apellidoLB.Text = "Apellido";
            // 
            // apellidotxt
            // 
            apellidotxt.BackColor = SystemColors.ScrollBar;
            apellidotxt.Enabled = false;
            apellidotxt.Location = new Point(121, 170);
            apellidotxt.Name = "apellidotxt";
            apellidotxt.Size = new Size(144, 27);
            apellidotxt.TabIndex = 3;
            // 
            // direccionLB
            // 
            direccionLB.AutoSize = true;
            direccionLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            direccionLB.Location = new Point(39, 237);
            direccionLB.Name = "direccionLB";
            direccionLB.Size = new Size(74, 20);
            direccionLB.TabIndex = 6;
            direccionLB.Text = "Direccion";
            // 
            // direcciontxt
            // 
            direcciontxt.BackColor = SystemColors.ScrollBar;
            direcciontxt.Enabled = false;
            direcciontxt.Location = new Point(121, 237);
            direcciontxt.Name = "direcciontxt";
            direcciontxt.Size = new Size(144, 27);
            direcciontxt.TabIndex = 5;
            // 
            // dniLB
            // 
            dniLB.AutoSize = true;
            dniLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dniLB.Location = new Point(39, 308);
            dniLB.Name = "dniLB";
            dniLB.Size = new Size(37, 20);
            dniLB.TabIndex = 7;
            dniLB.Text = "DNI";
            // 
            // maskeddni
            // 
            maskeddni.BackColor = SystemColors.ScrollBar;
            maskeddni.Location = new Point(121, 305);
            maskeddni.Mask = "000-0000000-0";
            maskeddni.Name = "maskeddni";
            maskeddni.Size = new Size(125, 27);
            maskeddni.TabIndex = 8;
            // 
            // emailLB
            // 
            emailLB.AutoSize = true;
            emailLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailLB.Location = new Point(482, 97);
            emailLB.Name = "emailLB";
            emailLB.Size = new Size(47, 20);
            emailLB.TabIndex = 10;
            emailLB.Text = "Email";
            // 
            // emailtxt
            // 
            emailtxt.BackColor = SystemColors.ScrollBar;
            emailtxt.Enabled = false;
            emailtxt.Location = new Point(564, 97);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(144, 27);
            emailtxt.TabIndex = 9;
            // 
            // maskedtel
            // 
            maskedtel.BackColor = SystemColors.ScrollBar;
            maskedtel.Enabled = false;
            maskedtel.Location = new Point(564, 163);
            maskedtel.Mask = "(999)-000-0000";
            maskedtel.Name = "maskedtel";
            maskedtel.Size = new Size(125, 27);
            maskedtel.TabIndex = 12;
            // 
            // telefonoLB
            // 
            telefonoLB.AutoSize = true;
            telefonoLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            telefonoLB.Location = new Point(482, 166);
            telefonoLB.Name = "telefonoLB";
            telefonoLB.Size = new Size(70, 20);
            telefonoLB.TabIndex = 11;
            telefonoLB.Text = "Telefono";
            // 
            // maskedcel
            // 
            maskedcel.BackColor = SystemColors.ScrollBar;
            maskedcel.Enabled = false;
            maskedcel.Location = new Point(564, 225);
            maskedcel.Mask = "(999)-000-0000";
            maskedcel.Name = "maskedcel";
            maskedcel.Size = new Size(125, 27);
            maskedcel.TabIndex = 14;
            // 
            // celularLB
            // 
            celularLB.AutoSize = true;
            celularLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            celularLB.Location = new Point(482, 228);
            celularLB.Name = "celularLB";
            celularLB.Size = new Size(57, 20);
            celularLB.TabIndex = 13;
            celularLB.Text = "Celular";
            // 
            // cargoLB
            // 
            cargoLB.AutoSize = true;
            cargoLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cargoLB.Location = new Point(482, 308);
            cargoLB.Name = "cargoLB";
            cargoLB.Size = new Size(50, 20);
            cargoLB.TabIndex = 16;
            cargoLB.Text = "Cargo";
            // 
            // cargotxt
            // 
            cargotxt.BackColor = SystemColors.ScrollBar;
            cargotxt.Enabled = false;
            cargotxt.Location = new Point(564, 308);
            cargotxt.Name = "cargotxt";
            cargotxt.Size = new Size(144, 27);
            cargotxt.TabIndex = 15;
            // 
            // nuevobtn
            // 
            nuevobtn.BackColor = Color.Tomato;
            nuevobtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nuevobtn.Location = new Point(202, 381);
            nuevobtn.Name = "nuevobtn";
            nuevobtn.Size = new Size(94, 29);
            nuevobtn.TabIndex = 17;
            nuevobtn.Text = "Nuevo";
            nuevobtn.UseVisualStyleBackColor = false;
            nuevobtn.Click += nuevobtn_Click_1;
            // 
            // guardarbtn
            // 
            guardarbtn.BackColor = Color.Tomato;
            guardarbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guardarbtn.Location = new Point(458, 381);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(94, 29);
            guardarbtn.TabIndex = 18;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = false;
            guardarbtn.Click += guardarbtn_Click_1;
            // 
            // agrempleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(803, 506);
            Controls.Add(guardarbtn);
            Controls.Add(nuevobtn);
            Controls.Add(cargoLB);
            Controls.Add(cargotxt);
            Controls.Add(maskedcel);
            Controls.Add(celularLB);
            Controls.Add(maskedtel);
            Controls.Add(telefonoLB);
            Controls.Add(emailLB);
            Controls.Add(emailtxt);
            Controls.Add(maskeddni);
            Controls.Add(dniLB);
            Controls.Add(direccionLB);
            Controls.Add(direcciontxt);
            Controls.Add(apellidoLB);
            Controls.Add(apellidotxt);
            Controls.Add(nombreLB);
            Controls.Add(entreadoempleadoLB);
            Controls.Add(nombretxt);
            Name = "agrempleado";
            Text = "Entrada de Empleado";
            Load += agrempleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombretxt;
        private Label entreadoempleadoLB;
        private Label nombreLB;
        private Label apellidoLB;
        private TextBox apellidotxt;
        private Label direccionLB;
        private TextBox direcciontxt;
        private Label dniLB;
        private MaskedTextBox maskeddni;
        private Label emailLB;
        private TextBox emailtxt;
        private MaskedTextBox maskedtel;
        private Label telefonoLB;
        private MaskedTextBox maskedcel;
        private Label celularLB;
        private Label cargoLB;
        private TextBox cargotxt;
        private Button nuevobtn;
        private Button guardarbtn;
    }
}