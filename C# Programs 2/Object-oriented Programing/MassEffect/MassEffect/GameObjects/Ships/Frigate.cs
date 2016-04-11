namespace MassEffect.GameObjects.Ships
{
    using System.Text;

    using MassEffect.GameObjects.Locations;
    using Interfaces;
    using MassEffect.GameObjects.Projectiles;
    using System;

    public class Frigate : Starship
    {
        private const int FrigateHealth = 60;
        private const int FrigateShields = 50;
        private const int FrigateDamage = 30;
        private const double FrigateFuel = 220;

        private int projectilesFired;

        public Frigate(string name, StarSystem location) 
            : base(name, FrigateHealth, FrigateShields, FrigateDamage, FrigateFuel, location)
        {
            this.projectilesFired = 0;           
        }
       
        public override IProjectile ProduceAttack()
        {
            this.projectilesFired++;

            return new ShieldReaver(this.Damage);
        }

        public override string ToString()
        {
            string output = base.ToString();
            if (this.Health > 0)
            {
                output += string.Format("{1}-Projectiles fired: {0}", this.projectilesFired, Environment.NewLine);
            }

            return output;
        }
    }
}