using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
    internal class Aluno
    {
        private string _Nome;
        private int _Matricula;
        private string _Curso;
        private double _MediaDasNotas;

        // Construtor para criar o objeto já com os parâmetros setados
        public Aluno(string nome, int matricula, string curso, double mediaDasNotas)
        {
            _Nome = nome;
            _Matricula = matricula;
            _Curso = curso;
            _MediaDasNotas = mediaDasNotas;
        }

        // Método para exibir os dados do aluno
        public void ExibirDados()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"Nome: {_Nome}");
            Console.WriteLine($"Matrícula: {_Matricula}");
            Console.WriteLine($"Curso: {_Curso}");
            Console.WriteLine($"Média das notas: {_MediaDasNotas}");
            Console.WriteLine("\n");
        }

        // Método para erificar aprovação
        public void VerificarAprovacao()
        {
            if (_MediaDasNotas >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }


    }
}
