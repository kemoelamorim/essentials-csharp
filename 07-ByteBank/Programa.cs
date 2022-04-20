using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Programa
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(190, 1001);
            
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta2 = new ContaCorrente(303, 2002);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);
        }
    }
}
