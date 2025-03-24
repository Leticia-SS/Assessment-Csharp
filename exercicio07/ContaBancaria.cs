using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
    internal class ContaBancaria
    {
        public string _Titular;
        private double _Saldo = 0.0;

        //Construtor para criar objeto inserindo os parametros
        public ContaBancaria(string titular)
        {
            _Titular = titular;
        }

        // Método exibir apenas titular
        public void ExibirTitular()
        {
            Console.WriteLine($"Titular: {_Titular}");
        }

        // Método Depositar
        public string Depositar(double valor)
        {
            if (valor <= 0) 
            {
                return "O valor do depósito deve ser positivo\n";
            } else
            {
                _Saldo += valor;
                return $"Depósito de {valor} realizado com sussesso!\n";
            }
        }

        // Método Sacar
        public string Sacar(double valor)
        {
            if (valor < _Saldo) 
            {
                return "Saldo insuficiente para realizar o saque!\n";
            } else
            {
                _Saldo -= valor;
                return $"Saque de {valor} realizado com sucesso!\n";
            }
        }

        // Método para exibir dados da conta
        public void ExibirDados()
        {
            Console.WriteLine($"Saldo atual: R${_Saldo}\n");
        }






    }
}
