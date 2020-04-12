using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using BCrypt.Net;

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
            String textoPassword = Contraseña.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());

            MessageBox.Show(conexion.insertaUsuario(Nombre.Text, Apellidos.Text, DNI.Text,
                                    Correo.Text, Dirección.Text, Teléfono.Text,
                                    Usuario.Text, myHash));
            //VentanaLogin login = new VentanaLogin();
            this.Close();
            //MessageBox.Show("Ha sigo registrado correctamente");
            //login.Show();
        }
    }
}
