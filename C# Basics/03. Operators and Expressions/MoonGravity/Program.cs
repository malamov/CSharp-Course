using System;

namespace MoonGravity
{
    class Program
    {
        static void Main()
        {
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = 0.17 * weightOnEarth;
            Console.WriteLine(String.Format("{0:F3}", weightOnMoon));

        }
    }
}
