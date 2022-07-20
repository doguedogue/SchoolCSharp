using System;

namespace CoreEscuela.Entidades {
    public class Evaluacion {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }

        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Calificacion { get; set; }

        public Evaluacion() => UniqueID = Guid.NewGuid().ToString();

        public override string ToString() {
            return $"UID: {UniqueID} |  Nombre: \"{Nombre}\"";
        }
    }
}