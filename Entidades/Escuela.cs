namespace CoreEscuela.Entidades {
    public class Escuela {
        public string UniqueID { get; private set; } = Guid.NewGuid().ToString();
        string nombre;
        public string Nombre {
            get { return "Institución: " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoCreación { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }
        public Escuela(string nombre, int año) => (Nombre, AñoCreación) = (nombre, año);
        public Escuela(string nombre, int año,
                TiposEscuela tipos,
                string pais = "", string ciudad = "") {
            (Nombre, AñoCreación) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
            TipoEscuela = tipos;
        }

        public override string ToString() {
            return $"Nombre: \"{Nombre}\"{System.Environment.NewLine}Pais: {Pais}, Ciudad: {Ciudad}\nAño de Creación: {AñoCreación}\nTiposEscuela: {TipoEscuela}";
        }
    }
}