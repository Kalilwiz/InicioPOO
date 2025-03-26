using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Livro
    {
        public string Autor;
        public string Editora;
        public string NomeDoLivro;

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Autor {Autor}");
            Console.WriteLine($"Editora {Editora}");
            Console.WriteLine($"Nome do livro {NomeDoLivro}");

        }

    }
}
