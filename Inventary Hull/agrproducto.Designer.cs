namespace Inventary_Hull
{
    partial class agrproducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agrproducto));
            nombretxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            categoriabox = new ComboBox();
            label3 = new Label();
            descripciontxt = new RichTextBox();
            label4 = new Label();
            stocktxt = new TextBox();
            label5 = new Label();
            secciontxt = new TextBox();
            label6 = new Label();
            idsuplidortxt = new ComboBox();
            insertarbtn = new Button();
            guardarbtn = new Button();
            SuspendLayout();
            // 
            // nombretxt
            // 
            nombretxt.BackColor = SystemColors.ButtonShadow;
            nombretxt.Enabled = false;
            nombretxt.ForeColor = SystemColors.ActiveBorder;
            nombretxt.Location = new Point(132, 40);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(198, 27);
            nombretxt.TabIndex = 0;
            nombretxt.TextChanged += nombretxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 123);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Categoria";
            // 
            // categoriabox
            // 
            categoriabox.BackColor = SystemColors.ActiveBorder;
            categoriabox.Enabled = false;
            categoriabox.FormattingEnabled = true;
            categoriabox.Location = new Point(132, 120);
            categoriabox.Name = "categoriabox";
            categoriabox.Size = new Size(198, 28);
            categoriabox.TabIndex = 3;
            categoriabox.SelectedIndexChanged += categoriabox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 246);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // descripciontxt
            // 
            descripciontxt.BackColor = Color.DarkGray;
            descripciontxt.Enabled = false;
            descripciontxt.Location = new Point(71, 288);
            descripciontxt.Name = "descripciontxt";
            descripciontxt.Size = new Size(616, 63);
            descripciontxt.TabIndex = 5;
            descripciontxt.Text = "";
            descripciontxt.TextChanged += descripciontxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 194);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Stock";
            // 
            // stocktxt
            // 
            stocktxt.AcceptsReturn = true;
            stocktxt.BackColor = SystemColors.ActiveBorder;
            stocktxt.Enabled = false;
            stocktxt.Location = new Point(132, 187);
            stocktxt.Name = "stocktxt";
            stocktxt.Size = new Size(38, 27);
            stocktxt.TabIndex = 7;
            stocktxt.TextChanged += stocktxt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 47);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 8;
            label5.Text = "Sección";
            // 
            // secciontxt
            // 
            secciontxt.BackColor = SystemColors.ActiveBorder;
            secciontxt.Enabled = false;
            secciontxt.Location = new Point(510, 40);
            secciontxt.Name = "secciontxt";
            secciontxt.Size = new Size(198, 27);
            secciontxt.TabIndex = 9;
            secciontxt.TextChanged += secciontxt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 128);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 10;
            label6.Text = "ID Suplidor";
            // 
            // idsuplidortxt
            // 
            idsuplidortxt.BackColor = SystemColors.ActiveBorder;
            idsuplidortxt.Enabled = false;
            idsuplidortxt.FormattingEnabled = true;
            idsuplidortxt.Location = new Point(510, 120);
            idsuplidortxt.Name = "idsuplidortxt";
            idsuplidortxt.Size = new Size(198, 28);
            idsuplidortxt.TabIndex = 11;
            idsuplidortxt.SelectedIndexChanged += idsuplidortxt_SelectedIndexChanged;
            // 
            // insertarbtn
            // 
            insertarbtn.BackColor = Color.Coral;
            insertarbtn.Location = new Point(151, 375);
            insertarbtn.Name = "insertarbtn";
            insertarbtn.Size = new Size(94, 29);
            insertarbtn.TabIndex = 12;
            insertarbtn.Text = "Nuevo";
            insertarbtn.UseVisualStyleBackColor = false;
            insertarbtn.Click += insertarbtn_Click;
            // 
            // guardarbtn
            // 
            guardarbtn.BackColor = Color.Coral;
            guardarbtn.Location = new Point(466, 375);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(94, 29);
            guardarbtn.TabIndex = 13;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = false;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // agrproducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guardarbtn);
            Controls.Add(insertarbtn);
            Controls.Add(idsuplidortxt);
            Controls.Add(label6);
            Controls.Add(secciontxt);
            Controls.Add(label5);
            Controls.Add(stocktxt);
            Controls.Add(label4);
            Controls.Add(descripciontxt);
            Controls.Add(label3);
            Controls.Add(categoriabox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nombretxt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "agrproducto";
            Text = "Entrada producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombretxt;
        private Label label1;
        private Label label2;
        private ComboBox categoriabox;
        private Label label3;
        private RichTextBox descripciontxt;
        private Label label4;
        private TextBox stocktxt;
        private Label label5;
        private TextBox secciontxt;
        private Label label6;
        private ComboBox idsuplidortxt;
        private Button insertarbtn;
        private Button guardarbtn;
    }
}