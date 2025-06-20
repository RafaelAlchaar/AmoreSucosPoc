namespace AmoreSucos.Entities
{
    public class Suco
    {
        public string Nome { get; set; }
        public double Litros { get; set; }

        public Suco(string nome, double litros)
        {
            Nome = nome;
            Litros = litros;
        }
    }
}
