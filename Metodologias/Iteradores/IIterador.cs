using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = Metodologias.Objetos.IComparable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Metodologias.Iteradores
{
    public interface IIterador
    {
        void primero();
        void siguiente();
        bool fin();
        MiComparable actual();

    }
}
