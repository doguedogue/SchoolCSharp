using System;
using CoreEscuela.Entidades;

namespace Etapa1 {
    class Program {
        static void Main(string[] args) {
            var miescuela = new Escuela("iavhc", 1995,
                            TiposEscuela.Secundaria,
                            ciudad: "GT CT", pais: "GT");
            Console.WriteLine(miescuela);
        }
    }
}