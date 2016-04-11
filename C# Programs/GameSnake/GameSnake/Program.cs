using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

struct Position
{
    public int row;
    public int col;

    public Position(int row, int col)
    {
        this.row = row;
        this.col = col;
    }
}

class Program
{
    static void Main(string[] args)
    {
        byte right = 0;
        byte left = 1;
        byte down = 2;
        byte up = 3;
        Position[] directions = new Position[]
        {
            new Position(0, 1), // right 
            new Position(0, -1), // left
            new Position(1, 0), // down
            new Position(-1, 0) // up 
        };
        int sleepTime = 100;
        int direction = right;
        int lastFoodTime = 0;
        int foodDissaprearTime = 10000;
        double negativePoints = 0;
        Console.BufferHeight = Console.WindowHeight;
        Random randomNumbersGenerator = new Random();
        Position food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
            randomNumbersGenerator.Next(0, Console.WindowWidth));
        lastFoodTime = Environment.TickCount;
        Console.SetCursorPosition(food.col, food.row);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("@");

        Queue<Position> snakeElements = new Queue<Position>();

        for (int i = 0; i <= 5; i++)
        {
            snakeElements.Enqueue(new Position(0, i));
        }

        foreach (Position position in snakeElements)
        {
            Console.SetCursorPosition(position.col, position.row);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("*");
        }

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.RightArrow && direction != left) 
                {
                    direction = right;
                }
                else if (userInput.Key == ConsoleKey.LeftArrow && direction != right)
                {
                    direction = left;
                }
                else if (userInput.Key == ConsoleKey.DownArrow && direction != up)
                {
                    direction = down;
                }
                else if (userInput.Key == ConsoleKey.UpArrow && direction != down)
                {
                    direction = up;
                }
            }

            Position snakeHead = snakeElements.Last();
            Position nextDirection = directions[direction];
            Position snakeNewHead = new Position(snakeHead.row + nextDirection.row,
                snakeHead.col + nextDirection.col);
            if (snakeNewHead.col < 0) snakeNewHead.col = Console.WindowWidth - 1;
            if (snakeNewHead.col == Console.WindowWidth) snakeNewHead.col = 0;
            if (snakeNewHead.row < 0) snakeNewHead.row = Console.WindowHeight - 1;
            if (snakeNewHead.row == Console.WindowHeight) snakeNewHead.row = 0;
            
            if (snakeElements.Contains(snakeNewHead))
            {
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{-GAME OVER-}");
                int userPoints = (snakeElements.Count - 6) * 100 - (int)negativePoints;
                userPoints = Math.Max(userPoints, 0);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Your points are: {0}", userPoints);
                return;
            }

            Console.SetCursorPosition(snakeHead.col, snakeHead.row);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("*");

            snakeElements.Enqueue(snakeNewHead);
            Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);

            Console.ForegroundColor = ConsoleColor.Green;
            if (direction == right) Console.Write(">");
            if (direction == left) Console.Write("<");
            if (direction == down) Console.Write("v");
            if (direction == up) Console.Write("^");

            if (snakeNewHead.col == food.col && snakeNewHead.row == food.row) // Creating new food
            {
                do  
                {
                    food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                        randomNumbersGenerator.Next(0, Console.WindowWidth)); 
                }
                while (snakeElements.Contains(food));
                lastFoodTime = Environment.TickCount;

                if (sleepTime > 25) sleepTime--;
                
                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@"); 
            }
            else // Moving...
            {   
                Position lastElement = snakeElements.Dequeue();
                Console.SetCursorPosition(lastElement.col, lastElement.row);
                Console.Write(" ");
            }

            if ((Environment.TickCount - lastFoodTime) >= foodDissaprearTime)
            {
                Console.SetCursorPosition(food.col, food.row);
                Console.Write(" ");
                do
                {
                    food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                        randomNumbersGenerator.Next(0, Console.WindowWidth));
                }
                while (snakeElements.Contains(food));
                lastFoodTime = Environment.TickCount;

                negativePoints += 50;
                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@");
            }

            Thread.Sleep(sleepTime);
            negativePoints += 0.1;
        }

        Console.ReadLine();
    }
}