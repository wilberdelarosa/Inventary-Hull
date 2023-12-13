using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Inventary_Hull
{
    public partial class frmlogin : Form

    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private Button activeButton;
        public frmlogin()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(frmlogin_MouseDown);
            btnAdmin.Click += new EventHandler(btnAdmin_Click);
            btnInvitado.Click += new EventHandler(btnInvitado_Click);
        }

        private void frmlogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void SetActiveButton(Button button)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.Gray; // Color original o inactivo

                mtxtpassword.Enabled = true;
                txtusuario.Enabled = true;

                mtxtpassword.BackColor = Color.White;
                txtusuario.BackColor = Color.White;

            }

            activeButton = button;
            activeButton.BackColor = Color.OrangeRed; // Color de botón activo
        }
        private void btnlogin_Click(object sender, EventArgs e)

        {

            // Comprobar qué botón está activo
            string username = txtusuario.Text;
            string password = mtxtpassword.Text;

            // Comprobar si el botón de Administrador está activo
            if (activeButton == btnAdmin)
            {
                if (username != "wilfre2" && password != "123456789")
                {
                    MessageBox.Show("El usuario y contraseña de Administrador son incorrectas");
                }

                else if (username != "wilfre2")
                {
                    MessageBox.Show("El nombre de usuario de Administrador es incorrecto");
                }
                else if (password != "123456789")
                {
                    MessageBox.Show("La contraseña de Administrador es incorrecta");
                }
                else if (username == "wilfre2" && password == "123456789")
                {
                    ShowMainForm("Bienvenido al sistema Inventory Hall, Administrador " + username);
                }




            }
            // Comprobar si el botón de Usuario está activo
            else if (activeButton == btnInvitado)
            {

                if (username != "rzorrilla" && password != "123456")
                {
                    MessageBox.Show("El usuario y contraseña del invitado son incorrectas");
                }
                else if (username == "rzorrilla" && password == "123456")
                {
                    ShowMainForm("Bienvenido al sistema Inventory Hall, Usuario " + username);
                }
                else if (username != "rzorrilla")
                {
                    MessageBox.Show("El nombre del Usuario invitado es incorrecto");
                }
                else if (mtxtpassword.Text != username)
                {
                    MessageBox.Show("La contraseña del Usuario invitado es incorrecta");
                }


            }
            else
            {
                MessageBox.Show("Por favor, seleccione el tipo de usuario (Administrador o Invitado) antes de intentar iniciar sesión.");
            }

        }


        private void ShowMainForm(string welcomeMessage)
        {
            Principal0 principal0 = new Principal0();
            principal0.Show();
            MessageBox.Show(welcomeMessage);
            this.Hide();
        }
        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckEnterKeyPress(object sender, KeyEventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void CheckEnterKeyPress1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
                e.SuppressKeyPress = true; // Previene el sonido de ding en Windows
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);



        }

        private void btnInvitado_Click(object sender, EventArgs e)

        {
            SetActiveButton((Button)sender);

        }
    }
}
