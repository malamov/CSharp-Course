﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class PrintFirstAndLastName
{
    static void Main(string[] args)
    {
        Console.Title = "Print First and Last Name";


        bool check = true;
        string firstName;
        string lastName;
        bool isDigitInName = true;

        do                                                                 
        {                                                                                  
            Console.WriteLine("\nEnter your first name: ");
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

        do                                                                
        {                                                                 
            Console.WriteLine("\nEnter your last name: ");
            lastName = Console.ReadLine();
            isDigitInName = lastName.Any(c => char.IsDigit(c));
            if (lastName.Length >= 2 & isDigitInName == false)
            {
                check = true;
            }
            else
            {
                check = false;
            }
        } while (!check);

        TextInfo myTI = CultureInfo.CurrentCulture.TextInfo;
        Console.WriteLine("\nYour first name is: {0}\nYour last name is: {1}\n", myTI.ToTitleCase(firstName), myTI.ToTitleCase(lastName)); 
    }
}
