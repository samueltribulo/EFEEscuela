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

        public static List<Alumno> Select(int id)
        {
            return context.Alumnos.Where(Al => Al.IdAlumno == id).ToList();
        }

        public static string Insert(Alumno alumno)
        {

            context.Alumnos.Add(alumno);

            context.SaveChanges();

            return "Alumno insertado";

        }

        public static string Update(int id, string Nombre, string Apellido, int Profesor_Id, DateTime FechaNacimiento)
        {

            Alumno alumnoOrigen = context.Alumnos.Find(id);


            try
            {
                alumnoOrigen.Nombre = Nombre;
                alumnoOrigen.Apellido = Apellido;
                alumnoOrigen.Profesor_Id = Profesor_Id;
                alumnoOrigen.FechaNacimiento = FechaNacimiento;

                context.SaveChanges();
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

                context.Alumnos.Remove(context.Alumnos.Single(a => a.IdAlumno == id));

                context.SaveChanges();

                return "Delete ok";
            }
            catch (Exception ex)
            {

                return $"{ex.Message}";
            }

        }

    }
}
