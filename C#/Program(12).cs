using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_qtdeRacao
{
    class Program
    {
        static void Main(string[] args)
        {
           double pesoSaco, qtdeRacao, gramas, racaoDias, sobra;

            Console.WriteLine("|---Valor em kg---|---Valor correspondente em gramas--|");
            Console.WriteLine("|-- 1 kg ---------|----- 1.0000 gramas----------------| ");
            Console.WriteLine("|-- 5 kg ---------|----- 5.0000 gramas----------------|");
            Console.WriteLine("|-- 10 kg --------|---- 10.0000 gramas----------------| ");
            Console.WriteLine("|-- 15 kg---------|---- 15.0000 gramas----------------|");
            Console.WriteLine("|-- 20 kg---------|---- 20.0000 gramas----------------|");
            Console.WriteLine("|-- 25 kg---------|---- 25.0000 gramas----------------|");
            Console.WriteLine("|-- 50 kg---------|---- 50.0000 gramas----------------|\n");



            Console.WriteLine("De acordo com a tabela acima informe o peso do saco em em gramas: ");
            pesoSaco = double.Parse(Console.ReadLine());

            Console.WriteLine("Indforme a quantidade em gramas de ração diária  que os gatos consomem: ");
            qtdeRacao = double.Parse(Console.ReadLine());

            
            racaoDias = qtdeRacao*5;

            sobra = pesoSaco - racaoDias;
            

            Console.WriteLine("A quantidade em gramas que restará no saco após 5 dias será de: "+sobra);
            Console.ReadLine();


        }
    }
}
