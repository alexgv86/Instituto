using System;
using System.Collections.Generic;

namespace BackEnd
{
    public abstract class Persona<T> : IPersona<T>
    {
        public void AgregarLista(List<T> datos)
        {
            throw new NotImplementedException();
        }

        public void OrdenarLista(List<T> datos)
        {
            throw new NotImplementedException();
        }
    }
}
