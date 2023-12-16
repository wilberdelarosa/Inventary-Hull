namespace Inventary_Hull
{
    partial class acercadesis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acercadesis));
            panel1 = new Panel();
            richTextBoxacercade = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBoxacercade);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 450);
            panel1.TabIndex = 0;
            // 
            // richTextBoxacercade
            // 
            richTextBoxacercade.Dock = DockStyle.Fill;
            richTextBoxacercade.Location = new Point(0, 0);
            richTextBoxacercade.Name = "richTextBoxacercade";
            richTextBoxacercade.Size = new Size(779, 450);
            richTextBoxacercade.TabIndex = 0;
            richTextBoxacercade.Text = resources.GetString("richTextBoxacercade.Text");
            richTextBoxacercade.TextChanged += richTextBoxacercade_TextChanged;
            // 
            // acercadesis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 506);
            Controls.Add(panel1);
            Name = "acercadesis";
            Text = "Acerca de sistema";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox richTextBoxacercade;
    }
}