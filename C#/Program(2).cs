using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13_CARRO
{
    class Program
    {
        static void Main(string[] args)
        {
            float carro, valorParcela, preçoFinal,avista;
            int opcao;


            Console.WriteLine("Informe o valor do carro: ");
            carro = float.Parse(Console.ReadLine());

            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|------Quantidade-----|-----Acréscimo sobre ---|-----Selecione-----|");
            Console.WriteLine("|------de parcelas ---|-----o preço final -----|-----uma opção-----|");
            Console.WriteLine("|------   6  ---------|---------  3%  ---------|------   1   ------|");
            Console.WriteLine("|------  12  ---------|---------  6%  -------- |------   2   ------|");
            Console.WriteLine("|------  18  ---------|---------  9%  ---------|------   3   ------|");
            Console.WriteLine("|------  24  ---------|--------- 12%  ---------|------   4   ------|");
            Console.WriteLine("|------  30  ---------|--------- 15%  ---------|------   5   ------|");
            Console.WriteLine("|------  36  ---------|--------- 18%  ---------|------   6   ------|");
            Console.WriteLine("|------  42  ---------|--------- 21%  ---------|------   7   ------|");
            Console.WriteLine("|------  48  ---------|--------- 24%  ---------|------   8   ------|");
            Console.WriteLine("|------  54  ---------|--------- 27%  ---------|------   9   ------|");
            Console.WriteLine("|------  60  ---------|--------- 30%  ---------|------  10   ------|");
            Console.WriteLine("|------     Para finalizar a consulta ---------|------  11   ------|");
            Console.WriteLine("|------------------------------------------------------------------|");

            Console.WriteLine("Informe a opção desejada: ");
            opcao = Int32.Parse(Console.ReadLine());



            while (opcao<11)
            {
                if (opcao==1)
                {
                    avista = carro - ((carro * 20) / 100);
                    valorParcela = carro / 6;
                    preçoFinal =  valorParcela + ((carro * 3) / 100);

                    Console.WriteLine("Com 6 parcelas de valor R$ "+valorParcela+" cada, o valor final do carro será de R$" +preçoFinal);
                    Console.WriteLine("Valor da compra á vista sera de R$ "+avista);
                }

                else if(opcao==2)
                {
                    avista = carro - ((carro * 20) / 100);
                    valorParcela = carro / 12;
                    preçoFinal = valorParcela + ((carro * 6) / 100);

                    Console.WriteLine("Com 12 parcelas de valor R$ " + valorParcela + " cada, o valor final do carro será de R$" + preçoFinal);
                    Console.WriteLine("Valor da compra á vista sera de R$ " + avista);
                }

                else if(opcao==3)
                {
                    avista = carro - ((carro * 20) / 100);
                    valorParcela = carro / 18;
                    preçoFinal = valorParcela + ((carro * 9) / 100);

                    Console.WriteLine("Com 18 parcelas de valor R$ " + valorParcela + " cada, o valor final do carro será de R$" + preçoFinal);
                    Console.WriteLine("Valor da compra á vista sera de R$ " + avista);
                }

                else if(opcao==4)
                {
                    avista = carro - ((carro * 20) / 100);
                    valorParcela = carro / 24;
                    preçoFinal = valorParcela + ((carro * 12) / 100);

                    Console.WriteLine("Com 24 parcelas de valor R$ " + valorParcela + " cada, o valor final do carro será de R$" + preçoFinal);
                    Console.WriteLine("Valor da compra á vista sera de R$ " + avista);
                }

                else if(opcao==5)
                {
                    avista = carro - ((carro * 20) / 100);
                    valorParcela = carro / 30;
                    preçoFinal = valorParcela + ((carro * 15) / 100);

                    Console.WriteLine("Com 30 parcelas de valor R$ " + valorParcela + " cada, o valor final do carro será de R$" + preçoFinal);
                    Console.WriteLine("Valor da compra á vista sera de R$ " + avista);
                }

                else if(opcao==6)
                {
                    avista = carro - ((carro * 20) / 100);
                    valorParcela = carro / 36;
                    preçoFinal = valorParcela + ((carro * 18) / 100);

                    Console.WriteLine("Com 36 parcelas de valor R$ " + valorParcela + " cada, o valor final do carro será de R$" + preçoFinal);
                    Console.WriteLine("Valor da compra á vista sera de R$ " + avista);
                }

                else if(opcao==7)
                {
                    avista = carro - ((carro * 20) / 100);
                    valorParcela = carro / 42;
                    preçoFinal = valorParcela + ((carro * 21) / 100);

                    Console.WriteLine("Com 42 parcelas de valor R$ " + valorParcela + " cada, o valor final do carro será de R$" + preçoFinal);
                    Console.WriteLine("Valor da compra á vista sera de R$ " + avista);
                }

                else if(opcao==8)
                {
                    avista = carro - ((carro * 20) / 100);
                    valorParcela = carro / 48;
                    preçoFinal = valorParcela + ((carro * 24) / 100);

                    Console.WriteLine("Com 48 parcelas de valor R$ " + valorParcela + " cada, o valor final do carro será de R$" + preçoFinal);
                    Console.WriteLine("Valor da compra á vista sera de R$ " + avista);
                }

                else if(opcao==9)
                {
                    avista = carro - ((carro * 20) / 100);
                    valorParcela = carro / 54;
                    preçoFinal = valorParcela + ((carro * 27) / 100);

                    Console.WriteLine("Com 54 parcelas de valor R$ " + valorParcela + " cada, o valor final do carro será de R$" + preçoFinal);
                    Console.WriteLine("Valor da compra á vista sera de R$ " + avista);
                }

                else if(opcao==10)
                {
                    avista = carro - ((carro * 20) / 100);
                    valorParcela = carro / 60;
                    preçoFinal = valorParcela + ((carro * 30) / 100);

                    Console.WriteLine("Com 60 parcelas de valor R$ " + valorParcela + " cada, o valor final do carro será de R$" + preçoFinal);
                    Console.WriteLine("Valor da compra á vista sera de R$ " + avista);
                }

                else
                {
                    Console.WriteLine("Opção inválida ");
                }

                return;

            }

            Console.ReadLine();
            Console.WriteLine("Ao selecionar a tecla <ENTER> o programa será fechado");
            Console.ReadKey();
        }
    }
}
