using System;
using CoreEscuela.Entidades;

namespace Etapa1 {
    class Program {
        static void Main(string[] args) {
            var miescuela = new Escuela("iavhc", 1995,
                            TiposEscuela.Secundaria,
                            ciudad: "GT CT", pais: "GT");

            var curso1 = new Curso() {
                Nombre = "Instrucción Militar"
            };

            var curso2 = new Curso() {
                Nombre = "Español"
            };
            var curso3 = new Curso() {
                Nombre = "Historia"
            };

            Console.WriteLine(miescuela);
            System.Console.WriteLine("=====================");
            Console.WriteLine(curso1);
        }
    }
}