using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela
{
    public partial class Form1 : Form
    {

        private void GridRefresh()
        {

            dataGridView.DataSource = AbmAlumno.Select();

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GridRefresh();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Profesor Profesor = new Profesor() { Nombre = "Manolo", Apellido = "Rodriguez", Titulo = "Licenciado" };

            AbmProfesor.Insert(Profesor);

            Alumno Alumno = new Alumno() { Nombre = textBoxNombre.Text, Apellido = textBoxApellido.Text, FechaNacimiento = dateTimePickerNacimiento.Value, Profesor_Id = Profesor.ProfesorId  };

            AbmAlumno.Insert(Alumno);

            GridRefresh();
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {

            dataGridView.DataSource = AbmAlumno.Select(Convert.ToInt32(textBoxId.Text));

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            MessageBox.Show( AbmAlumno.Delete( Convert.ToInt32(textBoxId.Text) ) );
            textBoxId.Text = "";
            GridRefresh();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Profesor Profesor = new Profesor() { Nombre = "Eduardo", Apellido = "Rolando", Titulo = "Licenciado" };

            AbmProfesor.Insert(Profesor);

            MessageBox.Show( AbmAlumno.Update(Convert.ToInt32(textBoxId.Text), textBoxNombre.Text, textBoxApellido.Text, Profesor.ProfesorId, dateTimePickerNacimiento.Value));

            textBoxApellido.Text = "";
            textBoxNombre.Text = "";
            textBoxId.Text = "";

            GridRefresh();

        }
    }
}
