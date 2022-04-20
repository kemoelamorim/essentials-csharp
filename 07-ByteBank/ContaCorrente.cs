using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        
        private int _agencia;
        private int _numero;
        public Cliente Titular { get; set; }
        public int Agencia {
            get {
                return _agencia;
            }
            set { 
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        public int Numero {
            get {
                return _numero;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _numero = value;
            }
                
        }

        private double _saldo = 100;
        public double Saldo {
            get { 
                return _saldo;
            }
            set { 
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }   
        }
        public ContaCorrente(int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;
            ContaCorrente.TotalDeContasCriadas++;

        }
        public bool Sacar(double valor)
        {
            if(this._saldo >= valor){
                this._saldo -= valor;
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
                this._saldo += valor;
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
