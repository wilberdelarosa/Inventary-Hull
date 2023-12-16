using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventary_Hull
{
    public partial class Principal0 : Form
    {
        private Form currentForm = null;
        public Principal0()
        {
            InitializeComponent();

        }
        private void HideSubmenu()
        {
            Panelsubmenuentrada.Visible = false;
            panelsubmenuproceso.Visible = false;
            panelsubmenuconsulta.Visible = false;
            panelsubmenusistema.Visible = false;
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void Principal0_Load(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btnentrada_Click(object sender, EventArgs e)
        {
            ShowSubmenu(Panelsubmenuentrada);
        }

        private void btnproceso_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelsubmenuproceso);
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelsubmenuconsulta);
        }

        private void btnsistema_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelsubmenusistema);
        }

        private void btnsub1suplidor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new agrsuplidor());

            HideSubmenu();
        }

        private void Panelsubmenuentrada_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsub1empleado_Click(object sender, EventArgs e)
        {

            OpenChildForm(new agrempleado());
            HideSubmenu();
        }

        private void btnsub2disart_Click(object sender, EventArgs e)
        {

            OpenChildForm(new prodistribucion0());
            HideSubmenu();
        }

        private void btnsub3producto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new conproducto());
            HideSubmenu();
        }

        private void btnsub3empelado_Click(object sender, EventArgs e)
        {

            OpenChildForm(new conempleado());
            HideSubmenu();
        }

        private void btnsub3suplidor_Click(object sender, EventArgs e)
        {

            OpenChildForm(new consuplidor());
            HideSubmenu();
        }

        private void btnsub4acercade_Click(object sender, EventArgs e)
        {
            OpenChildForm(new acercadesis());
            HideSubmenu();
        }

        private void btnsub1producto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new agrproducto());
            HideSubmenu();
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                activeForm = childForm;
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(childForm);
            PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();  // Muestra el formulario hijo
        }

        private void PanelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lbltitulo1_Click(object sender, EventArgs e)
        {
            Principal0 principal0 = new Principal0();

            principal0.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal0 principal0 = new Principal0();

            principal0.ShowDialog();
        }
    }
}
