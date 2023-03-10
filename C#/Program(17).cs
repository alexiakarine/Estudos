using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_08
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, media, soma, cont, N, mediatotal, aprovados,reprovado,exame,total;
            string nome;
            total = 1;
            media = 0;
            mediatotal = 0;
            aprovados = 0;
            exame = 0;
            reprovado = 0;
            

            Console.WriteLine("Digite a quantidade de alunos na turma: ");
            N = float.Parse(Console.ReadLine());

            for (cont = 0; cont <= (N-1); cont++)
            {
                Console.WriteLine("Digite o nome do aluno(a): ");
                nome = string.Format(Console.ReadLine());

                Console.WriteLine("Digite a 1ª nota do aluno(a): ");
                nota1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 2ª nota do aluno(a): ");
                nota2 = float.Parse(Console.ReadLine());

                soma = nota1 + nota2;
                media = soma / 2;
                
                if (media <3)
                {
                    Console.WriteLine("Reprovado(a)");
                    reprovado = reprovado + 1;
                    mediatotal = media + mediatotal;


                }

                 if (media >= 3 && media < 7)
                {
                    Console.WriteLine("Em exame");
                    exame = exame + 1;
                    mediatotal = media + mediatotal;
                }

                if (media>7)
                {
                    Console.WriteLine("Aprovado(a)");
                    aprovados = aprovados + 1;
                    mediatotal = media + mediatotal;

                }

                Console.WriteLine("O aluno {0} teve a média {1}", nome,media);
                Console.WriteLine("Primeira nota {0} e Segunda  nota {1} ", nota1,nota2);
                Console.WriteLine("");
                



            }

            total = (mediatotal / N);
            Console.WriteLine("A média da turma é: "+total);
            Console.WriteLine("A quantidade de alunos aprovados é:  "+aprovados);
            Console.WriteLine("A quantidade de alunos reprovados é: "+reprovado);
            Console.WriteLine("A quantidade de alunos em exame é: "+exame);
            Console.ReadKey();



        }
    }
}
