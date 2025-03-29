using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio09
{
    internal class Produto
    {
        // Atributo dos produtos a serem adicionados no estoque
        public string _Nome { get; set; }
        public int _QuantidadeEstoque { get; set; }
        public double _Preco { get; set; }

        // Construtor com parâmetros
        public Produto(string nome, int quantidadeEstoque, double preco)
        {
            _Nome = nome;
            _Preco = preco;
            _QuantidadeEstoque = quantidadeEstoque;
        }

        public void MostrarProdutod()
        {
            Console.WriteLine($"\nProduto: Nome: {_Nome} | Quantidade: {_QuantidadeEstoque} | Preço: R${_Preco}");
        }
    }
}
