using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reajuste_salarial_29_03
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, salarioAtual;

            Console.WriteLine("Informe seu salário atual: ");
            salario = float.Parse(Console.ReadLine());

            if (salario <= 1.700)
            {
                salarioAtual = salario + 300;
                Console.WriteLine("O valor do salario atual sera de:");
            }
            else
            { 
                salarioAtual=salario+200;
                Console.WriteLine("O valor do salario atual sera de:");
            }

            Console.WriteLine(salarioAtual.ToString());
            Console.ReadKey();
            Console.WriteLine("Tecle <ENTER> para sair !!");
        }
    }
}
