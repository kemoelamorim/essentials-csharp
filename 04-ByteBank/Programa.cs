using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Programa
    {
        static void Main(string[] args)
        {
            ContaCorrente contaKemoel = new ContaCorrente();
            ContaCorrente contaThamiris = new ContaCorrente();

            bool sacou = contaKemoel.Sacar(50);
            
            Console.WriteLine("Conseguiu sacar: "+ sacou);
            

            contaThamiris.Depositar(200);
            contaThamiris.Transferir(100, contaKemoel);
            Console.WriteLine(contaKemoel.saldo);
            Console.WriteLine(contaThamiris.saldo);


        }
    }
}
