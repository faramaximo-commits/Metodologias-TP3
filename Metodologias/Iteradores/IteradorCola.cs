using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Iteradores
{
    public class IteradorCola : IIterador 
    {
        private List<MiComparable> elementos;
        private int indice;

        public IteradorCola(List<MiComparable> elementos)
        {
            this.elementos = elementos;
            primero();
        }
        public MiComparable actual()
        {
            return elementos[indice];
        }

        public bool fin()
        {
            return indice >= elementos.Count;
        }

        public void primero()
        {
            indice = 0;
        }

        public void siguiente()
        {
            indice++;
        }
    }
}
