namespace ChayaShakir.Dominio
{
    public abstract class Instrumento
    {
        public string Marca { get; set; }
        public int Cuerdas { get; set; }
        public int Año { get; set; }

        protected Instrumento(string marca, int cuerdas, int año)
        {
            Marca = marca;
            Cuerdas = cuerdas;
            Año = año;
        }

        public override string ToString()
        {
            return $"Marca: {Marca} - Cuerdas: {Cuerdas} - Año: {Año}";
        }
    }

}
