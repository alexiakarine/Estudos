using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumAnt, NumAtu, Fibonacci, Inicio;
            NumAnt = 0;
            NumAtu = 1;
            Fibonacci = 0;
            Inicio = 0;

            // condição para impressão da sequencia //

            for (int i = 0; Fibonacci < 1000; i++)
            {
                // condição para impressão dos primeiros numeros // 
                if (Inicio <= 1)
                {
                    Console.WriteLine("{0} ", Inicio);
                }

                Fibonacci = NumAnt + NumAtu;

                // condição de parada de impressão do numero fibonacci, obs: sem isso ele imprime uma casa depois do limite estipulado (1000)// 
                if (Fibonacci < 1000)
                {
                    Console.WriteLine("{0}", Fibonacci);
                }

                NumAnt = NumAtu;
                NumAtu = Fibonacci;

                Inicio++;
            }

            Console.ReadLine();
        }
    }
}