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
        RegistroClientes miRegistro = new RegistroClientes();
        RegistroVeterinarios otroRegistro = new RegistroVeterinarios();

        public VentanaLogin()
        {
            InitializeComponent();
        }

        //Boton para iniciar como Usuario
        private void login_Click(object sender, EventArgs e)
        {
            if (miConexion.loginClientes(user.Text, pass.Text))
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

        //Boton para iniciar como veterinario
        private void login2_Click(object sender, EventArgs e)
        {
            if (miConexion.loginVeterinarios(user.Text, pass.Text))
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

        private void registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            miRegistro.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            otroRegistro.Show();
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
        System.Environment.Exit(1);
        }
    }
}
