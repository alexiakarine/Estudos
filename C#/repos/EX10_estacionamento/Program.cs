using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10_estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan horaEntrada, minutosEntrada, horaSaida, minutosSaida,valorPagar, horaTotal, minutosTotal;

            Console.WriteLine("Informe a hora de entrada: ");
            horaEntrada = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Informe os minutos de entrada: ");
            minutosEntrada = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Informe a hora de saída: ");
            horaSaida = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Informe os minutos de saída: ");
            minutosSaida = TimeSpan.Parse(Console.ReadLine());

            horaTotal = horaSaida - horaEntrada;
            minutosTotal = minutosSaida - minutosEntrada;

            tempo = horaTotal + minutosTotal;
                       
            if(tempo>1)
            {
                Console.WriteLine("O tempo total de permanência no estacionamento foi de "+ tempo+ "O valor a ser pago será de R$4,00 ");
            }

            else if(tempo=2)
            {

            }

        }
    }
}
