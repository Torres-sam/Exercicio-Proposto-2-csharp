using System;
using System.Globalization;
namespace ExercicioProposto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Qual o valor do raio: ");
             double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             double area = Math.PI * Math.Pow(raio, 2);
             Console.WriteLine("A área do círculo é: " + area.ToString("F4",  CultureInfo.InvariantCulture));

            // ou

            double a,r, p = 3.14159;
            Console.Write("Qual o valor do raio: ");
            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = p * raio * raio;
            Console.WriteLine("A área do círculo é: " + a.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}