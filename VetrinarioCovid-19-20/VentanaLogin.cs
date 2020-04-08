using System;
using System.Windows.Forms;

namespace VetrinarioCovid_19_20
{
    public partial class VentanaLogin : Form
    {
        /// <summary>
        /// Conexión con la base de datos ElSauce
        /// </summary>
        Conexion conexion = new Conexion();

        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {

        }
    }
}
