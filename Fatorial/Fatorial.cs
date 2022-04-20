using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Fatorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial");

            int num = 4;
            int fatorial = 1;
            for (int i = 1; i <= num; i++)
            {
                fatorial *= i;
                
                Console.WriteLine(fatorial);
            }
        }
    }
}
