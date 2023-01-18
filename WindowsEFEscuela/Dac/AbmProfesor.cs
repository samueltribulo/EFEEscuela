using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public static class AbmProfesor
    {

        public static DBEscuelaContext context = new DBEscuelaContext();

        public static string Insert(Profesor Profesor)
        {

            context.Profesores.Add(Profesor);

            context.SaveChanges();

            return "Insert ok";

        }

    }
}
