using System;
using System.Globalization;
namespace BEE_1156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            double den = 1.0, soma = 0.0;
            for (num = 1; num <= 39; num += 2)
            {
                soma = soma + num / den;
                den = den * 2.0;
            }
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
