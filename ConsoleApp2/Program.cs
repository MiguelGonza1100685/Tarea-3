using System;

namespace ConsoleApp2
{
    class Program
    {
   

        static void Main(string[] args)
        {

            Console.WriteLine(Issodd(5).ToString());
            Console.WriteLine(isNegative(2).ToString());
            Console.WriteLine(abs(1).ToString());


        }

        private static int abs(int x)
        {
            
            {
                int m = x >> 20;
                x = x ^ m;
                x = x - m;
                return x;
            }
        }

        private static int isNegative(int x)
        {
            
            {
                const int m = 0x00000001;
                x = x >> 31;
                x = x & m;
                return x;
            }
        }

        private static long Issodd(long x)
        {

            const int m = 0x00000001;
            x = x & m;
            return x;


        }
    }
}
