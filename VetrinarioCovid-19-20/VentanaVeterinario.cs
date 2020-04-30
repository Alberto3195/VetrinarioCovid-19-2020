using System;
using System.Windows.Forms;
using System.Data;

namespace VetrinarioCovid_19_20
{
    public partial class VentanaVeterinario : Form
    {
        //Declaramos la clase donde se realiza la consulta
        Conexion conexion = new Conexion();

        //Indicamos la ventana donde se van a localizar los datos
        //VentanaVeterinario V = new VentanaVeterinario();

        //Crear una variable que guarde los datos
        public DataTable datosMascotas = new DataTable();

        public VentanaVeterinario()
        {
            InitializeComponent();
        }

        
        private void Buscar_Click(object sender, EventArgs e)
        {
            id.Text = "";
            nom.Text = "";
            tip.Text = "";
            raz.Text = "";
            sex.Text = "";
            propietario.Text = "";
            veterinario.Text = "";

            try
            {
                datosMascotas = conexion.buscaMascota(BuscaId.Text);

                //Seleccionamos los datos y los labels donde aparecerán dentro de nuestra app
                id.Text = "ID: " + (id.Text = datosMascotas.Rows[0]["ID"].ToString());
                nom.Text = "Nombre: " + (nom.Text = datosMascotas.Rows[0]["Nombre"].ToString());
                tip.Text = "Tipo: " + (tip.Text = datosMascotas.Rows[0]["Tipo"].ToString());
                raz.Text = "Raza: " + (raz.Text = datosMascotas.Rows[0]["Raza"].ToString());
                sex.Text = "Sexo: " + (sex.Text = datosMascotas.Rows[0]["Sexo"].ToString());
                propietario.Text = "Propietario: " + (propietario.Text = datosMascotas.Rows[0]["Propietario"].ToString());
                veterinario.Text = "Veterinario: " + (veterinario.Text = datosMascotas.Rows[0]["Veterinario"].ToString());

                BuscaId.Text = "";//Dejamos el buscador de ID vacío
            }
            catch (Exception ex)
            //Si el id no es valido salta un aviso
            {
                MessageBox.Show("ID no encontrado");
                BuscaId.Text = "";
            }
        }
        

        private void VentanaVeterinario_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}