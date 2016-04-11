using System;

class GenerCheck
{
    static void Main()
    {
        Console.WriteLine("This program checks whether your gender is female or male");
        Console.Write("Enter your gender [male/female]: ");
        string gender = Console.ReadLine();
        bool isFemale = gender.Equals("female", StringComparison.OrdinalIgnoreCase);
        bool isMale = gender.Equals("male", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(isFemale ? "Yes, you are female" : isMale ? "No, you are male" : "Incorrect input data!");
    }
}