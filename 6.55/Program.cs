using System;

namespace _6._55
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int c = 0;
            while (a > 0)
            {
                c *= 10;
                c = c + a % 10;
                a /= 10;
            }
            if (c == b)
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");
        }
    }
}
