using Models;

class Program
{
    static void Main(string[] args)
    {
        // Cria uma lista de hóspedes
        List<Pessoa> hospedes = new List<Pessoa>
        {
            new Pessoa("João", "Silva"),
            new Pessoa("Maria", "Oliveira")
        };

        // Cria uma suíte do tipo Premium com capacidade para 2 pessoas e valor de R$150/dia
        Suite suite = new Suite("Premium", 2, 150.00m);

        // Cria uma nova reserva
        Reserva reserva = new Reserva();

        // Associa a suíte à reserva
        reserva.CadastrarSuite(suite);

        // Define que a reserva será por 12 dias
        reserva.DiasReservados = 12;

        // Associa os hóspedes à reserva
        reserva.CadastrarHospedes(hospedes);

        // Exibe no console a quantidade de hóspedes
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");

        // Exibe o valor total da estadia, já com possível desconto
        Console.WriteLine($"Valor total: R${reserva.CalcularValorDiaria()}");
    }
}
