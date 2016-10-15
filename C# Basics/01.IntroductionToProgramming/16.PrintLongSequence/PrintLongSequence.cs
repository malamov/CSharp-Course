using System;

class Program
{
    static void Main()
    {
        for (int i = 2; i <= 1000; i += 2)
        {
            Console.WriteLine(i);
            Console.WriteLine(-i - 1);
        }
    }
}
