using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador_nao
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, x;

            Console.WriteLine("Entre com o valor <a>");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor <b>");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor <c>");
            c = float.Parse(Console.ReadLine());

            Console.WriteLine();
            if (!(c > 5))
            {
                x = (a + b) * c;
                Console.WriteLine("O resultado de x equivale a: " + x);
                Console.ReadLine();
                Console.WriteLine("Selecione <ENTER> para encerrar");

            }
            else
            {
                x = (a - b) * c;
                Console.WriteLine("O resultado de x equivale a: "+x);
                Console.ReadLine();
                Console.WriteLine("Selecione <ENTER> para encerrar");
            }
            


        }

    }
}
