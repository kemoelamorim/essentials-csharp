using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            for (int coluna = 1; coluna < 10; coluna++)
            {
                for (int linha = 1; linha < 10; linha++)
                {
                    Console.Write("*");
                    if (coluna <= linha)
                        break;
                }
                Console.WriteLine();
            }

            for (int coluna = 1; coluna < 10; coluna++)
            {
                for (int linha = 1; coluna >= linha; linha++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
