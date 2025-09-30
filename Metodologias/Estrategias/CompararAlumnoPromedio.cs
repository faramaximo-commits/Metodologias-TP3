using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologias.Objetos;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Estrategias
{
    internal class CompararAlumnoPromedio : IEstrategiaComparacion
    {
        public bool sonIguales(MiComparable a, MiComparable b)
        {
            return ((Alumno)a).getPromedio() == ((Alumno)b).getPromedio();
        }

        public bool esMasPequeño(MiComparable a, MiComparable b)
        {
            return ((Alumno)a).getPromedio() < ((Alumno)b).getPromedio();
        }

        public bool esMasGrande(MiComparable a, MiComparable b)
        {
            return ((Alumno)a).getPromedio() > ((Alumno)b).getPromedio();
        }

        public override string ToString()
        {
            return "Comparacion por PROMEDIO ";
        }
    }
}
