using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabliela";
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.numero);
            Console.WriteLine(conta.saldo);
        }
    }
}
