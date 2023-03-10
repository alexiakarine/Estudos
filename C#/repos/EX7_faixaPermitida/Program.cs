using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7_faixaPermitida
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine(" Informe um número entre 1 e 9");
            num = int.Parse(Console.ReadLine());

            if(num>1 && num<9)
            {
                Console.WriteLine(" O número informado está dentro da faixa permitida");
            }

            else
            {
                Console.WriteLine(" O número informado NÃO está dentro da faixa permitida");
            }

            Console.ReadLine();

        }
    }
}
