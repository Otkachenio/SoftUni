namespace MassEffect.GameObjects.Projectiles
{
    using MassEffect.Interfaces;

    public class Laser : Projectile
    {
        public Laser(int damage) : base(damage)
        {
        }

        public override void Hit(IStarship targetShip)
        {
            targetShip.Shields -= this.Damage;
            int remnantDamage = this.Damage = targetShip.Shields;

            if (remnantDamage > 0)
            {
                targetShip.Health -= remnantDamage;
            }
        }
    }
}