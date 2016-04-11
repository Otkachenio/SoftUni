using System;

class Program
{
    static void Main()
    {
        string inputData = Console.ReadLine();
        string day;
        string phoneNumber;
        string braSize;
        string name;
        int daySum = 0;
        int phoneSum = 0;
        int braSizeSum = 0;
        int nameSum = 0;
        int finalSum = 0;
        int perfectGirls = 0;

        string[] daysOfWeeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday",
                                                    "Friday", "Saturday", "Sunday"};

        while (inputData != "Enough dates!")
        {
            string[] tokens = inputData.Split('\\');
            day = tokens[0];
            phoneNumber = tokens[1];
            braSize = tokens[2];
            name = tokens[3];

            for (int i = 0; i < daysOfWeeek.Length; i++)
            {
                if (daysOfWeeek[i] == day)
                {
                    daySum = i + 1;
                }
            }

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                phoneSum += (phoneNumber[i] - '0');
            }

            braSizeSum = int.Parse(braSize.Substring(0, braSize.Length - 1));
            braSizeSum *= braSize[braSize.Length - 1];

            nameSum = name[0];
            nameSum *= name.Length;

            finalSum = (daySum + phoneSum + braSizeSum) - nameSum;

            if (finalSum < 6000)
            {
                Console.WriteLine("Keep searching, {0} is not for you.", name);
            }
            else
            {
                Console.WriteLine("{0} is perfect for you.", name);
                perfectGirls++;
            }

            daySum = 0;
            phoneSum = 0;
            braSizeSum = 0;
            nameSum = 0;
            finalSum = 0;
            inputData = Console.ReadLine();
        }
        Console.WriteLine(perfectGirls);
    }
}