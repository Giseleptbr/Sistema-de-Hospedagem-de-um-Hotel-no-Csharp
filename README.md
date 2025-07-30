# Sistema-de-Hospedagem-de-um-Hotel-no-Csharp

# Sistema de Hospedagem de um Hotel em C#

Este projeto simula um sistema de hospedagem desenvolvido com a linguagem **C#** no contexto do bootcamp da DIO.

## Objetivo

O sistema foi construído para gerenciar reservas em um hotel, permitindo o cadastro de hóspedes, definição de suítes, cálculo do valor da diária e validações de capacidade.

---

## Funcionalidades

 **Cadastro de hóspedes**  
 **Cadastro da suíte**  
 **Criação de reservas**  
 **Validação da capacidade da suíte**  
 **Cálculo da quantidade de hóspedes**  
 **Cálculo do valor total da estadia**  
 **Desconto de 10% para estadias de 10 dias ou mais**  
 **Tratamento de exceções**

---

##  Tecnologias Utilizadas

- C#
- .NET
- Programação Orientada a Objetos (POO)

---

##  Regras de Negócio

- A suíte deve ter capacidade suficiente para o número de hóspedes.
- Se a reserva for para **10 dias ou mais**, o valor total terá **10% de desconto**.
- O valor da estadia é calculado por:  
  `ValorDiaria × DiasReservados`
- Exceções são lançadas caso:
  - A suíte não tenha sido cadastrada antes dos hóspedes.
  - A quantidade de hóspedes ultrapasse a capacidade da suíte.
