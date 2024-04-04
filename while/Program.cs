using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Console.Write("Digite um numero: ");
                double x = double.Parse(Console.ReadLine(),CI);

                while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3" , CI));
                Console.Write("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(),CI);    
                }
                Console.WriteLine("Numero negativo! ");
            }
        }
    }
}