using System;

class Program
{
    static void Main()
    {
        var input = int.Parse(Console.ReadLine());
        //if (input == 1) return false;
        //if (input == 2) return true;

        //if (input % 2 == 0) return false; //Even number     

        for (int i = 3; i < input; i += 2)
        {
            if (input % i == 0) Console.WriteLine("true");           
        }

    }
   
}

