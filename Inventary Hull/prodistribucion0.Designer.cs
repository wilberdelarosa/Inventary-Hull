namespace Inventary_Hull
{
    partial class prodistribucion0
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
            dataGridView1 = new DataGridView();
            distribuciondecategoriaLB = new Label();
            comboBoxProductIDs = new ComboBox();
            textBoxNewSeccion = new TextBox();
            buttonseccionupdate = new Button();
            nuevaseccionLB = new Label();
            idproductoLB = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(805, 357);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // distribuciondecategoriaLB
            // 
            distribuciondecategoriaLB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            distribuciondecategoriaLB.AutoSize = true;
            distribuciondecategoriaLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            distribuciondecategoriaLB.Location = new Point(229, 9);
            distribuciondecategoriaLB.Name = "distribuciondecategoriaLB";
            distribuciondecategoriaLB.Size = new Size(299, 28);
            distribuciondecategoriaLB.TabIndex = 1;
            distribuciondecategoriaLB.Text = "DISTRIBUCION DE CATEGORIA";
            // 
            // comboBoxProductIDs
            // 
            comboBoxProductIDs.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxProductIDs.FormattingEnabled = true;
            comboBoxProductIDs.Location = new Point(177, 466);
            comboBoxProductIDs.Name = "comboBoxProductIDs";
            comboBoxProductIDs.Size = new Size(151, 28);
            comboBoxProductIDs.TabIndex = 2;
            comboBoxProductIDs.SelectedIndexChanged += comboBoxProductIDs_SelectedIndexChanged;
            // 
            // textBoxNewSeccion
            // 
            textBoxNewSeccion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxNewSeccion.Location = new Point(356, 467);
            textBoxNewSeccion.Name = "textBoxNewSeccion";
            textBoxNewSeccion.Size = new Size(125, 27);
            textBoxNewSeccion.TabIndex = 3;
            // 
            // buttonseccionupdate
            // 
            buttonseccionupdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonseccionupdate.BackColor = Color.OrangeRed;
            buttonseccionupdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonseccionupdate.ForeColor = SystemColors.ButtonFace;
            buttonseccionupdate.Location = new Point(522, 467);
            buttonseccionupdate.Name = "buttonseccionupdate";
            buttonseccionupdate.Size = new Size(94, 29);
            buttonseccionupdate.TabIndex = 4;
            buttonseccionupdate.Text = "Actualizar";
            buttonseccionupdate.UseVisualStyleBackColor = false;
            buttonseccionupdate.Click += buttonseccionupdate_Click;
            // 
            // nuevaseccionLB
            // 
            nuevaseccionLB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nuevaseccionLB.AutoSize = true;
            nuevaseccionLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nuevaseccionLB.ForeColor = SystemColors.ActiveCaptionText;
            nuevaseccionLB.Location = new Point(361, 427);
            nuevaseccionLB.Name = "nuevaseccionLB";
            nuevaseccionLB.Size = new Size(126, 20);
            nuevaseccionLB.TabIndex = 5;
            nuevaseccionLB.Text = "NUEVA SECCION";
            // 
            // idproductoLB
            // 
            idproductoLB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            idproductoLB.AutoSize = true;
            idproductoLB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idproductoLB.Location = new Point(200, 427);
            idproductoLB.Name = "idproductoLB";
            idproductoLB.Size = new Size(125, 23);
            idproductoLB.TabIndex = 6;
            idproductoLB.Text = "ID PRODUCTO";
            // 
            // prodistribucion0
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 506);
            Controls.Add(idproductoLB);
            Controls.Add(nuevaseccionLB);
            Controls.Add(buttonseccionupdate);
            Controls.Add(textBoxNewSeccion);
            Controls.Add(comboBoxProductIDs);
            Controls.Add(distribuciondecategoriaLB);
            Controls.Add(dataGridView1);
            Name = "prodistribucion0";
            Text = "Distribucion de Categoria";
            Load += prodistribucion0_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label distribuciondecategoriaLB;
        private ComboBox comboBoxProductIDs;
        private TextBox textBoxNewSeccion;
        private Button buttonseccionupdate;
        private Label nuevaseccionLB;
        private Label idproductoLB;
    }
}