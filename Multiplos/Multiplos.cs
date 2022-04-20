using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
    class Multiplos
    {
        static void Main(string[] args)
        {
            for(int multiplos = 1; multiplos<=100; multiplos++)
		    {
                if(multiplos % 3 == 0)
                {
                    Console.WriteLine(multiplos);
                }

                /*for (int i = 3; i < 100; i += 3)
                {
                    Console.WriteLine(i);
                }*/
            }
        }
    }
}
