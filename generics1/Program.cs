using System;

namespace generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("Quantos Valores: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValues(x);
            }

            int a = printService.Fisrt();
            int b = a + 2;
            Console.WriteLine(b);

            printService.Print();
            Console.WriteLine("Primeiro: " + printService.Fisrt());
        }
    }
}
