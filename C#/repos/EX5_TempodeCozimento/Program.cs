using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5_TempodeCozimento
{
    class Program
    {
        static void Main(string[] args)
        {
           TimeSpan horaInicio, minutosInicio, tempoCozimento,tempoFinal, tempoDesejado;

            Console.WriteLine("Informe a hora de inicio de cozimento: ");
            horaInicio = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Informe os minutos de inicio de cozimento: ");
            minutosInicio = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tempo desejado de cozimento: ");
            tempoDesejado = TimeSpan.Parse(Console.ReadLine());

            tempoCozimento =horaInicio+minutosInicio;
            tempoFinal = tempoCozimento +tempoDesejado;

            Console.WriteLine("Início ás"+ horaInicio + "horas e" + minutosInicio + "min com cozimento de " + tempoDesejado + "-> Interromper o cozimento ás " + tempoFinal);    
            Console.ReadLine();

        }
    }
}
