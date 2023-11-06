namespace Inventary_Hull
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Btncerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrproducto agrproducto = new agrproducto();
            agrproducto.Show();
        }
    }
}