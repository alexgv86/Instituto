using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BackEnd
{
    public class Profesor : Persona<Alumno>
    {
        private List<Alumno> _alumnos;
        private List<Materia> _materias;
        private string _name;
        public Profesor(List<Alumno> alumnos,List<Materia> materias,string name)
        {
            _alumnos = alumnos;
            _materias = materias;
            _name = name;
        }
        public List<Alumno> Alumnos { get { return _alumnos; } set { _alumnos = value; } }
        public List<Materia> Materias { get { return _materias; } set { _materias = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public new void OrdenarLista(List<Alumno> datos)
        {
            var query = from dato in datos orderby dato.Id ascending select dato;
            foreach (var item in query)
            {
                Console.WriteLine(item.Id);
            }
        }
      }
}
