using System;
using BackEnd;
using System.Collections.Generic;
namespace FrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Materia> materiasAlumno1 = new List<Materia>();
            List<Materia> materiasAlumno2 = new List<Materia>();
            List<Materia> materiasProfe1 = new List<Materia>();
            List<Alumno> alumnos = new List<Alumno>();
            materiasAlumno1.Add(new Materia (1, "Matematica", 7));
            materiasAlumno1.Add(new Materia(2, "Lengua", 9));
            materiasAlumno2.Add(new Materia(1, "Programacion", 10));
            materiasAlumno2.Add(new Materia(2, "Fisica", 9));

            materiasProfe1.Add(new Materia(1, "Matematica"));
            materiasProfe1.Add(new Materia(2, "Lengua"));
            materiasProfe1.Add(new Materia(1, "Programacion"));
            materiasProfe1.Add(new Materia(2, "Fisica"));
            Alumno alumno1 = new Alumno(materiasAlumno1,1,"Alejandro","Programacion",2);
            Alumno alumno2 = new Alumno(materiasAlumno1,2, "Juan", "Programacion", 3);
            alumnos.Add(alumno1);
            alumnos.Add(alumno2);

            Profesor profe = new Profesor(alumnos, materiasProfe1,"Javier");
            Console.WriteLine("El alumno " + alumno1.Name + " tiene las siguientes materias:");
            foreach (var item in materiasAlumno1)
            {
                Console.WriteLine(item.Descripcion);
            }
            Console.WriteLine("El alumno " + alumno2.Name + " tiene las siguientes materias:");
            foreach (var item in materiasAlumno2)
            {
                Console.WriteLine(item.Descripcion);
            }
            Console.WriteLine("El profesor " + profe.Name + " tiene las siguientes materias:");
            foreach (var item in materiasProfe1)
            {
                Console.WriteLine(item.Descripcion);
            }
            Console.WriteLine("Y también tiene los siguientes alumnos: ");
            foreach (var item in alumnos)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
