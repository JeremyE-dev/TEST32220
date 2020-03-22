using System;

namespace GHTEST32220
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(10);
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
