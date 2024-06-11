using System;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startRandomRange = 1;
            int endRandomRange = 100;
            int baseNumber = 2;
            int exponent = 2;
            int minExponent = 1;
            int resultingNumber = 0;

            Random random = new Random();
            int setNumber = random.Next(startRandomRange, endRandomRange);

            for (int i = baseNumber; i <= setNumber; i *= exponent)
            {
                minExponent++;
                resultingNumber = i * exponent;
            }

            Console.WriteLine($"Сгенерированное чмсло {setNumber}\nМинимальная степени двойки, согласно задания {minExponent}\nПолученное число {resultingNumber}");
            Console.ReadKey();
        }
    }
}
