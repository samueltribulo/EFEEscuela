using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GridRefresh()
        {
            List<Alumno> Alumnos = AbmAlumno.Select();

            gridAlumnos.DataSource = Alumnos;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GridRefresh();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor() { Apellido = "Carlos", Nombre = "Juan", Titulo = "Licenciado" };

            AbmProfesor.Insert(profesor);

            Alumno alumno = new Alumno()
            {
                Nombre = textBoxName.Text,
                Apellido = textBoxLastName.Text,
                FechaNacimiento = dateTimePicker.Value,
                Profesor_Id = profesor.ProfesorId
            };

            AbmAlumno.Insert(alumno);

            GridRefresh();

            MessageBox.Show("todo ok");

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
