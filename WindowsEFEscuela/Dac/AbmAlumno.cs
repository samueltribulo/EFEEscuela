using System;
using System.Collections.Generic;
using System.Linq;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public static class AbmAlumno
    {

        public static DBEscuelaContext context = new DBEscuelaContext();

        public static List<Alumno> Select()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno Select(int id)
        {
            return context.Alumnos.Find(id);
        }

        public static string Insert(Alumno alumno)
        {

            context.Alumnos.Add(alumno);

            context.SaveChanges();

            return "Alumno insertado";

        }

        public static string Update(Alumno alumno)
        {

            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);


            try
            {
                alumnoOrigen.Nombre = alumno.Nombre;
                alumnoOrigen.Apellido = alumno.Apellido;
                alumnoOrigen.Profesor = alumno.Profesor;
                alumnoOrigen.FechaNacimiento = alumno.FechaNacimiento;

                return "Update ok";
            }
            catch (Exception ex)
            {

                return $"{ex.Message}";
            }



        }

        public static string Delete(int id)
        {

            try
            {

                var resultado = context.Alumnos.Remove(context.Alumnos.Single(a => a.IdAlumno == id));

                return "Delete ok";
            }
            catch (Exception ex)
            {

                return $"{ex.Message}";
            }

        }

    }
}
