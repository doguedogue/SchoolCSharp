using System;
using System.Linq;
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
            CargaCursos();
            CargaAsignaturas();

            CargaAlumnos();
            CargaEvaluaciones();
        }

        private void CargaEvaluaciones() {

        }

        private void CargaAsignaturas() {
            foreach (var curso in Escuela.Cursos) {
                List<Asignatura> listaAsignaturas = new List<Asignatura> {
                    new Asignatura{Nombre="Instrucción Militar"},
                    new Asignatura{Nombre="Español"},
                    new Asignatura{Nombre="Historia"},
                    new Asignatura{Nombre="Matemáticas"}
                };
            }
        }

        private void CargaAlumnos() {
            string[] nombre1 = { "Judith", "Felipe", "Minerva", "Calvin", "Rafael", "Miriam", "Elsa" };
            string[] nombre2 = { "David", "Victoria", "Guadalupe", "Dominic", "Lucely", "Julio", "Leonardo" };
            string[] apellido1 = { "Perez", "Lopez", "Martinez", "Hernandez", "Suarez", "Guzman", "Herrera" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre1
                               from a1 in nombre1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

        }

        private void CargaCursos() {
            //var arregloCursos = new Curso[3];
            Escuela.Cursos = new List<Curso>{
                new Curso() {Nombre = "101", TipoJornada = TipoJornada.Matutino},
                new Curso() {Nombre = "206", TipoJornada = TipoJornada.Matutino},
                new Curso{Nombre = "303", TipoJornada = TipoJornada.Matutino},
                new Curso() { Nombre = "404", TipoJornada = TipoJornada.Vespertino},
                new Curso() { Nombre = "501", TipoJornada = TipoJornada.Vespertino}
            };
        }
    }
}