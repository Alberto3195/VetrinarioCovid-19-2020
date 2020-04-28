using System;
using System.Windows.Forms;

namespace VetrinarioCovid_19_20
{
    public partial class RegistroMascota : Form
    {
        Conexion conexion = new Conexion();
        public RegistroMascota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VentanaLogin v = new VentanaLogin();
            MessageBox.Show(conexion.RegistaMascota(ID.Text, nom.Text, tip.Text, raz.Text));
            this.Close();
            //v.Show();
        }

        private void RegistroMascota_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
