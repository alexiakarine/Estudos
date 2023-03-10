using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int nanterior, natual, cont, sequencia;
            
            natual = 1;
            nanterior = 0;
            sequencia = 0;

            
            for (cont = 0; cont<100; cont++)
            {
                sequencia = nanterior + natual;
                Console.WriteLine(sequencia);
                nanterior = natual;
                natual= sequencia;

            }
            Console.ReadKey();
        }
    }
}
