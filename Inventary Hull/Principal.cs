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
            Application.Exit();
            this.Dispose();
        }
        //llamar formulario agrproducto

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrproducto agrproducto = new agrproducto();
            agrproducto.ShowDialog();
        }
        //llamar formulario agrempleado
        private void eMPLEADOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            agrempleado agrempleado = new agrempleado();
            agrempleado.ShowDialog();
        }
        //llamar formulario agrsuplidor
        private void sUPLIDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrsuplidor agrsuplidor = new agrsuplidor();
            agrsuplidor.ShowDialog();
        }

        private void dISTRIBUCIONDEARTICULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodistribucion0 prodistribucion0 = new prodistribucion0();
            prodistribucion0.ShowDialog();
        }

        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conproducto conproducto = new conproducto();
            conproducto.ShowDialog();
        }

        private void eMPLEADOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            conempleado conempleado = new conempleado();
            conempleado.ShowDialog();
        }

        private void sUPLIDORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consuplidor consuplidor = new consuplidor();
            consuplidor.ShowDialog();
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acercadesis acercadesis = new acercadesis();
            acercadesis.ShowDialog();
        }
        private void PrincipalFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Esto cerrará la aplicación cuando el formulario principal se cierre
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}