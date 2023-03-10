using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            for (num = 7; num <=1000; num++)
            {
                if (num % 7 == 0)
                {
                    Console.WriteLine(num);
                    
                }                
            }

            
            Console.ReadKey();
        }
    }
}
