using System;

namespace CoreEscuela.Entidades {
    public class Alumno {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }

        public Alumno() => UniqueID = Guid.NewGuid().ToString();

        public override string ToString() {
            return $"UID: {UniqueID} |  Nombre: \"{Nombre}\"";
        }
    }
}