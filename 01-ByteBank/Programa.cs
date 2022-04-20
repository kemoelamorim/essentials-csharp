using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Programa
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoKemoel = new ContaCorrente();
            contaDoKemoel.titular = "Kemoel Amorim Miranda";
            contaDoKemoel.agencia = 2778;
            contaDoKemoel.saldo = 1930.90;
            Console.WriteLine("Titular: "+ contaDoKemoel.titular);
            Console.WriteLine("Agencia: "+ contaDoKemoel.agencia);
            Console.WriteLine("Saldo: "+ contaDoKemoel.saldo);

            contaDoKemoel.saldo += 200;
            Console.WriteLine(contaDoKemoel.saldo);
        }
    }
}
