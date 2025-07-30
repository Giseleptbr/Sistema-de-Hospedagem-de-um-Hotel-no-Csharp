namespace Models
{
    // Classe que representa uma suíte do hotel
    public class Suite
    {
        // Tipo da suíte (ex: Standard, Luxo, Premium)
        public string TipoSuite { get; set; }

        // Capacidade máxima de hóspedes que essa suíte comporta
        public int Capacidade { get; set; }

        // Valor da diária em reais
        public decimal ValorDiaria { get; set; }

        // Construtor para inicializar uma suíte com valores
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}
