using System;

namespace Exercicio_Milhas_Para_Km
{
    class Program
    {
        static void Main(string[] args)
        {
                double milhas, km = 1.609, resultado; 

                Console.ForegroundColor = ConsoleColor.Yellow;
               Console.Write("-----Milhas para Km-----");
               Console.WriteLine();
               Console.Write("Conversão de Milhas para KM");
               Console.WriteLine();
               Console.Write("Digite um Numero:");
               Console.ResetColor();

                 milhas = Convert.ToDouble(Console.ReadLine());
                
                
                     resultado = milhas*km;

                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine($"{resultado:N3}");
                     Console.ResetColor();
            
        }
    }
}
