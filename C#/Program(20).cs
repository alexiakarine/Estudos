using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_06
{
    class Program
    {
        static void Main(string[] args)
        {
            float massa, tempo, n, cont;
            tempo = 0;

            Console.WriteLine("Informe em gramas qual a massa do material: ");
            massa = float.Parse(Console.ReadLine());
            n = float.Parse(Console.ReadLine());

            for (cont = 0; cont<=n; cont++)
            {
                
                if (massa < 0.05)
                {
                    massa = massa / 2;
                    tempo = tempo + 1;

                }

            }
            Console.WriteLine("Para que a massa do elemento seja menor que 0.05, levará: " + tempo);
            Console.ReadKey();
        }
    }
            
 }
 

