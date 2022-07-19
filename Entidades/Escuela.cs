namespace CoreEscuela.Entidades {
    class Escuela {
        string nombre;
        public string Nombre {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoCreación { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        private int myVar;

        public Escuela(string nombre, int año) {
            this.nombre = nombre;
            this.AñoCreación = año;
        }
    }
}