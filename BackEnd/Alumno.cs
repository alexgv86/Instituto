using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Alumno : Persona<Materia>
    {
        private List<Materia> _materias;
        private int _id;
        private string _fullName;
        private string _carrera;
        private int _año;
        private double _promedio;

        public Alumno(List<Materia> materias,int id, string name, string carrera, int año)
        {
            _id = id;
            _materias = materias;
            _fullName = name;
            _carrera = carrera;
            _año = año;
        }
        public List<Materia> Materias { get { return _materias; } set { _materias = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _fullName; } set { _fullName = value; } }
        public string Carrera { get { return _carrera; } set { _carrera = value; } }
        public int Año { get { return _año; } set { _año = value; } }
        public double Promedio { get { return _promedio; } set { _promedio = value; } }
    }
}
