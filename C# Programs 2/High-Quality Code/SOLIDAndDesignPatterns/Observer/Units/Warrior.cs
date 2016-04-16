namespace Skyrim.Units
{
    using System;
    using System.Collections.Generic;

    using Skyrim.Items;
    using Skyrim.Observers;

    public class Warrior : Unit, IDragonDeathObserver
    {
        public Warrior(string name, int attackPoints, int healthPoints) 
            : base(name, attackPoints, healthPoints)
        {
            this.Inventory = new List<Weapon>();
        }

        public IList<Weapon> Inventory { get; private set; }

        public void Update(Weapon weapon)
        {
            this.Inventory.Add(weapon);

            this.AttackPoints += weapon.AttackBonus;
            this.HealthPoints += weapon.HealthBonus;
        }

        public override string ToString()
        {           
            string result = string.Format("{0} - {1}: AP: {2} HP: {3}",
                this.GetType().Name, this.Name, this.AttackPoints, this.HealthPoints);

            return result;
        }
    }
}