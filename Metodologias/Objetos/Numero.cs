using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias.Objetos
{
    public class Numero : IComparable
    {
        int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        public int getValor()
        {
            return valor;
        }

        public bool SosIgual(IComparable i)
        {
            Numero comparado = (Numero)i;
            return valor == comparado.getValor();
        }

        public bool SosMayor(IComparable i)
        {
            Numero comparado = (Numero)i;
            return valor > comparado.getValor();
        }

        public bool SosMenor(IComparable i)
        {
            Numero comparado = (Numero)i;
            return valor < comparado.getValor();
        }

        public override string ToString()
        {
            return valor.ToString();
        }
    }
}
