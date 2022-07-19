namespace CoreEscuela.Entidades {
    class Escuela {
        string nombre;
        public string Nombre {
            get { return "Institución: " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoCreación { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TiposEscuela { get; set; }

        public Escuela(string nombre, int año) => (Nombre, AñoCreación) = (nombre, año);

        public Escuela(string nombre, int año,
                TiposEscuela tipo,
                string pais = "", string ciudad = "") {
            (Nombre, AñoCreación) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
            TiposEscuela = tipo;
        }

        public override string ToString() {
            return $"Nombre: \"{Nombre}\"{System.Environment.NewLine}Pais: {Pais}\nCiudad: {Ciudad}\nAño de Creación: {AñoCreación}\nTiposEscuela: {TiposEscuela}";
        }
    }
}