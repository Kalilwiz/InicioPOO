using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public void CalcularTotal()
        {
            Console.WriteLine(quantidadeEmEstoque * preco);
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine(nome);
            Console.WriteLine(preco);
            Console.WriteLine(quantidadeEmEstoque);
        }
    }
}
