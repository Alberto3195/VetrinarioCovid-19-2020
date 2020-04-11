using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace VetrinarioCovid_19_20
{
    public partial class Registro : Form
    {
        Conexion conexion = new Conexion();

        public Registro()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaUsuario(Nombre.Text, Apellidos.Text, DNI.Text,
                                    Correo.Text, Dirección.Text, Teléfono.Text,
                                    Usuario.Text, Contraseña.Text));
            //VentanaLogin login = new VentanaLogin();
            this.Close();
            //MessageBox.Show("Ha sigo registrado correctamente");
            //login.Show();
        }
    }
}
