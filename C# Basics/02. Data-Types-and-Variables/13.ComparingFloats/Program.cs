using System;

class Program
{
    static void Main(string[] args)
    {
        var firstNumber = double.Parse(Console.ReadLine());
        var secondNumber = double.Parse(Console.ReadLine());

        int firstBigger = firstNumber.CompareTo(secondNumber);

        if (firstNumber < 0)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}

