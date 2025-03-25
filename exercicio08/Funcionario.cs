using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
    internal class Funcionario
    {
        private string _Nome;
        private string _Cargo;
        private double SalarioBase;

        public double _SalarioBase
        {
            get => SalarioBase;
            set => SalarioBase = value;

        }

        public void ExibirDados()
        {
            Console.WriteLine($"Saldo atual: R${SalarioBase}\n");
        }
    }
}
