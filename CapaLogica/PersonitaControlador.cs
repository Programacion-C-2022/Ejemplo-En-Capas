using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaLogica
{
    public class PersonitaControlador
    {
        public static void Alta(int id, string nombre, string apellido, int telefono, string email)
        {
            PersonitaModelo p = new PersonitaModelo();

            p.Id = id;
            p.Nombre = nombre;
            p.Apellido = apellido;
            p.Telefono = telefono;
            p.Email = email;
            p.Guardar();
        }

        public static void Modificar(int id, string nombre, string apellido, int telefono, string email)
        {
            PersonitaModelo p = new PersonitaModelo(id);
            p.Nombre = nombre;
            p.Apellido = apellido;
            p.Telefono = telefono;
            p.Email = email;
            p.Guardar();
        }

        public static void Eliminar(int id)
        {
            PersonitaModelo p = new PersonitaModelo(id);
            p.Eliminar();
        }

        public static void EliminarCanarios()
        {
            PersonitaModelo p = new PersonitaModelo();
            List<PersonitaModelo> personitas = p.Obtener();

            foreach(PersonitaModelo persona in personitas)
            {
                if (persona.Telefono.ToString().Contains("43"))
                    persona.Eliminar();
            }
        }

        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            PersonitaModelo p = new PersonitaModelo();
            List<PersonitaModelo> personitas = p.Obtener();

            return tabla;
        }
    }
}
