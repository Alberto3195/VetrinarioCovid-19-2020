using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetrinarioCovid_19_20
{
    
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion = new Conexion();
        RegistroMascota RegistroMascota = new RegistroMascota();
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistroMascota.Show();
            this.Hide();
        }

        private void VentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
