using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12_notaTurma
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, soma, media, mediaSala;
            int alunos, cont, aprovados, exame, reprovados;
            string nome;

            Console.WriteLine("Digite a quantidade de alunos tem na turma: ");
            alunos = Int32.Parse(Console.ReadLine());
            aprovados = 0;
            exame = 0;
            reprovados = 0;


            for (cont = 1; cont <= alunos; cont++) 
            {
                Console.WriteLine("Digite o nome do aluno: ");
                nome=String.Format(Console.ReadLine());

                Console.WriteLine("Digite a primeira nota do aluno: ");
                nota1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota do aluno: ");
                nota2 = float.Parse(Console.ReadLine());

                media = (nota1 + nota2)/2;

                if (media > 7)
                {
                    Console.WriteLine("O aluno(a) " + nome + " teve média " + media + " e está Aprovado");
                    aprovados=aprovados+1;
                }

                else if (media >= 3 && media <= 7)
                {
                    Console.WriteLine("O aluno(a) " + nome + " teve média " + media + " e está em Exame");
                    exame = exame + 1;
                }

                else
                {
                    Console.WriteLine("O aluno(a) " + nome + " teve média " + media + " e está Reprovado");
                    reprovados = reprovados + 1;
                }

            }
            soma = aprovados + exame + reprovados;
            mediaSala = soma/cont ;
            Console.WriteLine("A quantidade de alunos aprovados é: "+aprovados);
            Console.WriteLine("A quantidade de alunos em exame é: " + exame);
            Console.WriteLine("A quantidade de alunos reprovados é: " + reprovados);
            Console.ReadLine();




        }
    }
}
