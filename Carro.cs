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
        private string modelo;   

        public void modificar(string modificador)
        {
            if (modificador == "Vectra" || modificador == "impala" || modificador == "civic type R")
            {
                modelo = modificador;
            }
            else
            {
                Console.WriteLine("Apenas modelos de homem");
                modificador = "carro de enzo";
                modelo = modificador;
            }
        }

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
