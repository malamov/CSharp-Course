﻿using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double DISTANCE = Math.Sqrt(x * x + y * y);

        if (x * x + y * y <= 4)
        {
            Console.WriteLine("yes {0:F2}", DISTANCE);
        }
        else
        {
            Console.WriteLine("no {0:F2}", DISTANCE);
        }
    }
}
