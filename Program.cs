using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela {
    class Program {
        static void Main(string[] args) {
            var escuelaEngine = new EscuelaEngine();
            escuelaEngine.inicializa();

            imprimirArreglo(escuelaEngine.Escuela);
        }

        private static void imprimirArreglo(Escuela escuela) {
            WriteLine("=====================");
            WriteLine("=======CURSOS========");
            WriteLine("=====================");
            if (escuela?.Cursos != null) {
                foreach (var curso in escuela.Cursos) {
                    WriteLine(curso);
                }
            }
        }
    }
}