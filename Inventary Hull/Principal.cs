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
    }
}