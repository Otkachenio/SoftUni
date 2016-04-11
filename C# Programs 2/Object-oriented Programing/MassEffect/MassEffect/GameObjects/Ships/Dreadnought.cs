namespace MassEffect.GameObjects.Ships
{
    using System;
    using MassEffect.GameObjects.Locations;
    using MassEffect.GameObjects.Projectiles;
    using Interfaces;

    public class Dreadnought : Starship
    {
        private const int DreadnoughtHealth = 200;
        private const int DreadnoughtShields = 300;
        private const int DreadnoughtDamage = 150;
        private const double DreadnoughtFuel = 700;

        public Dreadnought(string name, StarSystem location)
            : base(name, DreadnoughtHealth, DreadnoughtShields, DreadnoughtDamage,
                                                            DreadnoughtFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            int fullDamage = (this.Shields / 2) + this.Damage;

            return new Laser(fullDamage);
        }

        public override void RespondToAttack(IProjectile projectile)
        {
            this.Shields += 50;

            base.RespondToAttack(projectile);

            this.Shields -= 50;
        }
    }
}