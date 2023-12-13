namespace Inventary_Hull
{
    partial class conproducto
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
            txtID = new TextBox();
            buscarbtn = new Button();
            refreshbtn = new Button();
            buscarLB = new Label();
            consultadeproductoLB = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(740, 239);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtID
            // 
            txtID.Location = new Point(88, 401);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // buscarbtn
            // 
            buscarbtn.Location = new Point(340, 399);
            buscarbtn.Name = "buscarbtn";
            buscarbtn.Size = new Size(94, 29);
            buscarbtn.TabIndex = 2;
            buscarbtn.Text = "Buscar";
            buscarbtn.UseVisualStyleBackColor = true;
            buscarbtn.Click += buscarbtn_Click;
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(536, 399);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(94, 29);
            refreshbtn.TabIndex = 3;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // buscarLB
            // 
            buscarLB.AutoSize = true;
            buscarLB.Location = new Point(70, 378);
            buscarLB.Name = "buscarLB";
            buscarLB.Size = new Size(165, 20);
            buscarLB.TabIndex = 4;
            buscarLB.Text = "Inserte ID del producto.";
            // 
            // consultadeproductoLB
            // 
            consultadeproductoLB.AutoSize = true;
            consultadeproductoLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            consultadeproductoLB.Location = new Point(282, 21);
            consultadeproductoLB.Name = "consultadeproductoLB";
            consultadeproductoLB.Size = new Size(215, 28);
            consultadeproductoLB.TabIndex = 5;
            consultadeproductoLB.Text = "Consulta de Producto";
            // 
            // conproducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 506);
            Controls.Add(consultadeproductoLB);
            Controls.Add(buscarLB);
            Controls.Add(refreshbtn);
            Controls.Add(buscarbtn);
            Controls.Add(txtID);
            Controls.Add(dataGridView1);
            Name = "conproducto";
            Text = "Consulta Producto ";
            Load += conproducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtID;
        private Button buscarbtn;
        private Button refreshbtn;
        private Label buscarLB;
        private Label consultadeproductoLB;
    }
}