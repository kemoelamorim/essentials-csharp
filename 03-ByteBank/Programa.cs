using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Programa
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            ContaCorrente contaDaGabrielaSilva = contaDaGabrielaCosta;
            
            // ContaCorrente contaDaGabrielaSilva = new ContaCorrente();

            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.numero = 1001;
            contaDaGabrielaCosta.agencia = 2001;
            Console.WriteLine(contaDaGabrielaCosta.titular);

            
         
            contaDaGabrielaSilva.titular = "Gabriela";

          
            Console.WriteLine("Igualdade do tipo de referência: " + (contaDaGabrielaSilva == contaDaGabrielaCosta));    

            Console.WriteLine("Igualdade de tipo de valor: " + (contaDaGabrielaSilva.titular == contaDaGabrielaCosta.titular));
        }
    }
}
