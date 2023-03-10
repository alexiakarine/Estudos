using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Double cont, ze, chico;
            ze = 1.10;
            chico = 1.50;
            cont = 0;           

            for (cont = 0; cont<=40; cont++) 
            {            
                                
                if (chico>ze)
                {                     
                    ze = 1.50 + 4;
                    chico = 1.10 + 3;                   
                    
                }                

            }

            Console.WriteLine("Zé será maior que chico em: " + cont);
            Console.ReadKey();

        }
    }
}
