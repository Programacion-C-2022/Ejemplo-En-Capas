using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            PersonitaControlador.Alta(
                Int32.Parse(TextBoxId.Text),
                TextBoxNombre.Text,
                TextBoxApellido.Text,
                Int32.Parse(TextBoxTelefono.Text),
                TextBoxEmail.Text
           );

            MessageBox.Show("Personita Creada");
        }

        private void BotonListar_Click(object sender, EventArgs e)
        {
            DataGridPersonas.DataSource = PersonitaControlador.ObtenerTodos();

        }
    }
}
