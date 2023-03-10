using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_07
{
    class Program
    {
        static void Main(string[] args)
        {
            float num, cont, maior, menor, soma, medio;

            Console.WriteLine("Digite um número: ");
            num = float.Parse(Console.ReadLine());

            maior = num;
            menor = num;
            soma = num;
            medio = 0;

            for (cont = 1; cont >= 0; cont++) 
            {

                Console.WriteLine("Digite um número: ");
                num = float.Parse(Console.ReadLine());


                if (num == 0)
                {
                    break;
                }

                if (num > maior)
                {
                    maior = num;
                }
                if(num < menor)
                {
                    menor = num;
                }
               
                    soma = num + soma;             
                                
             }


            medio = soma / cont;

             Console.WriteLine("A soma dos números digitados é: "+soma);
             Console.WriteLine("A quantidade de números informados é: "+cont);
             Console.WriteLine("O valor médio entre todos os valores é: "+medio);
             Console.WriteLine("O maior valor informado é: "+maior);
             Console.WriteLine(" O menor valor informado é: "+menor);
             Console.ReadLine();
             Console.ReadKey();            
            }
        }

}

