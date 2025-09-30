using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologias.Estrategias;
using Metodologias.Observer;

namespace Metodologias.Objetos
{
    public class Alumno : Persona, IObservador //Ejercicio 12 (Práctica 3) Implemente el patron Observer haciendo que el profesor sea el observable y los alumnos los observadores del profesor

    {
        private int legajo;
        private int promedio;
        private IEstrategiaComparacion estrategia;


        public Alumno(string n, int d, int l, int p, IEstrategiaComparacion e) : base(n, d)
        {
            legajo = l;
            promedio = p;
            estrategia = e;
        }

        public int getLegajo() { return legajo; }

        public int getPromedio() { return promedio; }

        public IEstrategiaComparacion getEstrategia() { return estrategia; }

        public void setEstrategia(IEstrategiaComparacion e)
        {
            estrategia = e;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, DNI: {dni}, Legajo: {legajo}, Promedio: {promedio} Estrategia empleada: {estrategia}";
        }


        
        public override bool SosIgual(IComparable i)
        {
            return estrategia.sonIguales(this, (Alumno)i);
        }

        public override bool SosMenor(IComparable i)
        {
            return estrategia.esMasPequeño(this, (Alumno)i);

        }

        public override bool SosMayor(IComparable i)
        {
            return estrategia.esMasGrande(this, (Alumno)i);
        }

        //Ejercicio 11 (Práctica 3) Agregue a la clase Alumno los metodos prestarAtencion() y distraerse()
        public void prestarAtencion()
        {
            Console.WriteLine("Prestando atención...");
        }

        public void distraerse()
        {
            Console.WriteLine("Tirando aviones de papel...");
        }

        public void Actualizar(string a)
        {
            if (a == "hablar")
                prestarAtencion();
            else if (a == "escribir")
                distraerse();
        }
    }
}
