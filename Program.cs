using System;

namespace GHTEST32220
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(10);
            Console.WriteLine("Change to be submitted to Feature Branch 11:16am");
        }

        public static void PrintNumbers (int x)
        {
            for(int i = 1; i<= x; i++)
            {
                Console.Write(i);
            }
        }
    }
}
