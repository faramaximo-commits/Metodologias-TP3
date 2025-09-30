using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologias.Objetos;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Estrategias
{
    internal class CompararAlumnoNombre : IEstrategiaComparacion 
    {
        public bool sonIguales(MiComparable a, MiComparable b)
        {
            return ((Alumno)a).getNombre() == ((Alumno)b).getNombre();
        }

        public bool esMasPequeño(MiComparable a, MiComparable b)
        {
            return ((Alumno)a).getNombre().Length < ((Alumno)b).getNombre().Length;
        }

        public bool esMasGrande(MiComparable a, MiComparable b)
        {
            return ((Alumno)a).getNombre().Length > ((Alumno)b).getNombre().Length;
        }

        public override string ToString()
        {
            return "Comparacion por NOMBRE ";
        }
    }
}
