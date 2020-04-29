using MySql.Data.MySqlClient;
using System;
using System.Data;

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
        string conexionSQL = "Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd = ; Port = 3306";

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
        public Boolean loginClientes(string DNI, string Pass)
        {
            try
            {
                mysqlconnection.Open();
                ///<summary>
                ///Se parametrizan los datos para evitar que aquellos maleantes 
                ///puedan acceder a nuestros datos
                /// </summary>
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM clientes " +
                                     "where DNI = @DNI",
                                     mysqlconnection);

                consulta.Parameters.AddWithValue("@DNI", DNI);

                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string contraseña = resultado.GetString("Pass");
                    if (BCrypt.Net.BCrypt.Verify(Pass, contraseña))
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
        /// </summary>DNI
        public Boolean loginVeterinarios(string DNI, string Pass)
        {
            try
            {
                mysqlconnection.Open();
                ///<summary>
                ///Se parametrizan los datos para evitar que aquellos maleantes 
                ///puedan acceder a nuestros datos
                /// </summary>
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM veterinarios " +
                                     "where DNI = @DNI",
                                     mysqlconnection);

                consulta.Parameters.AddWithValue("@DNI", DNI);

                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string contraseña = resultado.GetString("Pass");
                    if (BCrypt.Net.BCrypt.Verify(Pass, contraseña))
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
        /// InsertaUsuario inserta un nuevo usuario del 
        /// veterinario en la base de datos 
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Apellidos"></param>
        /// <param name="DNI"></param>
        /// <param name="Correo"></param>
        /// <param name="Direccion"></param>
        /// <param name="Telefono"></param>
        /// <param name="Pass"></param>
        /// <returns></returns>
        public String insertaCliente (String Nombre, String Apellidos,
                                       String DNI, String Correo,
                                       String Direccion, String Telefono,
                                       String Pass)
        {
            try
            {
                mysqlconnection.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO clientes " +
                                     "(Nombre, Apellidos, DNI, Correo, " +
                                     "Direccion, Telefono, Pass) " +
                                     "VALUES (@Nombre, @Apellidos, @DNI, @Correo," +
                                     "@Direccion, @Telefono, @Pass)", mysqlconnection);

                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@Apellidos", Apellidos);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Correo", Correo);
                consulta.Parameters.AddWithValue("@Direccion", Direccion);
                consulta.Parameters.AddWithValue("@Telefono", Telefono);
                consulta.Parameters.AddWithValue("@Pass", Pass);

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
        /// InsertaVeterinario inserta un veterinario (trabajador) dentro de 
        /// la base de datos creada
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Apellidos"></param>
        /// <param name="DNI"></param>
        /// <param name="Correo"></param>
        /// <param name="Direccion"></param>
        /// <param name="Telefono"></param>
        /// <param name="Pass"></param>
        /// <returns></returns>

        public String insertaVeterinario(String Nombre, String Apellidos,
                                       String DNI, String Correo,
                                       String Direccion, String Telefono,
                                       String Pass)
        {
            try
            {
                mysqlconnection.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO veterinarios " +
                                     "(Nombre, Apellidos, DNI, Correo, " +
                                     "Direccion, Telefono, Pass) " +
                                     "VALUES (@Nombre, @Apellidos, @DNI, @Correo," +
                                     "@Direccion, @Telefono, @Pass)", mysqlconnection);

                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@Apellidos", Apellidos);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Correo", Correo);
                consulta.Parameters.AddWithValue("@Direccion", Direccion);
                consulta.Parameters.AddWithValue("@Telefono", Telefono);
                consulta.Parameters.AddWithValue("@Pass", Pass);

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

     public String RegistraMascota(String ID, String Nombre, String Tipo, String Raza, String Sexo, String Propietario, String Veterinario)
    {
        String resultado = "";
        try
        {
            mysqlconnection.Open();
            MySqlCommand consulta =
                new MySqlCommand("INSERT INTO animales (ID, Nombre, Tipo, Raza, Sexo, Propietario, Veterinario) " +
                                 "VALUES (@ID, @Nombre, @Tipo, @Raza, @Sexo, @Propietario, @Veterinario)", mysqlconnection);

            consulta.Parameters.AddWithValue("@ID", ID);
            consulta.Parameters.AddWithValue("@Nombre", Nombre);
            consulta.Parameters.AddWithValue("@Tipo", Tipo);
            consulta.Parameters.AddWithValue("@Raza", Raza);
            consulta.Parameters.AddWithValue("@Sexo", Sexo);
            consulta.Parameters.AddWithValue("@Propietario", Propietario);
            consulta.Parameters.AddWithValue("@Veterinario", Veterinario);
            
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

    
    public DataTable buscaMascota(String ID)
    {
        try
        {
            mysqlconnection.Open();
            MySqlCommand consulta = new MySqlCommand("SELECT * FROM animales " +
                                                     "WHERE ID ='" + ID + "'", mysqlconnection);

            MySqlDataReader resultado = consulta.ExecuteReader();
            DataTable mascota = new DataTable();

            mascota.Load(resultado);

            mysqlconnection.Close();

            return mascota;

        }
        catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
