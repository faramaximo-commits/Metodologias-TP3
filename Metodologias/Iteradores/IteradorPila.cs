using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Iteradores
{
    internal class IteradorPila : IIterador
    {
        private List<MiComparable> elementos;
        private int puntero;

        public IteradorPila(List<MiComparable> elementos)
        {
            this.elementos = elementos;
            primero();
        }
        public MiComparable actual()
        {
            return elementos[puntero];
        }

        public bool fin()
        {
            return puntero >= elementos.Count;
        }

        public void primero()
        {
            puntero = 0;
        }

        public void siguiente()
        {
            puntero++;
        }
    }
}
