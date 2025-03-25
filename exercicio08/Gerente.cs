using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
    internal class Gerente : Funcionario
    {
        public override double _SalarioBase
        {
            get => base._SalarioBase;
            set => base._SalarioBase = value * 1.2;

        }

    }
}
