namespace Inventary_Hull
{
    partial class agrsuplidor
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
            guardarbtn = new Button();
            insertarbtn = new Button();
            telefonoLB = new Label();
            descripciontxt = new RichTextBox();
            descripcionLB = new Label();
            rncLB = new Label();
            nombreLB = new Label();
            label7 = new Label();
            nombretxt = new TextBox();
            emailtxt = new MaskedTextBox();
            rnctxt = new MaskedTextBox();
            telefonotxt = new MaskedTextBox();
            direcciontxt = new MaskedTextBox();
            emailLB = new Label();
            direccionLB = new Label();
            SuspendLayout();
            // 
            // guardarbtn
            // 
            guardarbtn.BackColor = Color.Coral;
            guardarbtn.Location = new Point(513, 402);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(106, 29);
            guardarbtn.TabIndex = 27;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = false;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // insertarbtn
            // 
            insertarbtn.BackColor = Color.Coral;
            insertarbtn.Location = new Point(159, 402);
            insertarbtn.Name = "insertarbtn";
            insertarbtn.Size = new Size(106, 29);
            insertarbtn.TabIndex = 26;
            insertarbtn.Text = "Nuevo";
            insertarbtn.UseVisualStyleBackColor = false;
            insertarbtn.Click += insertarbtn_Click;
            // 
            // telefonoLB
            // 
            telefonoLB.AutoSize = true;
            telefonoLB.Location = new Point(12, 244);
            telefonoLB.Name = "telefonoLB";
            telefonoLB.Size = new Size(70, 20);
            telefonoLB.TabIndex = 20;
            telefonoLB.Text = "Telefono";
            // 
            // descripciontxt
            // 
            descripciontxt.BackColor = Color.DarkGray;
            descripciontxt.Enabled = false;
            descripciontxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            descripciontxt.Location = new Point(96, 317);
            descripciontxt.Name = "descripciontxt";
            descripciontxt.Size = new Size(692, 63);
            descripciontxt.TabIndex = 19;
            descripciontxt.Text = "";
            // 
            // descripcionLB
            // 
            descripcionLB.AutoSize = true;
            descripcionLB.Location = new Point(381, 275);
            descripcionLB.Name = "descripcionLB";
            descripcionLB.Size = new Size(90, 20);
            descripcionLB.TabIndex = 18;
            descripcionLB.Text = "Descripcion";
            // 
            // rncLB
            // 
            rncLB.AutoSize = true;
            rncLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rncLB.Location = new Point(12, 173);
            rncLB.Name = "rncLB";
            rncLB.Size = new Size(40, 20);
            rncLB.TabIndex = 17;
            rncLB.Text = "RNC";
            // 
            // nombreLB
            // 
            nombreLB.AutoSize = true;
            nombreLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nombreLB.Location = new Point(12, 97);
            nombreLB.Name = "nombreLB";
            nombreLB.Size = new Size(67, 20);
            nombreLB.TabIndex = 16;
            nombreLB.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(267, 29);
            label7.Name = "label7";
            label7.Size = new Size(241, 28);
            label7.TabIndex = 29;
            label7.Text = "ENTRADA DE SUPLIDOR";
            // 
            // nombretxt
            // 
            nombretxt.BackColor = SystemColors.ScrollBar;
            nombretxt.Enabled = false;
            nombretxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nombretxt.Location = new Point(125, 95);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(222, 27);
            nombretxt.TabIndex = 30;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = SystemColors.ScrollBar;
            emailtxt.Enabled = false;
            emailtxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxt.Location = new Point(551, 97);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(222, 27);
            emailtxt.TabIndex = 31;
            // 
            // rnctxt
            // 
            rnctxt.BackColor = SystemColors.ScrollBar;
            rnctxt.Enabled = false;
            rnctxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rnctxt.Location = new Point(125, 173);
            rnctxt.Mask = "000-00000-0";
            rnctxt.Name = "rnctxt";
            rnctxt.Size = new Size(95, 27);
            rnctxt.TabIndex = 32;
            rnctxt.MaskInputRejected += rnctxt_MaskInputRejected;
            // 
            // telefonotxt
            // 
            telefonotxt.BackColor = SystemColors.ScrollBar;
            telefonotxt.Enabled = false;
            telefonotxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            telefonotxt.Location = new Point(125, 241);
            telefonotxt.Mask = "(999) 000-0000";
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(140, 27);
            telefonotxt.TabIndex = 33;
            telefonotxt.MaskInputRejected += telefonotxt_MaskInputRejected;
            // 
            // direcciontxt
            // 
            direcciontxt.BackColor = SystemColors.ScrollBar;
            direcciontxt.Enabled = false;
            direcciontxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            direcciontxt.Location = new Point(551, 173);
            direcciontxt.Name = "direcciontxt";
            direcciontxt.Size = new Size(222, 27);
            direcciontxt.TabIndex = 34;
            // 
            // emailLB
            // 
            emailLB.AutoSize = true;
            emailLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailLB.Location = new Point(462, 99);
            emailLB.Name = "emailLB";
            emailLB.Size = new Size(47, 20);
            emailLB.TabIndex = 35;
            emailLB.Text = "Email";
            // 
            // direccionLB
            // 
            direccionLB.AutoSize = true;
            direccionLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            direccionLB.Location = new Point(462, 173);
            direccionLB.Name = "direccionLB";
            direccionLB.Size = new Size(74, 20);
            direccionLB.TabIndex = 36;
            direccionLB.Text = "Direccion";
            // 
            // agrsuplidor
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 506);
            Controls.Add(direccionLB);
            Controls.Add(emailLB);
            Controls.Add(direcciontxt);
            Controls.Add(telefonotxt);
            Controls.Add(rnctxt);
            Controls.Add(emailtxt);
            Controls.Add(nombretxt);
            Controls.Add(label7);
            Controls.Add(guardarbtn);
            Controls.Add(insertarbtn);
            Controls.Add(telefonoLB);
            Controls.Add(descripciontxt);
            Controls.Add(descripcionLB);
            Controls.Add(rncLB);
            Controls.Add(nombreLB);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "agrsuplidor";
            Text = "Entrada de Suplidor ";
            Load += agrsuplidor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox secciontxt;
        private Button guardarbtn;
        private Button insertarbtn;
        private ComboBox idsuplidortxt;
        private Label label6;
        private Label label5;
        private TextBox stocktxt;
        private Label telefonoLB;
        private RichTextBox descripciontxt;
        private Label descripcionLB;
        private Label rncLB;
        private Label nombreLB;
        private Label label7;
        private TextBox nombretxt;
        private MaskedTextBox emailtxt;
        private MaskedTextBox rnctxt;
        private MaskedTextBox telefonotxt;
        private MaskedTextBox direcciontxt;
        private Label emailLB;
        private Label direccionLB;
    }
}