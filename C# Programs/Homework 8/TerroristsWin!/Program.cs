using System;
using System.Collections.Generic;
using System.Linq;

class TerroristsWin
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = string.Empty;

        Dictionary<int, int> bombLocationsAndSize = new Dictionary<int, int>();
        Dictionary<int, int> bombImpactSize = new Dictionary<int, int>();

        findBombs(input, ref bombLocationsAndSize);
        calculateExplosionImpact(bombLocationsAndSize, input, ref bombImpactSize);
        result = detonateBombs(input, bombImpactSize);

        Console.WriteLine(result);
    }

    private static string detonateBombs(string input, Dictionary<int, int> bombImpactSize)
    {
        char[] result = input.ToCharArray();

        foreach (var explosion in bombImpactSize)
        {
            for (int i = explosion.Key; i <= explosion.Value; i++)
            {
                result[i] = '.';
            }
        }

        return new string(result);
    }
    
    private static void calculateExplosionImpact(Dictionary<int, int> bombLocationsAndSize, string input, ref Dictionary<int, int> bombImpactSize)
    {
        int power = 0;

        foreach (var location in bombLocationsAndSize)
        {
            power = calculatePower(input.Skip(location.Key + 1).Take(location.Value - (location.Key + 1)));

            bombImpactSize.Add(Math.Max(0, location.Key - power),
                Math.Min(input.Length - 1, location.Value + power));
        }
    }

    private static int calculatePower(IEnumerable<char> enumerable)
    {
        int power = 0;

        foreach (var letter in enumerable)
        {
            power += letter;
        }
        return power % 10;
    }

    private static void findBombs(string text, ref Dictionary<int, int> bombLocationAndSize)
    {
        int position = 0;
        int size = 0;
        for (int bombStart = 0; bombStart < text.Length; bombStart++)
        {
            if (text[bombStart].Equals('|'))
            {
                position = bombStart;

                for (int bobmEnd = bombStart + 1; bobmEnd < text.Length; bobmEnd++)
                {
                    if (text[bobmEnd].Equals('|'))
                    {
                        size = bobmEnd;
                        bombStart = bobmEnd + 1;
                        bombLocationAndSize.Add(position, size);
                        break;
                    }
                }

            }
        }
    }
}