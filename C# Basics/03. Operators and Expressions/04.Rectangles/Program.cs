using System;

class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());

        var area = width * heigth;
        var parameter = (width + heigth) * 2;

        Console.WriteLine(String.Format("{0:F2} {1:F2}",area,parameter));
    }
}

