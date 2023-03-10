using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8_sexo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome,sexo;

            Console.WriteLine(" Informe seu nome: ");
            nome = Console.ReadLine();
            
            Console.WriteLine("\nInforme seu sexo utilizando F-feminino ou M-masculino: ");
            sexo = Console.ReadLine();

            if (sexo=="F" || sexo=="M")
            {   
                if (sexo=="F")
                {
                    Console.WriteLine("Olá Sra. " + nome);
                }

                else
                {
                    Console.WriteLine("Olá Sr. " + nome);                    ;
                }                

            }
            else
            {
                Console.WriteLine(" Sexo informado é inválido");
            }

            Console.ReadLine();

        }
    }
}
