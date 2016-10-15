using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 33; i <= 126; i++)
        {
            var asciTableChar = (char)(i);
            Console.Write(asciTableChar);
        }
    }
}

