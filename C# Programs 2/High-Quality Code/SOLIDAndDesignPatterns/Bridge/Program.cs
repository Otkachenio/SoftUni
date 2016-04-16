namespace RPG
{
    using System;

    using RPG.Characters;
    using RPG.Weapons;

    public class Program
    {
        static void Main()
        {
            Weapon sword = new Sword();
            Weapon axe = new Axe();

            Character swordMage = new Mage(sword);
            Character axeWarrior = new Warrior(axe);

            Console.WriteLine(axeWarrior);
            Console.WriteLine(swordMage);
        }
    }
}