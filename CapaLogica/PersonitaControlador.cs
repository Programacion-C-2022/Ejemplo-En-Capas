using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaLogica
{
    public class PersonitaControlador
    {
        public static bool Alta(int id, string nombre, string apellido, int telefono, string email)
        {
            PersonitaModelo p = new PersonitaModelo();

            p.Id = id;
            p.Nombre = nombre;
            p.Apellido = apellido;
            p.Telefono = telefono;
            p.Email = email;

            p.Guardar();


            return true;
        }
    }
}
