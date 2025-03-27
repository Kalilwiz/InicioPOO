using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Aluno
    {
        public string nome;
        public int idade;
        public double nota_final;

        public void Mostrarinfos()
        {
            Console.WriteLine($"{nome}");
            Console.WriteLine($"{idade}");
            Console.WriteLine($"{nota_final}");
        }
    }
}
