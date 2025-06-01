using System;
using System.Collections.Generic;

namespace HappyNumberConsole
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                bool isHappy = IsHappyNumber(n);
                Console.WriteLine(isHappy ? "Day la so may man." : "Day khong phai so may man.");
            }
            else
            {
                Console.WriteLine("Input khong hop le.");
            }
        }

        public static bool IsHappyNumber(int number)
        {
            var seen = new HashSet<int>();
            while (number != 1 && !seen.Contains(number))
            {
                seen.Add(number);
                number = SumOfSquares(number);
            }
            return number == 1;
        }

        private static int SumOfSquares(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            return sum;
        }
    }
}
