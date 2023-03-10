using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14_Positivos_E_negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativos, positivos, somapositivos, qtddeNegativos, valores, valor;
            valor = 0;
            negativos = 0;
            positivos = 0;

            for (valores = 1; valores < 50; valores++)
            {
                Console.WriteLine("Informe um valor: ");
                valor = Int32.Parse(Console.ReadLine());

                if (valor % 2 == 0)
                {
                    positivos = positivos + valor;
                }

                if (valor<0)
                {
                    negativos = negativos + 1;
                }
            }
            qtddeNegativos = negativos;
            somapositivos = positivos;

            Console.Write("A quantidade de números negativos informados é: " + qtddeNegativos);
            Console.Write("\nA soma dos números positivos informados é: " + somapositivos);
            Console.ReadLine();
        }

    }
}
