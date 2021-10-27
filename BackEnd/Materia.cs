using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Materia
    {
        private int _id;
        private string _descripcion;
        private double _nota;
        public Materia(int id, string descripcion, double nota)
        {
            _id = id;
            _descripcion = descripcion;
            _nota = nota;
        }
        public Materia(int id, string descripcion)
        {
            _id = id;
            _descripcion = descripcion;
        }
        public int Id { get { return _id; } set { _id = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public double Nota { get { return _nota; } set { _nota = value; } }
    }
}
