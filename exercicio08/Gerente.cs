using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
    internal class Gerente : Funcionario
    {
        public override void ExibirDados()
        {
            Console.WriteLine($"Saldo atual do Gerente: R${_SalarioBase * 1.2}\n");
        }

    }
}
