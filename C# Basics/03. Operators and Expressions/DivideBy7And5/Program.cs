using System;

namespace DivideBy7And5
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            bool canBeDividedBy7And5 = false;

            if (input % 7 == 0 && input % 5 == 0)
            {
                canBeDividedBy7And5 = true;
            }
            if (canBeDividedBy7And5)
            {
                Console.WriteLine("true " + input);
            }
            else
            {
                Console.WriteLine("false " + input);
            }
        }
    }
}
