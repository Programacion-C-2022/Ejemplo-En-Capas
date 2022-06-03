using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CapaDeDatos
{
    public abstract class Modelo
    {
        public string IpBaseDeDatos;
        public string UsuarioBaseDeDatos;
        public string PasswordBaseDeDatos;
        public string NombreBaseDeDatos;
        public string PuertoBaseDeDatos;
        public MySqlConnection conexion;
        public MySqlCommand comando;
        public MySqlDataReader dataReader;


        public Modelo()
        {

            this.conexion = new MySqlConnection();
            this.conexion.ConnectionString =
                       "server=" + this.IpBaseDeDatos + ";" +
                       "uid=" + this.UsuarioBaseDeDatos + ";" +
                       "pwd=" + this.PasswordBaseDeDatos + ";" +
                       "database=" + this.NombreBaseDeDatos + ";" +
                       "port=" + this.PuertoBaseDeDatos;
                     


            this.conexion.Open();

            this.comando.Connection = this.conexion;


        }

        private void inicializarConexion()
        {
            this.IpBaseDeDatos = "127.0.0.1";
            this.NombreBaseDeDatos = "pruebita";
            this.UsuarioBaseDeDatos = "root";
            this.PasswordBaseDeDatos = "root";
        }
    }
}
