namespace Inventary_Hull
{
    partial class Principal
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
            menuStrip1 = new MenuStrip();
            eNTRADAToolStripMenuItem = new ToolStripMenuItem();
            eMPLEADOToolStripMenuItem = new ToolStripMenuItem();
            eMPLEADOToolStripMenuItem1 = new ToolStripMenuItem();
            sUPLIDORToolStripMenuItem = new ToolStripMenuItem();
            pROCESOToolStripMenuItem = new ToolStripMenuItem();
            dISTRIBUCIONDEARTICULOToolStripMenuItem = new ToolStripMenuItem();
            cONSULTAToolStripMenuItem = new ToolStripMenuItem();
            pRODUCTOToolStripMenuItem = new ToolStripMenuItem();
            eMPLEADOToolStripMenuItem2 = new ToolStripMenuItem();
            sUPLIDORToolStripMenuItem1 = new ToolStripMenuItem();
            sISTEMAToolStripMenuItem = new ToolStripMenuItem();
            aCERCADEToolStripMenuItem = new ToolStripMenuItem();
            btncerrar = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { eNTRADAToolStripMenuItem, pROCESOToolStripMenuItem, cONSULTAToolStripMenuItem, sISTEMAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // eNTRADAToolStripMenuItem
            // 
            eNTRADAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eMPLEADOToolStripMenuItem, eMPLEADOToolStripMenuItem1, sUPLIDORToolStripMenuItem });
            eNTRADAToolStripMenuItem.Name = "eNTRADAToolStripMenuItem";
            eNTRADAToolStripMenuItem.Size = new Size(90, 24);
            eNTRADAToolStripMenuItem.Text = "ENTRADA";
            // 
            // eMPLEADOToolStripMenuItem
            // 
            eMPLEADOToolStripMenuItem.Name = "eMPLEADOToolStripMenuItem";
            eMPLEADOToolStripMenuItem.Size = new Size(168, 26);
            eMPLEADOToolStripMenuItem.Text = "PRODUCTO";
            eMPLEADOToolStripMenuItem.Click += eMPLEADOToolStripMenuItem_Click;
            // 
            // eMPLEADOToolStripMenuItem1
            // 
            eMPLEADOToolStripMenuItem1.Name = "eMPLEADOToolStripMenuItem1";
            eMPLEADOToolStripMenuItem1.Size = new Size(168, 26);
            eMPLEADOToolStripMenuItem1.Text = "EMPLEADO";
            eMPLEADOToolStripMenuItem1.Click += eMPLEADOToolStripMenuItem1_Click;
            // 
            // sUPLIDORToolStripMenuItem
            // 
            sUPLIDORToolStripMenuItem.Name = "sUPLIDORToolStripMenuItem";
            sUPLIDORToolStripMenuItem.Size = new Size(168, 26);
            sUPLIDORToolStripMenuItem.Text = "SUPLIDOR";
            sUPLIDORToolStripMenuItem.Click += sUPLIDORToolStripMenuItem_Click;
            // 
            // pROCESOToolStripMenuItem
            // 
            pROCESOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dISTRIBUCIONDEARTICULOToolStripMenuItem });
            pROCESOToolStripMenuItem.Name = "pROCESOToolStripMenuItem";
            pROCESOToolStripMenuItem.Size = new Size(87, 24);
            pROCESOToolStripMenuItem.Text = "PROCESO";
            // 
            // dISTRIBUCIONDEARTICULOToolStripMenuItem
            // 
            dISTRIBUCIONDEARTICULOToolStripMenuItem.Name = "dISTRIBUCIONDEARTICULOToolStripMenuItem";
            dISTRIBUCIONDEARTICULOToolStripMenuItem.Size = new Size(283, 26);
            dISTRIBUCIONDEARTICULOToolStripMenuItem.Text = "DISTRIBUCION DE ARTICULO";
            dISTRIBUCIONDEARTICULOToolStripMenuItem.Click += dISTRIBUCIONDEARTICULOToolStripMenuItem_Click;
            // 
            // cONSULTAToolStripMenuItem
            // 
            cONSULTAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pRODUCTOToolStripMenuItem, eMPLEADOToolStripMenuItem2, sUPLIDORToolStripMenuItem1 });
            cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            cONSULTAToolStripMenuItem.Size = new Size(95, 24);
            cONSULTAToolStripMenuItem.Text = "CONSULTA";
            // 
            // pRODUCTOToolStripMenuItem
            // 
            pRODUCTOToolStripMenuItem.Name = "pRODUCTOToolStripMenuItem";
            pRODUCTOToolStripMenuItem.Size = new Size(168, 26);
            pRODUCTOToolStripMenuItem.Text = "PRODUCTO";
            // 
            // eMPLEADOToolStripMenuItem2
            // 
            eMPLEADOToolStripMenuItem2.Name = "eMPLEADOToolStripMenuItem2";
            eMPLEADOToolStripMenuItem2.Size = new Size(168, 26);
            eMPLEADOToolStripMenuItem2.Text = "EMPLEADO";
            // 
            // sUPLIDORToolStripMenuItem1
            // 
            sUPLIDORToolStripMenuItem1.Name = "sUPLIDORToolStripMenuItem1";
            sUPLIDORToolStripMenuItem1.Size = new Size(168, 26);
            sUPLIDORToolStripMenuItem1.Text = "SUPLIDOR";
            // 
            // sISTEMAToolStripMenuItem
            // 
            sISTEMAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aCERCADEToolStripMenuItem });
            sISTEMAToolStripMenuItem.Name = "sISTEMAToolStripMenuItem";
            sISTEMAToolStripMenuItem.Size = new Size(82, 24);
            sISTEMAToolStripMenuItem.Text = "SISTEMA";
            // 
            // aCERCADEToolStripMenuItem
            // 
            aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            aCERCADEToolStripMenuItem.Size = new Size(170, 26);
            aCERCADEToolStripMenuItem.Text = "ACERCA DE";
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.BackColor = SystemColors.ButtonFace;
            btncerrar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btncerrar.Image = Properties.Resources._5402411_down_log_off_out_power_icon;
            btncerrar.ImageAlign = ContentAlignment.TopCenter;
            btncerrar.Location = new Point(721, 391);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(88, 70);
            btncerrar.TabIndex = 1;
            btncerrar.Text = "CERRAR";
            btncerrar.TextAlign = ContentAlignment.BottomCenter;
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += Btncerrar;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btncerrar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Principal";
            Text = "Inventory hull";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Button btncerrar;
        private ToolStripMenuItem eNTRADAToolStripMenuItem;
        private ToolStripMenuItem eMPLEADOToolStripMenuItem;
        private ToolStripMenuItem eMPLEADOToolStripMenuItem1;
        private ToolStripMenuItem sUPLIDORToolStripMenuItem;
        private ToolStripMenuItem pROCESOToolStripMenuItem;
        private ToolStripMenuItem dISTRIBUCIONDEARTICULOToolStripMenuItem;
        private ToolStripMenuItem cONSULTAToolStripMenuItem;
        private ToolStripMenuItem pRODUCTOToolStripMenuItem;
        private ToolStripMenuItem eMPLEADOToolStripMenuItem2;
        private ToolStripMenuItem sUPLIDORToolStripMenuItem1;
        private ToolStripMenuItem sISTEMAToolStripMenuItem;
        private ToolStripMenuItem aCERCADEToolStripMenuItem;
    }
}