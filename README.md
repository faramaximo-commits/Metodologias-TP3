# Organización del proyecto

Este proyecto corresponde a la **Práctica 3** de la materia *Metodología de la Programación 1*.  
El código está organizado en carpetas según su responsabilidad para mantener una estructura clara y modular.

## Estructura de carpetas

- **Colecciones/**
  - Contiene las implementaciones de las colecciones:  
    `Pila`, `Cola`, `Conjunto`, `ColeccionMultiple`.  
  - Todas implementan la interfaz `IColeccionable`.

- **Estrategias/**
  - Incluye las clases que definen las distintas formas de comparar objetos de tipo `Alumno`.  
  - Comparaciones disponibles: por `Dni`, `Nombre`, `Legajo` y `Promedio`.  
  - Se centralizan mediante la interfaz `IEstrategiaComparacion`.

- **Iteradores/**
  - Clases para recorrer colecciones de manera uniforme.  
  - Cada colección tiene su propio iterador (`IteradorPila`, `IteradorCola`, `IteradorConjunto`).  
  - Todas implementan la interfaz `IIterador`.

- **Objetos/**
  - Define las clases principales del sistema:  
    - `Numero`  
    - `Alumno`  
    - `Profesor`  
  - Todas heredan de `Persona` (cuando corresponde) e implementan `IComparable`.

- **Observer/**
  - Contiene la interfaz `IObservador`.  
  - Usada para implementar el **patrón Observer**, donde los alumnos observan al profesor.

- **Otros/**
  - `Funciones.cs`: métodos auxiliares como `llenar`, `informar`, `imprimirElementos`, etc.  
  - `GeneradorDeDatos.cs`: genera datos aleatorios para poblar objetos (nombres, enteros, estrategias, etc.).

- **Práctica 3/**
  - Incluye parte de la resolución de la práctica, principalmente lo relacionado con **fábricas** y **entrada por teclado**.  
  - ⚠️ **Nota**: no todos los ejercicios de la práctica están en esta carpeta; algunos se implementaron en otras secciones del proyecto.

- **Program.cs**
  - Punto de entrada principal del programa.  
  - Desde aquí se ejecutan y prueban los ejercicios de la práctica.

---

## Notas

- La organización busca separar las responsabilidades de cada módulo: colecciones, estrategias de comparación, objetos base, iteradores y el patrón Observer.  
- El código está diseñado para ser extensible: se pueden añadir nuevas fábricas, estrategias o colecciones sin modificar las existentes.
