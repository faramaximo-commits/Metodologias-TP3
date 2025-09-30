using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias.Observer
{
    public interface IObservador //Ejercicio 12 (Práctica 3) Implemente el patron Observer haciendo que el profesor sea el observable y los alumnos los observadores del profesor
    {
        void Actualizar(string accion);
    }
}
