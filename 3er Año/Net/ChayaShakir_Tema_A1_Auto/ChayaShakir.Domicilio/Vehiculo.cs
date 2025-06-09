namespace ChayaShakir.Dominio
{
    public abstract class Vehiculo
    {
        public string Patente { get; set; }
        public int Ruedas { get; set; }
        public int Modelo { get; set; }

        protected Vehiculo(string patente, int ruedas, int modelo)
        {
            Patente = patente;
            Ruedas = ruedas;
            Modelo = modelo;
        }

        public override string ToString()
        {
            return $"Patente: {Patente} Ruedas: {Ruedas} Modelo: {Modelo}";
        }
    }
}
