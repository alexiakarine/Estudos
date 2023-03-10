using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada=0;                  


            for (int num = 1; num <= 10; num++)
            {
                Console.WriteLine("Tabuada do número "+num);

                for (int num2 = 1; num2 <= 10; num2++)
                {
                    tabuada = num * num2;
                    Console.WriteLine(num + "x" + num2 + "=" + tabuada);
                }

            }
            Console.ReadKey();

        }
    }
}
