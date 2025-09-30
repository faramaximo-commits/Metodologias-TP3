using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Colecciones
{
    interface IColeccionable
    {
        int cuantos();

        MiComparable minimo();

        MiComparable maximo();

        void agregar(MiComparable i);

        bool contiene(MiComparable i);
    }
}
