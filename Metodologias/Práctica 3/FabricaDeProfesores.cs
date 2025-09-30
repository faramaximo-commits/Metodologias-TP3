using Metodologias.Objetos;
using Metodologias.Otros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Práctica_3
{
    internal class FabricaDeProfesores : FabricaDeComparables //Ejercicio 9 (Práctica 3) Implemente una fabrica concreta para la clase Profesor
    {
        public override MiComparable crearAleatorio()
        {
            string nombre = GeneradorDeDatos.ObtenerNombreAleatorio();
            int dni = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100000000);
            int antiguedad = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100);
            MiComparable c = new Profesor(nombre, dni, antiguedad);
            return c;
        }

        public override MiComparable crearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            string nombre = lector.stringPorTeclado();
            int dni = lector.numeroPorTeclado();
            int antiguedad = lector.numeroPorTeclado();
            MiComparable c = new Profesor(nombre, dni, antiguedad);
            return c;
        }
    }
}
