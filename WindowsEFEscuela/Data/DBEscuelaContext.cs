﻿using System.Data.Entity;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Data
{
    public class DBEscuelaContext : DbContext
    {

        public DBEscuelaContext() : base("KeyDB")
        {

        }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Aula> Aulas { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Profesor> Profesores { get; set; }




    }
}
