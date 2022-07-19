using System;
using CoreEscuela.Entidades;

namespace CoreEscuela {
    public class EscuelaEngine {
        public Escuela Escuela { get; set; }

        public EscuelaEngine() {

        }

        public void inicializa() {

            Escuela = new Escuela("iavhc", 1995,
                           TiposEscuela.Secundaria,
                           ciudad: "GT CT", pais: "GT");

            //var arregloCursos = new Curso[3];
            Escuela.Cursos = new List<Curso>{
                new Curso() {Nombre = "Instrucción Militar", TipoJornada = TipoJornada.Matutino},
                new Curso() {Nombre = "Español", TipoJornada = TipoJornada.Matutino},
                new Curso{Nombre = "Historia", TipoJornada = TipoJornada.Matutino},
                new Curso() { Nombre = "Matematicas", TipoJornada = TipoJornada.Vespertino}
            };
        }
    }
}