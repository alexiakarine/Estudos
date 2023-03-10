using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador_ou
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.WriteLine("Digite o codigo");
            codigo= int.Parse(Console.ReadLine());

            if (codigo==1 || codigo==2 || codigo==3)
            {
                if (codigo == 1)
                {
                    Console.WriteLine("Acesso concedido");
                    Console.ReadLine();
                    Console.WriteLine("Pressione Enter para Sair");
                }

                if (codigo == 2)
                {
                    Console.WriteLine("Acesso concedido");
                    Console.ReadLine();
                    Console.WriteLine("Pressione Enter para Sair");
                }

                if (codigo == 3)
                {
                    Console.WriteLine("Acesso concedido");
                    Console.ReadLine();
                    Console.WriteLine("Pressione Enter para Sair");
                }

             }
            else
            {
                Console.WriteLine("Codigo invalido");
                Console.ReadLine();
                Console.WriteLine("Pressione Enter para Sair");
            }
        }

    }
}
