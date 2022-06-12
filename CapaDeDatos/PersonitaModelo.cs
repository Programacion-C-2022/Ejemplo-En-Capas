using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class PersonitaModelo : Modelo
    {
        public int Id;
        public string Nombre;
        public string Apellido;
        public int Telefono;
        public string Email;

        public PersonitaModelo(int id)
        {
            this.Obtener(id);
        }

        public PersonitaModelo()
        {

        }

        public void Guardar()
        {
            if (this.Id.ToString() != "") Actualizar();
            else Insertar();
        }

        private void Insertar()
        {
            this.comando.CommandText = "INSERT INTO personita VALUES (@id, @nombre,@apellido,@email,@telefono)";
            this.comando.Parameters.AddWithValue("@id", this.Id.ToString());
            this.comando.Parameters.AddWithValue("@nombre", this.Nombre);
            this.comando.Parameters.AddWithValue("@apellido", this.Apellido);
            this.comando.Parameters.AddWithValue("@telefono", this.Telefono.ToString());
            this.comando.Parameters.AddWithValue("@email", this.Email);
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();
        }

        

        public void Obtener(int id)
        {
            obtenerFilaPorId(id);
            llenarCamposDesdeDataReader();

        }

        private void llenarCamposDesdeDataReader()
        {
            this.Id = Int32.Parse(this.dataReader["id"].ToString());
            this.Nombre = this.dataReader["nombre"].ToString();
            this.Apellido = this.dataReader["apellido"].ToString();
            this.Telefono = Int32.Parse(this.dataReader["telefono"].ToString());
            this.Email = this.dataReader["email"].ToString();
        }

        private void obtenerFilaPorId(int id)
        {
            this.comando.CommandText = "SELECT * FROM personita WHERE id = @id";
            this.comando.Parameters.AddWithValue("@id", id);
            this.comando.Prepare();
            this.dataReader = this.comando.ExecuteReader();
            this.dataReader.Read();
        }

        private void Actualizar()
        {
            this.comando.CommandText = "UPDATE personita SET " +
                "nombre = @nombre," +
                "apellido = @apellido," +
                "telefono = @telefono," +
                "email = @email" +
                "WHERE id = @id";

            this.comando.Parameters.AddWithValue("@nombre", this.Nombre);
            this.comando.Parameters.AddWithValue("@apellido", this.Apellido);
            this.comando.Parameters.AddWithValue("@telefono", this.Telefono.ToString());
            this.comando.Parameters.AddWithValue("@email", this.Email);
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();
        }

        public void Eliminar()
        {
            this.comando.CommandText = "DELETE FROM personita WHERE id = @id";
            this.comando.Parameters.AddWithValue("@id", this.Id);
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();
        }

        public List<PersonitaModelo> Obtener()
        {
            List<PersonitaModelo> personitas = obtenerTodasLasFilas();
            crearArrayDePersonas(personitas);
            return personitas;

        }

        private void crearArrayDePersonas(List<PersonitaModelo> personitas)
        {
            while (this.dataReader.Read())
            {
                PersonitaModelo p = new PersonitaModelo();
                p.Id = Int32.Parse(dataReader["id"].ToString());
                p.Nombre = dataReader["nombre"].ToString();
                p.Apellido = dataReader["apellido"].ToString();
                p.Telefono = Int32.Parse(dataReader["telefono"].ToString());
                p.Email = dataReader["email"].ToString();

                personitas.Add(p);
            }
        }

        private List<PersonitaModelo> obtenerTodasLasFilas()
        {
            List<PersonitaModelo> personitas = new List<PersonitaModelo>();
            this.comando.CommandText = "SELECT * FROM personita";
            this.dataReader = this.comando.ExecuteReader();
            return personitas;
        }
    }
}
