using MySql.Data.MySqlClient;

namespace VetrinarioCovid_19_20 
{ 

    class Conexion
    {
        /// <summary>
        /// Variable de tipo MySqlConnection, que nos permitira gestionar la conexion a la BBDD
        /// </summary>
        public MySqlConnection conexion;

        /// <summary>
        /// String que define la cadena de conexion a nuestra base de datos
        /// Debemos especificar Server; Database; Uid; Pwd; Port;
        /// </summary>
        string conexionSQL = "Server = 127.0.0.1; Database = veterinarios el sauce; Uid = root; Pwd = ; Port = 3306";

        /// <summary>
        /// Constructor de la clase, cuando instancio un objeto de tipo conexion, por defecto se ejecuta este metodo
        /// Metodo Conexion, devuelve la variable conexion con los parametros establecidos
        /// </summary>
        public Conexion() //Para conectarse a la bbdd que tenengo en la maquina virtual
        {
            conexion = new MySqlConnection(conexionSQL);
        }

    }
}
