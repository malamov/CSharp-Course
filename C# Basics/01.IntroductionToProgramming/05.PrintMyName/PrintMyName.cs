using System;
using System.Linq;
using System.Globalization;

class PrintMyName
{
    static void Main()
    {
        Console.Title = "Print Name";
        
        bool check = true;
        string firstName;
        bool isDigitInName = true;

        do                                                                 
        {                                                                                      
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            isDigitInName = firstName.Any(c => char.IsDigit(c));
            if (firstName.Length >= 2 & isDigitInName == false)
            {
                check = true;
            }
            else
            {
                check = false;
            }
        } while (!check);

        TextInfo myTI = CultureInfo.CurrentCulture.TextInfo;
        Console.WriteLine("\nYour name is: {0} (Nickname: The Ninja Warrior)\n", myTI.ToTitleCase(firstName)); 
    }
}
