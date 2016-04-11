using System;

class Program
{
    static void Main()
    {
        char[][] board = new char[4][];

        for (int elements = 0; elements < 4; elements++)
        {
            board[elements] = Console.ReadLine().ToCharArray();
        }

        int[] playerPosition = { 0, 0 };
        string moves = Console.ReadLine();
        int coinsCollected = 0;
        int wallsHit = 0;
        
        foreach (char move in moves)
        {
            playerPosition = getMove(move, playerPosition, board, ref wallsHit);
            board = checkForCoins(playerPosition, board, ref coinsCollected);
        }

        Console.WriteLine("Coins collected: " + coinsCollected);
        Console.WriteLine("Walls hit: " + wallsHit);
    }

    private static char[][] checkForCoins(int[] playerPosition, char[][] board, ref int coinsCollected)
    {
      if (board[playerPosition[0]][playerPosition[1]] == '$')
        {
            coinsCollected++;
            board[playerPosition[0]][playerPosition[1]] = ' ';
            return board;
        }
        else
        {
            return board;
        }
    }

    private static int[] getMove(char move, int[] playerPosition, char[][] board, ref int wallsHit)
    {
        switch (move)
        {
            case '<':
                playerPosition[1]--;
                if (playerOutsideOfBoard(playerPosition, board))
                {
                    wallsHit++;
                    playerPosition[1]++;
                }
                break;

            case '>':
                playerPosition[1]++;
                if (playerOutsideOfBoard(playerPosition, board))
                {
                    wallsHit++;
                    playerPosition[1]--;
                }
                break;

            case '^':
                playerPosition[0]--;
                if (playerOutsideOfBoard(playerPosition, board))
                {
                    wallsHit++;
                    playerPosition[0]++;
                }
                break;

            case 'V':
                playerPosition[0]++;
                if (playerOutsideOfBoard(playerPosition, board))
                {
                    wallsHit++;
                    playerPosition[0]--;
                }
                break;

            default:
                break;
        }

        return playerPosition;
    }

    private static bool playerOutsideOfBoard(int[] playerPosition, char[][] board)
    {
        try
        {
            char temp = board[playerPosition[0]][playerPosition[1]];
            return false;
        }
        catch (Exception)
        {
            return true;
        }
    }
}

