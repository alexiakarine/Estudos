using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6_ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;

            Console.WriteLine(" Informe um número");
            num = float.Parse(Console.ReadLine());

            if (num %2==0)
            {
                Console.WriteLine(" O número informado é Par");
            }

            else
            {
                Console.WriteLine(" O número informado é Impar");
            }

            Console.ReadLine();
        }
    }
}
