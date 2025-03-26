using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Carro
    {
        public string Marca;
        public int AnoDeFabricacao;
        public string modelo;   


        public void Andar()
        {
            Console.WriteLine("Carro esta em movimento");
        }

        public void Parar()
        {
            Console.WriteLine("Carro esta parando");
        }

        public void MostrarInfomacoes()
        {
            Console.WriteLine($"Modelo do carro {modelo}");
            Console.WriteLine($"ano de fabricacao {AnoDeFabricacao}");
            Console.WriteLine($"Marca do carro {Marca}");
        }
    }

}
