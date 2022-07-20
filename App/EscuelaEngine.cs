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
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GeneraAlumnosRandom(int cantidad) {
            string[] nombre1 = { "Judith", "Felipe", "Minerva", "Calvin", "Rafael", "Miriam", "Elsa" ,
                                "David", "Victoria", "Guadalupe", "Dominic", "Lucely", "Julio", "Leonardo" };
            string[] apellido1 = { "Cruz", "Treviño", "Garza", "Sanchez", "Torres", "Robles", "Gomez" };
            string[] apellido2 = { "Pérez", "López", "Martínez", "Hernández", "Suarez", "Guzman", "Herrera" };

            var listaAlumnos = from n1 in nombre1
                               from a1 in apellido1
                               from a2 in apellido2
                               select new Alumno { Nombre = $"{n1} {a1} {a2}" };

            return listaAlumnos.OrderBy((al) => al.UniqueID).Take(cantidad).ToList();

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

            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos) {
                int cantidad = rnd.Next(5, 20);
                var listaAlumnos = GeneraAlumnosRandom(cantidad);
                curso.Alumnos = listaAlumnos;
            }
        }
    }
}