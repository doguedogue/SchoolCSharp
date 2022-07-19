using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1 {
    class Program {
        static void Main(string[] args) {
            var miescuela = new Escuela("iavhc", 1995,
                            TiposEscuela.Secundaria,
                            ciudad: "GT CT", pais: "GT");

            //var arregloCursos = new Curso[3];
            Curso[] arregloCursos = {
                new Curso() {Nombre = "Instrucción Militar"},
                new Curso() {Nombre = "Español"},
                new Curso{Nombre = "Historia"}
            };

            miescuela.Cursos = arregloCursos;

            WriteLine(miescuela);
            WriteLine("=====================");
            imprimirArreglo(miescuela);
        }

        private static void imprimirArreglo(Escuela escuela) {
            if (escuela?.Cursos != null) {
                foreach (var curso in escuela.Cursos) {
                    WriteLine(curso);
                }
            }
        }
    }
}