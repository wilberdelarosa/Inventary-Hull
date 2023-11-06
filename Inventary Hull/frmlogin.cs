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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "wilfre2" && mtxtpassword.Text == "123456789")
            {
                Principal principal = new Principal();
                principal.Show();
                MessageBox.Show("Bienvenido al sistema Inventory Hall," + txtusuario.Text);

            }
            {
                if (txtusuario.Text != "wilfre2" && mtxtpassword.Text != "123456789")
                {
                    MessageBox.Show("El usuario y la contrasea están incorrectas");

                }
                else if (txtusuario.Text != "wilfre2")
                {
                    MessageBox.Show("El usuario es incorrecto");
                }
                else if (mtxtpassword.Text != "123456789")
                {
                    MessageBox.Show("La contraseña es incorrecta");

              
                }
            }
        }
    }
}
