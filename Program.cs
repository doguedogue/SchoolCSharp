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
            List<Curso> arregloCursos = new List<Curso>{
                new Curso() {Nombre = "Instrucción Militar", TipoJornada = TipoJornada.Matutino},
                new Curso() {Nombre = "Español", TipoJornada = TipoJornada.Matutino},
                new Curso{Nombre = "Historia", TipoJornada = TipoJornada.Matutino}
            };

            miescuela.Cursos = arregloCursos;
            miescuela.Cursos.Add(new Curso() { Nombre = "Matematicas", TipoJornada = TipoJornada.Vespertino });

            WriteLine(miescuela);
            WriteLine("=====================");

            Curso tmp = new Curso() { Nombre = "XXX", TipoJornada = TipoJornada.Vespertino };
            WriteLine("Hash = " + tmp.GetHashCode());
            miescuela.Cursos.Add(tmp);
            imprimirArreglo(miescuela);
            WriteLine("=====================");

            int v = miescuela.Cursos.RemoveAll(cur => cur.Nombre == "XXX");

            imprimirArreglo(miescuela);
        }

        private static bool Predicado(Curso curso) {
            return curso.Nombre == "XXX";
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