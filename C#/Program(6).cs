using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            double Salario, novoSalario, imposto, opcao;

            Console.WriteLine("Informe o salário do funcionario");
            Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|--------Selecione qual calculo deseja fazer-------|");
            Console.WriteLine("|---------Imposto---------|------Selecione 1-------|");
            Console.WriteLine("|------Novo salário-------|------Selecione 2-------|");
            Console.WriteLine("|------Classificação------|------Selecione 3-------|");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("\nInforme a opção desejada");
            opcao = double.Parse(Console.ReadLine());

            if (opcao==1)
            {
                if (Salario<500)
                {
                    imposto = Salario - ((Salario*5)/100);
                    Console.WriteLine("5% de imposto sobre o salário informado equivale a: "+imposto);                    
                }

                else if (Salario>=500 && Salario<=850)
                {
                    imposto = Salario - ((Salario * 10) / 100);
                    Console.WriteLine("10% de imposto sobre o salário informado equivale a: " + imposto);
                }

                else
                {
                    imposto = Salario - ((Salario * 15) / 100);
                    Console.WriteLine("15% de imposto sobre o salário informado equivale a: " + imposto);
                }
            }

            else if (opcao==2)
            {
                if (Salario >= 750 && Salario <= 1.500)
                {
                    novoSalario = Salario + 50;
                    Console.WriteLine("O novo salário com aumento de R$50,00 será: "+novoSalario);
                }

                 else if (Salario>1.500)
                {
                    novoSalario = Salario + 25;
                    Console.WriteLine("O novo salário com aumento de R$25,00 será: " + novoSalario);
                }

                else if (Salario>=450 && Salario<750)
                {
                    novoSalario = Salario + 75;
                    Console.WriteLine("O novo salário com aumento de R$75,00 será: " + novoSalario);
                }

                else
                {
                    novoSalario = Salario + 100;
                    Console.WriteLine("O novo salário com aumento de R$100,00 será: " + novoSalario);
                }

            }

            else if (opcao==3)
            {
                if (Salario<=700)
                {
                    Console.WriteLine("O funcionário que recebe o salário de" +Salario+"é menor que R$700,00 está sendo MAL REMUNERADO");
                }

                else
                {
                    Console.WriteLine("O funcionário que recebe o salário de" + Salario + "é maior que R$700,00 está sendo BEM REMUNERADO");
                }
            }

            else
            {
                Console.WriteLine(" Erro, favor selecionar alguma das opções!");
            }

            Console.ReadLine();

        }
    }
}
