using System;

namespace uppgift_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ut tre tal du vill addera");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            int tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Summan av talen blir "+ Addera(tal1, tal2, tal3));
            Console.ReadKey();
        }
        static int Addera(int tal1, int tal2, int tal3) 
        {
            return tal1 + tal2 + tal3;
        }
    }
}
