namespace Models
{
    // Classe que representa um hóspede
    public class Pessoa
    {
        // Propriedades públicas para armazenar nome e sobrenome
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        // Construtor da classe para inicializar um hóspede
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}

