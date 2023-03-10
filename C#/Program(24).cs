using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_while_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
           int n, cont, soma;
            soma=0;
            
            Console.WriteLine("Digite um numero qualquer: ");
            cont = int.Parse(Console.ReadLine());

            for (n = 0; n <= cont; n++ )
            {
                if (n % 2 == 1)
                {
                    Console.WriteLine(n);
                    soma = soma + n;

                }
                                
            }

            Console.WriteLine("A soma dos numeros negativos é: " + soma);
            Console.ReadLine();

        }
    }
}
