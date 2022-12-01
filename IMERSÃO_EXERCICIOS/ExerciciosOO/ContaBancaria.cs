using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    abstract class ContaBancaria
    {
        private int numConta;
        private float saldo;

        public abstract void sacar(double v);
        public abstract void depositar(double v);
    }
}
