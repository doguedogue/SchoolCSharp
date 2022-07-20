using System;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela {
    class Program {
        static void Main(string[] args) {
            var escuelaEngine = new EscuelaEngine();
            escuelaEngine.inicializa();
            Printer.DibujaLinea();
            Printer.imprimeTitulo("BIENVENIDOS A LA ESCUELA");
            Printer.Beep(10000, cantidad: 3, time: 500);
            Printer.imprimeTitulo(escuelaEngine.Escuela.Nombre);
            imprimirArreglo(escuelaEngine.Escuela);
        }

        private static void imprimirArreglo(Escuela escuela) {
            Printer.imprimeTitulo("CURSOS");

            if (escuela?.Cursos != null) {
                foreach (var curso in escuela.Cursos) {
                    WriteLine(curso);
                    WriteLine("\t\tAlumn@: " + curso.Alumnos[0].Nombre);
                    WriteLine("\t\tEvaluación: " + curso.Alumnos[0].Evaluaciones[0].Nombre +
                            "\t\t| Calificación: " + curso.Alumnos[0].Evaluaciones[0].Calificacion.ToString("0.00"));
                }
            }
        }
    }
}