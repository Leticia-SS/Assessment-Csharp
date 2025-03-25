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
        protected double _SalarioBase;

        public virtual double SalarioBase
        {
            get => _SalarioBase;
            set => _SalarioBase = value;

        }

        public void ExibirDados()
        {
            Console.WriteLine($"Saldo atual: R${_SalarioBase}\n");
        }
    }
}
