using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Colecciones
{
    class ColeccionMultiple : IColeccionable
    {
        IColeccionable pila;
        IColeccionable cola;

        public ColeccionMultiple(IColeccionable p, IColeccionable c)
        {
            pila = c; cola = p;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public MiComparable minimo()
        {
            MiComparable minimoPila = cola.minimo();
            MiComparable minimoCola = cola.minimo();

            if (minimoPila.SosMenor(minimoCola))
            {
                return minimoPila;
            }
            else
            {
                return minimoCola;
            }
        }

        public MiComparable maximo()
        {
            MiComparable maximoPila = pila.maximo();
            MiComparable maximoCola = cola.maximo();

            if (maximoPila.SosMayor(maximoCola))
            {
                return maximoPila;
            }
            else
            {
                return maximoCola;
            }
        }

        public void agregar(MiComparable i)
        {
            //No hace nada
        }

        public bool contiene(MiComparable c)
        {
            return pila.contiene(c) || cola.contiene(c);

        }



    }
}
