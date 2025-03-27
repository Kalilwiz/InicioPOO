using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Funcionario
    {
        private double _salario;
        public void SetSalario(double mod)
        {
            _salario += mod;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }
}
