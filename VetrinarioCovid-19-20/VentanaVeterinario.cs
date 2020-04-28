using System;
using System.Windows.Forms;

namespace VetrinarioCovid_19_20
{
    public partial class VentanaVeterinario : Form
    {
        //Declaramos la clase donde se realiza la consulta
        Conexion conexion = new Conexion();
        //Indicamos la ventana donde se van a localizar los datos
        VentanaVeterinario V = new VentanaVeterinario();

        public VentanaVeterinario()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(BuscaId.Text);
                BuscaId.Text = "";//Dejamos el buscador de ID vacío
            }
            catch (Exception ex)
            {//Si el id no es valido salta un aviso
                MessageBox.Show("ID no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BuscaId.Text = "";
            }
        }
    }
}
