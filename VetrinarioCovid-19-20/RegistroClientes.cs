﻿using System;
using System.Windows.Forms;

namespace VetrinarioCovid_19_20
{
    public partial class RegistroClientes : Form
    {
        Conexion conexion = new Conexion();

        public RegistroClientes()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            VentanaLogin login = new VentanaLogin();

            String textoPassword = Pass.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());

            MessageBox.Show(conexion.insertaCliente(Nombre.Text, Apellidos.Text, DNI.Text,
                                    Correo.Text, Direccion.Text, Telefono.Text, myHash));
            this.Close();
            login.Show();
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
