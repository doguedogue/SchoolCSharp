using System;
using CoreEscuela.Entidades;

namespace Etapa1 {
    class Program {
        static void Main(string[] args) {
            var miescuela = new Escuela("IAVHC", 1995);
            miescuela.Pais = "GT";
            miescuela.Ciudad = "GT";
            Console.WriteLine(miescuela.Nombre);
        }
    }
}