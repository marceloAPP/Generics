using System;

namespace generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("Quantos Valores: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValues(x);
            }

            printService.Print();
            Console.WriteLine("Primeiro: " + printService.Fisrt());
        }
    }
}
