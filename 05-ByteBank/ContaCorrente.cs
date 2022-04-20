using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;


        public bool Sacar(double valor)
        {
            if(this.saldo >= valor){
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Depositar(double valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine($"O valor :{valor} não é permitido");
            }
            else
            {
                this.saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente conta)
        {
            if(this.Sacar(valor))
            {
                conta.Depositar(valor);
                return true;
            }
            return false;

        }
    }
}
