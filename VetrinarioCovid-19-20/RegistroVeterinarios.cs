using System;
using System.Windows.Forms;

namespace VetrinarioCovid_19_20
{
    public partial class RegistroVeterinarios : Form
    {
        Conexion conexion = new Conexion();

        public RegistroVeterinarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaLogin login = new VentanaLogin();
            //String textoPassword = Contraseña.Text;
            //string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());

            MessageBox.Show(conexion.insertaVeterinario(Nombre.Text, Apellidos.Text, DNI.Text,
                                    Correo.Text, Dirección.Text, Teléfono.Text,
                                    Usuario.Text, Contraseña.Text));
            this.Close();
            login.Show();
        }

        private void RegistroVeterinarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
