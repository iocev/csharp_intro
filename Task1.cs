using System;
//deposit calculator

namespace p1.change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dep = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double glp = double.Parse(Console.ReadLine()) / 100;
            double suma = dep + time * ((dep * glp) / 12);
            Console.WriteLine(suma);

        }
    }
}
