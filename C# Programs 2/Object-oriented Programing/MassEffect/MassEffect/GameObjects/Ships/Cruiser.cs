namespace MassEffect.GameObjects.Ships
{
    using System;

    using MassEffect.GameObjects.Locations;
    using MassEffect.Interfaces;
    using MassEffect.GameObjects.Projectiles;

    public class Cruiser : Starship
    {
        private const int CruiserHealth = 100;
        private const int CruiserShields = 100;
        private const int CruiserDamage = 50;
        private const double CruiserFuel = 300;
       
        public Cruiser(string name, StarSystem location)
            : base(name, CruiserHealth, CruiserShields, CruiserDamage, CruiserFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new PenetrationShell(this.Damage);
        }
    }
}