using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_03_operadores_logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite um valor: ");
            numero = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (numero >= 20 && numero <= 90)
            {
                Console.WriteLine("O valor esta etre 20 e 90");
            }

            else
            {
                Console.WriteLine("O valor não esta entre 20 e 90");
            }

            Console.WriteLine();
            Console.WriteLine("Tecle Enter para sair");
            Console.ReadLine();

        }
    }
}
