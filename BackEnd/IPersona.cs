using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    interface IPersona<T>
    {
        public void OrdenarLista(List<T> datos);
        public void AgregarLista(List<T> datos);
    }
}
