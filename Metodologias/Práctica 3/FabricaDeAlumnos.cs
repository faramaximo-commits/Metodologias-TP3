using Metodologias.Estrategias;
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
    internal class FabricaDeAlumnos : FabricaDeComparables //Ejercicio 5 (Práctica 3) Implemente las fábricas concretas FabricaDeNumeros y FabricaDeAlumnos
    {
        public override MiComparable crearAleatorio()
        {
            string n = GeneradorDeDatos.ObtenerNombreAleatorio();
            int d = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100000000);
            int l = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 10000);
            int p = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10);
            IEstrategiaComparacion e = GeneradorDeDatos.obtenerEstrategiaAleatoria();
            MiComparable c = new Alumno(n, d, l, p, e);
            return c;
        }

        public override MiComparable crearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            string n = lector.stringPorTeclado();
            int d = lector.numeroPorTeclado();
            int l = lector.numeroPorTeclado();
            int p = lector.numeroPorTeclado();
            IEstrategiaComparacion e = lector.estrategiaPorTeclado();
            MiComparable c = new Alumno(n, d, l, p, e);
            return c;
        }
    }
}
