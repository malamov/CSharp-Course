using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        input /= 100;
        int lastNum = input % 10;

        if (lastNum == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " + lastNum);
        }
    }
}

