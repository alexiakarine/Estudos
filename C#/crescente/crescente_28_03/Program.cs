using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crescente_28_03
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3;

            Console.Write("Insira o primeiro numero:");
            num1=float.Parse(Console.ReadLine());
            Console.Write("Insira o segundo valor:");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("Insira o terceiro valor:");
            num3 = float.Parse(Console.ReadLine());

            if ((num1 < num2) & (num1 < num3)) 
            {
                if (num2 < num3)
                {
                    Console.WriteLine("Sequencia");
                    Console.WriteLine(num1.ToString());
                    Console.WriteLine(num2.ToString());
                    Console.WriteLine(num3.ToString());
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Sequencia");
                    Console.WriteLine(num1.ToString());
                    Console.WriteLine(num3.ToString());
                    Console.WriteLine(num2.ToString());
                    Console.ReadLine();
                }
            }

            else if (((num2 < num1) & (num2 < num3)))
            {
                if (num1 < num3)
                {
                    Console.WriteLine("Sequencia");
                    Console.WriteLine(num2.ToString());
                    Console.WriteLine(num1.ToString());
                    Console.WriteLine(num3.ToString());
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Sequencia");
                    Console.WriteLine(num2.ToString());
                    Console.WriteLine(num3.ToString());
                    Console.WriteLine(num1.ToString());
                    Console.ReadLine();
                }

            }
            else if (((num3 < num1) & (num3 < num2)))
                {
                    if (num2 < num1)
                    {
                        Console.WriteLine("Sequencia");
                        Console.WriteLine(num3.ToString());
                        Console.WriteLine(num2.ToString());
                        Console.WriteLine(num1.ToString());
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Sequencia");
                        Console.WriteLine(num3.ToString());
                        Console.WriteLine(num1.ToString());
                        Console.WriteLine(num2.ToString());
                        Console.ReadLine();
                    }
                }

            
            else 
                {
                    Console.WriteLine("Os numeros sao iguais!");
                        Console.WriteLine(num3.ToString());
                        Console.WriteLine(num1.ToString());
                        Console.WriteLine(num2.ToString());
                        Console.ReadLine();
                }
            }
        }
    }

