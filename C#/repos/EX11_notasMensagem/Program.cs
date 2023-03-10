using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11_notasMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, notaExame, media, mediaFinal;

            Console.WriteLine("Informe a primera nota : ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota : ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota : ");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if(media>=7)
            {
                Console.WriteLine("A média final foi " +media+ " Aprovado(a)");
            }

            else if (media>=3 && media<7)
            {
                Console.WriteLine("A média final foi " + media + " Você está em exame!");
                Console.WriteLine("\nInforme  qual sua nota no exame: ");
                notaExame = float.Parse(Console.ReadLine());

                mediaFinal = (media + notaExame)/2;
                if (mediaFinal>5)
                {
                    Console.WriteLine("A média no exame foi " + notaExame + " Você está Aprovado(a)");
                }
                else
                {
                    Console.WriteLine("A média no exame foi " + notaExame + " Você está Reprovado");
                }

            }

            else
            {
                Console.WriteLine("A média final foi " + media + " Reprovado sem direito á exame!");
            }

            Console.ReadLine();
        }
    }
}
