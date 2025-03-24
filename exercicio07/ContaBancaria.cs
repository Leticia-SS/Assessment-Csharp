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
        private double _Saldo;

        //Construtor para criar objeto inserindo os parametros
        public ContaBancaria(string titular, double saldo)
        {
            _Titular = titular;
            _Saldo = saldo;
        }

        // Método Depositar
        public double Depositar(double valor)
        {
            return _Saldo + valor;
        }

        // Método Sacar
        public double Sacar(double valor)
        {
            return _Saldo - valor;
        }






    }
}
