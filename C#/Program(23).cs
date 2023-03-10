using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, soma;
            soma = 0;
                       
            for (cont = 0; cont <= 100; cont++)
            {
                soma = soma + cont;
            }

            Console.WriteLine("A soma de todos os números até 100 é: " + soma);
            Console.ReadLine();
        }
    }
}
