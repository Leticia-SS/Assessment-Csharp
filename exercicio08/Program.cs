﻿using exercicio08;

class Program
{
    public static void Main(string[] args)
    {
        // Criando objetos funcionario e gerente
        Funcionario funcionario = new Funcionario();
        Gerente gerente = new Gerente();

        // Salvando o salário base
        funcionario._SalarioBase = 1000;
        gerente._SalarioBase = 1000;

        // Printando os dados a exibir
        funcionario.ExibirDados();
        gerente.ExibirDados();
    }
}