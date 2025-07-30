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

        // Reserva com menos de 10 dias (sem desconto)
        var hospedes1 = new List<Pessoa> { new Pessoa("Ana", "Souza") };
        var suite1 = new Suite("Standard", 1, 100m);
        var reserva1 = new Reserva();
        reserva1.CadastrarSuite(suite1);
        reserva1.DiasReservados = 5;
        reserva1.CadastrarHospedes(hospedes1);

        Console.WriteLine("------ Teste 1 ------");
        Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total: R${reserva1.CalcularValorDiaria()}");

        //Reserva com mais de 10 dias (com desconto)
        var hospedes2 = new List<Pessoa> { new Pessoa("Carlos", "Pereira") };
        var suite2 = new Suite("Executiva", 1, 200m);
        var reserva2 = new Reserva();
        reserva2.CadastrarSuite(suite2);
        reserva2.DiasReservados = 15;
        reserva2.CadastrarHospedes(hospedes2);

        Console.WriteLine("------ Teste 2 ------");
        Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total: R${reserva2.CalcularValorDiaria()}");

        //Reserva com número exato da capacidade
        var hospedes3 = new List<Pessoa>
{
    new Pessoa("Lucas", "Dias"),
    new Pessoa("Fernanda", "Melo")
};
        var suite3 = new Suite("Dupla", 2, 180m);
        var reserva3 = new Reserva();
        reserva3.CadastrarSuite(suite3);
        reserva3.DiasReservados = 3;
        reserva3.CadastrarHospedes(hospedes3);

        Console.WriteLine("------ Teste 3 ------");
        Console.WriteLine($"Hóspedes: {reserva3.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total: R${reserva3.CalcularValorDiaria()}");

        //Reserva excedendo a capacidade (deve lançar exceção)
        try
        {
            var hospedes4 = new List<Pessoa>
    {
        new Pessoa("Paulo", "Lima"),
        new Pessoa("Sofia", "Costa"),
        new Pessoa("Rafaela", "Nunes")
    };
            var suite4 = new Suite("Compacta", 2, 120m);
            var reserva4 = new Reserva();
            reserva4.CadastrarSuite(suite4);
            reserva4.DiasReservados = 4;
            reserva4.CadastrarHospedes(hospedes4); // Deve lançar erro
        }
        catch (Exception ex)
        {
            Console.WriteLine("------ Teste 4 ------");
            Console.WriteLine($"Erro ao cadastrar hóspedes: {ex.Message}");
        }

        //Tentativa de calcular diária sem cadastrar suíte (deve lançar erro)
        try
        {
            var reserva5 = new Reserva();
            reserva5.DiasReservados = 5;
            var valor = reserva5.CalcularValorDiaria(); // Deve lançar erro
        }
        catch (Exception ex)
        {
            Console.WriteLine("------ Teste 5 ------");
            Console.WriteLine($"Erro ao calcular diária: {ex.Message}");
        }

 
    }
}
