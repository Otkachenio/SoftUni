using System;

/// <summary>
/// This program takes the average time you neeed to solve a sudoku game
/// by taking several of your times and gives you a star for your avarage time
/// deppending on best times value.
/// </summary>
public class SudokuResults
{
    /// <summary>
    /// Takes several of your times, calculates average time and rewards you with star.
    /// </summary>
    static void Main()
    {
        string inputTimeFromConsole = Console.ReadLine();

        double fullGameTime = 0;
        double NumberOfGames = 0;

        while (inputTimeFromConsole != "Quit")
        {
            string[] tokens = inputTimeFromConsole.Split(':');
            int minutes = int.Parse(tokens[0]);
            int seconds = int.Parse(tokens[1]);
            int timeInSec = (minutes * 60) + seconds;
            fullGameTime += timeInSec;

            NumberOfGames++;
            inputTimeFromConsole = Console.ReadLine();
        }

        double avarageTime = Math.Ceiling(fullGameTime / NumberOfGames);


        if (avarageTime < 720)
        {
            Console.WriteLine("Gold Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", NumberOfGames, avarageTime);
        }

        else if (avarageTime >= 720 && avarageTime <= 1440)
        {
            Console.WriteLine("Silver Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", NumberOfGames, avarageTime);
        }

        else
        {
            Console.WriteLine("Bronze Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", NumberOfGames, avarageTime);
        }
    }
}