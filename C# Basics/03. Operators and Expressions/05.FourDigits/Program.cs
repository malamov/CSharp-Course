using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int fourthDigit = input % 10;
        input /= 10;
        int thirdDigit = input % 10;
        input /= 10;
        int secondDigit = input % 10;
        input /= 10;
        int firstDigit = input;

        int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine(sumOfDigits);

        Console.WriteLine(string.Format("{0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit));
        Console.WriteLine(string.Format("{0}{1}{2}{3}",fourthDigit,firstDigit,secondDigit,thirdDigit));
        Console.WriteLine(string.Format("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit));

    }
}

