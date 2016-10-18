using System;

namespace _01.OddOrEven
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            if (input % 2 ==0)
            {
                Console.WriteLine("even " + input);
            }
            else
            {
                Console.WriteLine("odd " + input);
            }
        }
    }
}
