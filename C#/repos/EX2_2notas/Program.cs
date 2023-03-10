using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_2notas
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, media, peso1, peso2,npeso1, npeso2;

            Console.WriteLine("Insira a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a valor do peso da 1ª nota: ");
            peso1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a valor do peso da 2ª nota: ");
            peso2 = float.Parse(Console.ReadLine());

            npeso1 = nota1 * peso1;
            npeso2 = nota2 * peso2;

            media = (npeso1 + npeso2) / 2;

            Console.WriteLine("A média das notas informadas é: " +media);
            Console.ReadLine();

        }
    }
}
