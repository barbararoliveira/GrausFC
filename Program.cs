using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, vou ajudá-lo a coverter °F para °C. Digite enter para continuar:");
            Console.ReadKey();

            Console.WriteLine("Digite o valor em °F:");
            double F = double.Parse (Console.ReadLine ());

            double vl = 1.8; // vl = valor 
            double vl2  = 32; // vl2 = outro valor

            Console.Write(F + " °F equivalem a: ");
            Console.Write(F - vl2 / vl );
            Console.WriteLine(" °C.");
            
            Console.ReadKey();
        }
    }
}
