using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double a = 0, b = 0, c = 0;
        double h = 0, C = 0;
        double S = 0, P = 0;
        string[] input = Console.ReadLine().Split(',');
        string[] letterAndValue = new string[input.Length * 2];
        string[] letter = new string[input.Length];
        double[] value = new double[input.Length];
        
        for (int i = 0; i < input.Length; i++)
        {
            letterAndValue = input[i].Split('=').Select(space => space.Trim()).ToArray();
            letter[i] = letterAndValue[0];
            value[i] = double.Parse(letterAndValue[1]);
        }

        if (letter[0] == "a" && letter[1] == "h")
        {
            a = value[0];
            h = value[1];
            Console.WriteLine("The surface of your triangle is: {0:F2}", sideAndAtitude(a, h, S));
        }
        else if (letter[0] == "a" && letter[1] == "b" && letter[2] == "c")
        {
            a = value[0];
            b = value[1];
            c = value[2];
            Console.WriteLine("The surface of your triangle is: {0:F2}", threeSides(a, b, c, S, P));
        }
        else if (letter[0] == "a" && letter[1] == "b" && letter[2] == "C")
        {
            a = value[0];
            b = value[1];
            C = value[2];
            C = (C * Math.PI / 180);
            P = Math.Sin(C);
            Console.WriteLine("The surface of your triangle is: {0:F2}", twoSidesAndAngle(a, b, S, P));
        }
    }
    private static double sideAndAtitude(double a, double h, double S)
    {
        S = (a * h) / 2;
        return S;
    }
    
    private static double threeSides(double a, double b, double c, double S, double P)
    {
        P = (a + b + c) / 2;
        S = Math.Sqrt(P * (((P - a) * (P - b)) * (P - c)));
        return S;
    }  

    private static double twoSidesAndAngle(double a, double b, double S, double P)
    {
        S = ((a * b) / 2) * P;
        return S;
    }
}

