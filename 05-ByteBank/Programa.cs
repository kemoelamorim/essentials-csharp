using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Programa
    {
        static void Main(string[] args)
        {
            Cliente clienteKemoel = new Cliente();
            clienteKemoel.nome = "Kemoel Miranda";
            clienteKemoel.profissao = "Desenvolvedor";
            clienteKemoel.cpf = "01190944286";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = clienteKemoel;
            conta.agencia = 1001;
            conta.numero = 2322;

            Console.WriteLine(clienteKemoel.nome);
            Console.WriteLine(conta.titular.nome);

        }
    }
}
