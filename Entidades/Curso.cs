using System;

namespace CoreEscuela.Entidades {
    public class Curso {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public TipoJornada TipoJornada { get; set; }

        public Curso() => UniqueID = Guid.NewGuid().ToString();

        public override string ToString() {
            return $"UID: {UniqueID} | Turno: {TipoJornada} \t| Nombre: \"{Nombre}\"";
        }
    }
}