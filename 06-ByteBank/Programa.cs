using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto _06_ByteBank");

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Kemoel";
            cliente.CPF = "000.000.000-00";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Saldo);
        }
    }
}
