using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4_energia
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, watt, pagar, desconto, watConsumido;

            Console.WriteLine("Informe o valor do salario mínimo: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do quilowatt consumidos: ");
            watConsumido = double.Parse(Console.ReadLine());

            watt = (salario / 5);
            Console.WriteLine("O valor de cada watt é: "+watt);

            pagar = watt * watConsumido;
            Console.WriteLine("O valor a ser pago na conta de luz é: "+pagar);

            desconto = pagar - ((pagar * 15) / 100);
            Console.WriteLine("O valor a ser pago na conta de luz com desconto de 15% é: " + desconto);
            Console.ReadLine();













        }
    }
}
