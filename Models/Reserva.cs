using System;
using System.Collections.Generic;

namespace Models
{
    // Classe que representa uma reserva feita no hotel
    public class Reserva
    {
        // Lista de hóspedes associados a essa reserva
        public List<Pessoa> Hospedes { get; private set; } = new List<Pessoa>();

        // A suíte que foi reservada
        public Suite? Suite { get; private set; }

        // Quantidade de dias reservados
        public int DiasReservados { get; set; }

        // Método para cadastrar os hóspedes na reserva
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Garante que a suíte esteja cadastrada antes de registrar os hóspedes
            if (Suite == null)
                throw new InvalidOperationException("A suíte deve ser cadastrada antes dos hóspedes.");

            // Verifica se a quantidade de hóspedes excede a capacidade da suíte
            if (hospedes.Count > Suite.Capacidade)
                throw new ArgumentException("Número de hóspedes excede a capacidade da suíte.");

            // Se tudo estiver certo, atribui os hóspedes à reserva
            Hospedes = hospedes;
        }

        // Método para cadastrar uma suíte na reserva
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        // Retorna o número total de hóspedes cadastrados
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        // Calcula o valor total da diária com base nos dias e aplica desconto, se aplicável
        public decimal CalcularValorDiaria()
        {
            // Garante que a suíte tenha sido cadastrada antes de calcular o valor
            if (Suite == null)
                throw new InvalidOperationException("A suíte deve ser cadastrada antes de calcular o valor da diária.");

            // Multiplica o valor da diária pelo número de dias
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Aplica 10% de desconto se a reserva for igual ou maior a 10 dias
            if (DiasReservados >= 10)
            {
                valor *= 0.9m;
            }

            return valor;
        }
    }
}
