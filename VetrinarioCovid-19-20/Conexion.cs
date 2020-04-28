using MySql.Data.MySqlClient;
using System;

namespace VetrinarioCovid_19_20 
{
    class Conexion
    {
        /// <summary>
        /// Variable de tipo MySqlConnection, que nos permitira gestionar la conexion a la BBDD
        /// </summary>
        public MySqlConnection mysqlconnection;

        /// <summary>
        /// String que define la cadena de conexion a nuestra base de datos
        /// Debemos especificar Server; Database; Uid; Pwd; Port;
        /// </summary>
        string conexionSQL = "Server = 127.0.0.1; Database = veterinaria; Uid = root; Pwd = ; Port = 3306";

        /// <summary>
        /// Constructor de la clase, cuando instancio un objeto de tipo conexion, por defecto se ejecuta este metodo
        /// Metodo Conexion, devuelve la variable conexion con los parametros establecidos
        /// </summary>
        public Conexion() //Para conectarse a la bbdd
        {
            mysqlconnection = new MySqlConnection(conexionSQL);
        }

        /// <summary>
        /// Método que nos ingresa en la cuenta de cada cliente
        /// </summary>
        public Boolean loginClientes(string Usuario, string Contraseña)
        {
            try
            {
                mysqlconnection.Open();
                ///<summary>
                ///Se parametrizan los datos para evitar que aquellos maleantes 
                ///puedan acceder a nuestros datos
                /// </summary>
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM clientes " +
                                     "where Usuario = @Usuario",
                                     mysqlconnection);

                consulta.Parameters.AddWithValue("@Usuario", Usuario);

                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string contraseña = resultado.GetString("Contraseña");
                    if (BCrypt.Net.BCrypt.Verify(Contraseña, contraseña))
                    {
                        return true;
                    }
                    return false;
                }
                mysqlconnection.Close();
                return false;
            }
            
            catch (MySqlException exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }

    }
        /// <summary>
        /// Método que nos ingresará dentro de nuestro programa como Veterinarios
        /// </summary>
        public Boolean loginVeterinarios(string Usuario, string Contraseña)
        {
            try
            {
                mysqlconnection.Open();
                ///<summary>
                ///Se parametrizan los datos para evitar que aquellos maleantes 
                ///puedan acceder a nuestros datos
                /// </summary>
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM veterinarios " +
                                     "where Usuario = @Usuario",
                                     mysqlconnection);

                consulta.Parameters.AddWithValue("@Usuario", Usuario);

                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string contraseña = resultado.GetString("Contraseña");
                    if (BCrypt.Net.BCrypt.Verify(Contraseña, contraseña))
                    {
                        return true;
                    }
                    return false;
                }
                mysqlconnection.Close();
                return false;
            }

            catch (MySqlException exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }

        }

        public String insertaUsuario (String Nombre, String Apellidos,
                                       String DNI, String Correo,
                                       String Dirección, String Teléfono,
                                       String Usuario, String Contraseña)
        {
            try
            {
                mysqlconnection.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO clientes " +
                                     "(Nombre, Apellidos, DNI, Correo, " +
                                     "Dirección, Teléfono, Usuario, Contraseña) " +
                                     "VALUES (@Nombre, @Apellidos, @DNI, @Correo," +
                                     "@Dirección, @Teléfono, @Usuario, @Contraseña)", mysqlconnection);
                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@Apellidos", Apellidos);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Correo", Correo);
                consulta.Parameters.AddWithValue("@Dirección", Dirección);
                consulta.Parameters.AddWithValue("@Teléfono", Teléfono);
                consulta.Parameters.AddWithValue("@Usuario", Usuario);
                consulta.Parameters.AddWithValue("@Contraseña", Contraseña);

                consulta.ExecuteNonQuery();

                mysqlconnection.Close();
                return "Registro realizado con éxito";
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return "No se ha podido realizar el registro";
            }
        }

        public String insertaVeterinario(String Nombre, String Apellidos,
                                       String DNI, String Correo,
                                       String Dirección, String Teléfono,
                                       String Usuario, String Contraseña)
        {
            try
            {
                mysqlconnection.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO veterinarios " +
                                     "(Nombre, Apellidos, DNI, Correo, " +
                                     "Dirección, Teléfono, Usuario, Contraseña) " +
                                     "VALUES (@Nombre, @Apellidos, @DNI, @Correo," +
                                     "@Dirección, @Teléfono, @Usuario, @Contraseña)", mysqlconnection);
                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@Apellidos", Apellidos);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Correo", Correo);
                consulta.Parameters.AddWithValue("@Dirección", Dirección);
                consulta.Parameters.AddWithValue("@Teléfono", Teléfono);
                consulta.Parameters.AddWithValue("@Usuario", Usuario);
                consulta.Parameters.AddWithValue("@Contraseña", Contraseña);

                consulta.ExecuteNonQuery();

                mysqlconnection.Close();
                return "Registro realizado con éxito";
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return "No se ha podido realizar el registro";
            }
        }

        /// <summary>
        /// Metodo animal. Inserta un nuevo animal en la base de datos.
        /// Devolverá "Registro realizado correctamente" si todo sale bien
        /// Devolverá "No se ha podido realizar el registro" y la excepcion por consola si falla
        /// </summary>
        /// <param name="Nombre">Nombre del animal</param>
        /// <param name="Tipo">Tipo del animal (perro, gato, caballo...)</param>
        /// <param name="Raza">Raza del animal (chihuaha, persa, boxer...)</param>
        /// <param name="Fecha_Nac">Fecha de Naciemiento del animal</param>
        /// <returns>Devuelve un mensaje en funcion del resultado. Si inserta, OK, Si no, mensaje de fallo</returns>
        public String RegistaMascota(String ID, String Nombre, String Tipo, String Raza)
        {
            String resultado = "";
            try
            {
                mysqlconnection.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO animal VALUES (@ID, @Nombre, @Tipo, @Raza)", mysqlconnection);

                consulta.Parameters.AddWithValue("@ID", ID);
                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@Tipo", Tipo);
                consulta.Parameters.AddWithValue("@Raza", Raza);

                consulta.ExecuteNonQuery();

                mysqlconnection.Close();
                resultado = "Registro realizado con éxito";               
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                resultado = "No se ha podido realizar el registro";
            }
            return resultado;
        }
    }
}
