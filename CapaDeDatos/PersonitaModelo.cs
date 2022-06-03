using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    class PersonitaModelo : Modelo
    {
        public int Id;
        public string Nombre;
        public string Apellido;
        public int Telefono;
        public string Email;

        public void Guardar()
        {
            if (this.Id.ToString() == "") GuardarSinId();
            else GuardarConId();
        }

        private void GuardarConId()
        {
            comando.CommandText = "INSERT INTO personita VALUES (@id, @nombre,@apellido,@email,@telefono)";
            comando.Parameters.AddWithValue("@id", this.Id.ToString());
            comando.Parameters.AddWithValue("@nombre", this.Nombre);
            comando.Parameters.AddWithValue("@apellido", this.Apellido);
            comando.Parameters.AddWithValue("@telefono", this.Telefono.ToString());
            comando.Parameters.AddWithValue("@email", this.Email);
            comando.Prepare();
            comando.ExecuteNonQuery();
        }

        private void GuardarSinId()
        {
            comando.CommandText = "INSERT INTO " +
                            "personita (nombre, apellido, telefono, email) " +
                            "VALUES (@nombre,@apellido,@telefono,@email)";

            comando.Parameters.AddWithValue("@nombre", this.Nombre);
            comando.Parameters.AddWithValue("@apellido", this.Apellido);
            comando.Parameters.AddWithValue("@telefono", this.Telefono.ToString());
            comando.Parameters.AddWithValue("@email", this.Email);
            comando.Prepare();
            comando.ExecuteNonQuery();
        }
    }
}
