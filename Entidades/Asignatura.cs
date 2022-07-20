using System;

namespace CoreEscuela.Entidades {
    public class Asignatura {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }

        public Asignatura() => UniqueID = Guid.NewGuid().ToString();

        public override string ToString() {
            return $"UID: {UniqueID} |  Nombre: \"{Nombre}\"";
        }
    }
}