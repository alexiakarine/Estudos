using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisao_encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Informa o lado A: " );
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informa o lado B: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Informa o lado c: ");
            c = float.Parse(Console.ReadLine());

            Console.WriteLine();
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triangulo Equilatero");
                    Console.ReadLine();
                    Console.WriteLine("Tecle <Entre> para encerrar");
                }
                else
                {
                    if (a == b || b == c || c == b)
                    {
                        Console.WriteLine("Triangulo Isoceles");
                        Console.ReadLine();
                        Console.WriteLine("Tecle <Entre> para encerrar");
                    }

                    else
                    {
                        Console.WriteLine("Triangulo Escaleno"); 
                        Console.ReadLine();
                        Console.WriteLine("Tecle <Entre> para encerrar");
                    }

                 }
            }

            else
                {
                    Console.WriteLine();
                    Console.WriteLine("Tecle <Entre> para encerrar");
                    Console.ReadLine();
                }
            }
        }

}

