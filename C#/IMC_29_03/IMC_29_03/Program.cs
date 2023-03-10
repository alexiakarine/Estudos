using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_29_03
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, IMC;

            Console.WriteLine("Informe seu peso altual: ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura: ");
            altura = float.Parse(Console.ReadLine());

            IMC = (peso / (altura * altura));

            if (IMC<=18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
                Console.WriteLine(IMC.ToString());
                            
            }

            else if ((IMC >=18.5) && (IMC<=24.9))
            {
                Console.WriteLine("Peso normal ");
                Console.WriteLine(IMC.ToString());
                

            }

            else if ((IMC >= 25) && (IMC <= 29.9))
            {
                Console.WriteLine("Sobrepeso ");
                Console.WriteLine(IMC.ToString());
                
            }

            else if ((IMC >= 30) && (IMC <= 34.9))
            {
                Console.WriteLine("Peso Obesidade grau 1 ");
                Console.WriteLine(IMC.ToString());
               
            }
            else if ((IMC >= 35) && (IMC <= 39.9))
            {
                Console.WriteLine("Peso Obesidade grau 2 ");
                Console.WriteLine(IMC.ToString());
                
            }

            else 
            {
                Console.WriteLine("Obesidade grau 3 ");
                Console.WriteLine(IMC.ToString());
                
            }

            Console.ReadKey();
            Console.WriteLine("Digite <Enter> para sair !");


            

            
        }
    }
}
