using System;
using System.Windows.Forms;

namespace VetrinarioCovid_19_20
{
    public partial class LoginVeterinario : Form
    {
        Conexion conexion = new Conexion();
        public LoginVeterinario()
        {
            InitializeComponent();
        }

        //Boton para acceder como Veterinario
        private void login_Click(object sender, EventArgs e)
        {
            if (conexion.loginVeterinarios(user.Text, pass.Text))
            {
                this.Hide();
                VentanaVeterinario Y = new VentanaVeterinario();
                Y.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrrectos");
            }
        }
    }
}
