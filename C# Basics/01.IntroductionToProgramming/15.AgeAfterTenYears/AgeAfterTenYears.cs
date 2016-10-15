using System;

class Program
{
    static void Main(string[] args)
    {
        var Birthdate = DateTime.Parse(Console.ReadLine());
        var Today = DateTime.Now;

        int age = Today.Year - Birthdate.Year;
        if (Birthdate.Month > Today.Month)
        {
            if (Birthdate.Day > Today.Day)
            {
                age -= 1;
            }
        }

        int ageAfterTenYears = age + 10;

        Console.WriteLine(age);
        Console.WriteLine(ageAfterTenYears);

    }
}
