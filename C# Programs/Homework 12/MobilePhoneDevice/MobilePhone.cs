using System;

class MobilePhone
{
    static void Main()
    {
        GSM[] Phones = new GSM[3];
        string[] models = { "HTC", "Samsung", "LG", "Nokia", "KucheMobile" };
        int[] prices = { 200, 340, 700, 620, 1100 };
        string[] owners = { "Messi", "Ronaldo", "Berbatov", "Skartel", "Hulk" };
        string[] manifacturers = { "China", "USA", "Japan", "France", "UK" };

        for (int i = 0; i < Phones.Length; i++)
        {
            Phones[i] = new GSM(models[i], manifacturers[i], prices[i], owners[i]);
            Console.WriteLine(Phones[i]);
            Console.WriteLine("-----------");
        }
    }
}

