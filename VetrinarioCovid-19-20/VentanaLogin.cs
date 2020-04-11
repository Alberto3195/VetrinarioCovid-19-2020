using System;
using System.Windows.Forms;

namespace VetrinarioCovid_19_20
{
    public partial class VentanaLogin : Form
    {
        /// <summary>
        /// Conexión con la base de datos ElSauce
        /// </summary>
        Conexion miConexion = new Conexion();
        Registro miRegistro = new Registro();
        Consultas miConsulta = new Consultas();

        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (miConexion.loginVeterinario(user.Text, pass.Text))
            {
                this.Hide();
                VentanaPrincipal v = new VentanaPrincipal();
                v.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrrectos");
            }
        }

        private void registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            miRegistro.Show();
        }
    }
}
