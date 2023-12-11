namespace Inventary_Hull
{
    partial class prodistribucion
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            databaseManagerBindingSource3 = new BindingSource(components);
            databaseManagerBindingSource = new BindingSource(components);
            idproductoLB = new Label();
            distribuciondecategoriaLB = new Label();
            nuevaseccionLB = new Label();
            buttonseccionupdate = new Button();
            textBoxNewSeccion = new TextBox();
            comboBoxProductIDs = new ComboBox();
            databaseManagerBindingSource1 = new BindingSource(components);
            databaseManagerBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = databaseManagerBindingSource3;
            dataGridView1.Location = new Point(24, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(742, 286);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.CellEndEdit += dataGridView1_CellContentClick_1;
            // 
            // databaseManagerBindingSource3
            // 
            databaseManagerBindingSource3.DataSource = typeof(DatabaseManager);
            // 
            // databaseManagerBindingSource
            // 
            databaseManagerBindingSource.DataSource = typeof(DatabaseManager);
            // 
            // idproductoLB
            // 
            idproductoLB.AutoSize = true;
            idproductoLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            idproductoLB.Location = new Point(54, 460);
            idproductoLB.Name = "idproductoLB";
            idproductoLB.Size = new Size(125, 23);
            idproductoLB.TabIndex = 1;
            idproductoLB.Text = "ID PRODUCTO";
            // 
            // distribuciondecategoriaLB
            // 
            distribuciondecategoriaLB.AutoSize = true;
            distribuciondecategoriaLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            distribuciondecategoriaLB.Location = new Point(264, 37);
            distribuciondecategoriaLB.Name = "distribuciondecategoriaLB";
            distribuciondecategoriaLB.Size = new Size(299, 28);
            distribuciondecategoriaLB.TabIndex = 2;
            distribuciondecategoriaLB.Text = "DISTRIBUCION DE CATEGORIA";
            // 
            // nuevaseccionLB
            // 
            nuevaseccionLB.AutoSize = true;
            nuevaseccionLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nuevaseccionLB.Location = new Point(460, 460);
            nuevaseccionLB.Name = "nuevaseccionLB";
            nuevaseccionLB.Size = new Size(142, 23);
            nuevaseccionLB.TabIndex = 3;
            nuevaseccionLB.Text = "NUEVA SECCION";
            // 
            // buttonseccionupdate
            // 
            buttonseccionupdate.BackColor = Color.Tomato;
            buttonseccionupdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonseccionupdate.Location = new Point(317, 518);
            buttonseccionupdate.Name = "buttonseccionupdate";
            buttonseccionupdate.Size = new Size(141, 42);
            buttonseccionupdate.TabIndex = 4;
            buttonseccionupdate.Text = "Actualizar";
            buttonseccionupdate.UseVisualStyleBackColor = false;
            buttonseccionupdate.Click += buttonseccionupdate_Click_;
            // 
            // textBoxNewSeccion
            // 
            textBoxNewSeccion.Location = new Point(621, 460);
            textBoxNewSeccion.Name = "textBoxNewSeccion";
            textBoxNewSeccion.Size = new Size(125, 27);
            textBoxNewSeccion.TabIndex = 5;
            // 
            // comboBoxProductIDs
            // 
            comboBoxProductIDs.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductIDs.FormattingEnabled = true;
            comboBoxProductIDs.Location = new Point(185, 458);
            comboBoxProductIDs.Name = "comboBoxProductIDs";
            comboBoxProductIDs.Size = new Size(151, 28);
            comboBoxProductIDs.TabIndex = 6;
            comboBoxProductIDs.SelectedIndexChanged += comboBoxProductIDs_SelectedIndexChanged;
            // 
            // databaseManagerBindingSource1
            // 
            databaseManagerBindingSource1.DataSource = typeof(DatabaseManager);
            // 
            // databaseManagerBindingSource2
            // 
            databaseManagerBindingSource2.DataSource = typeof(DatabaseManager);
            // 
            // prodistribucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(comboBoxProductIDs);
            Controls.Add(textBoxNewSeccion);
            Controls.Add(buttonseccionupdate);
            Controls.Add(nuevaseccionLB);
            Controls.Add(distribuciondecategoriaLB);
            Controls.Add(idproductoLB);
            Controls.Add(dataGridView1);
            Name = "prodistribucion";
            Text = "Distribucion de Categoria";
            Load += prodistribucion_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label idproductoLB;
        private Label distribuciondecategoriaLB;
        private Label nuevaseccionLB;
        private Button buttonseccionupdate;
        private TextBox textBoxNewSeccion;
        private ComboBox comboBoxProductIDs;
        private BindingSource databaseManagerBindingSource;
        private BindingSource databaseManagerBindingSource2;
        private BindingSource databaseManagerBindingSource1;
        private BindingSource databaseManagerBindingSource3;
    }
}