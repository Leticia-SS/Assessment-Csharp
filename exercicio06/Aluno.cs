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
        }

        // Método para calcular a média das notas
        public double CalcularMedia(double[] notas)
        {
            int soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += Convert.ToInt32(notas[i]);
            }
            _MediaDasNotas = soma / notas.Length;
            return _MediaDasNotas;
        }


    }
}
