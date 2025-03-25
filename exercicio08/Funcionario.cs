using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
    internal class Funcionario
    {
        public string _Nome { get; set; }
        public string _Cargo { get; set; }
        public double _SalarioBase { get; set; }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Saldo atual do Funcionário: R${_SalarioBase}\n");
        }
    }
}
