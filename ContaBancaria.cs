using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class ContaBancaria
    {
        private double _saldo = 0;

        public double Depositar(double valor)
        {
            _saldo += valor;

            return _saldo;
        }

        public double Sacar(double valor)
        {
            _saldo -= valor;

            return _saldo;
        }

        public double Mostrar()
        {
            return _saldo;
        }
    }
}
