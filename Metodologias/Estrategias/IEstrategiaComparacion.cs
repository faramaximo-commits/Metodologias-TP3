using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologias.Objetos;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Estrategias
{
    public interface IEstrategiaComparacion
    {
        bool sonIguales(MiComparable a, MiComparable b);

        bool esMasPequeño(MiComparable a, MiComparable b);

        bool esMasGrande(MiComparable a, MiComparable b);

    }
}
