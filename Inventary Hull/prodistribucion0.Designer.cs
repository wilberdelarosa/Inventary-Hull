﻿namespace Inventary_Hull
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(711, 278);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // distribuciondecategoriaLB
            // 
            distribuciondecategoriaLB.AutoSize = true;
            distribuciondecategoriaLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            distribuciondecategoriaLB.Location = new Point(213, 9);
            distribuciondecategoriaLB.Name = "distribuciondecategoriaLB";
            distribuciondecategoriaLB.Size = new Size(299, 28);
            distribuciondecategoriaLB.TabIndex = 1;
            distribuciondecategoriaLB.Text = "DISTRIBUCION DE CATEGORIA";
            // 
            // comboBoxProductIDs
            // 
            comboBoxProductIDs.FormattingEnabled = true;
            comboBoxProductIDs.Location = new Point(79, 391);
            comboBoxProductIDs.Name = "comboBoxProductIDs";
            comboBoxProductIDs.Size = new Size(151, 28);
            comboBoxProductIDs.TabIndex = 2;
            comboBoxProductIDs.SelectedIndexChanged += comboBoxProductIDs_SelectedIndexChanged;
            // 
            // textBoxNewSeccion
            // 
            textBoxNewSeccion.Location = new Point(493, 386);
            textBoxNewSeccion.Name = "textBoxNewSeccion";
            textBoxNewSeccion.Size = new Size(125, 27);
            textBoxNewSeccion.TabIndex = 3;
            // 
            // buttonseccionupdate
            // 
            buttonseccionupdate.Location = new Point(313, 483);
            buttonseccionupdate.Name = "buttonseccionupdate";
            buttonseccionupdate.Size = new Size(94, 29);
            buttonseccionupdate.TabIndex = 4;
            buttonseccionupdate.Text = "Actualizar";
            buttonseccionupdate.UseVisualStyleBackColor = true;
            buttonseccionupdate.Click += buttonseccionupdate_Click;
            // 
            // nuevaseccionLB
            // 
            nuevaseccionLB.AutoSize = true;
            nuevaseccionLB.Location = new Point(525, 349);
            nuevaseccionLB.Name = "nuevaseccionLB";
            nuevaseccionLB.Size = new Size(120, 20);
            nuevaseccionLB.TabIndex = 5;
            nuevaseccionLB.Text = "NUEVA SECCION";
            // 
            // idproductoLB
            // 
            idproductoLB.AutoSize = true;
            idproductoLB.Location = new Point(113, 349);
            idproductoLB.Name = "idproductoLB";
            idproductoLB.Size = new Size(104, 20);
            idproductoLB.TabIndex = 6;
            idproductoLB.Text = "ID PRODUCTO";
            // 
            // prodistribucion0
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
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