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

        public override string ToString() {
            return $"Nombre: {Nombre}\nPais: {Pais}\nCiudad: {Ciudad}\nAño de Creación: {AñoCreación}\nTiposEscuela: {TiposEscuela}";
        }
    }
}