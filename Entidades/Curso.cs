using System;

namespace CoreEscuela.Entidades {
    public class Curso {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public TipoJornada TipoJornada { get; set; }

        public List<Alumno> Alumnos { get; set; }
        public List<Asignatura> Asignaturas { get; set; }


        public Curso() => UniqueID = Guid.NewGuid().ToString();

        public override string ToString() {
            return $"UID: {UniqueID} | Turno: {TipoJornada} \t| Nombre: \"{Nombre}\"";
        }
    }
}