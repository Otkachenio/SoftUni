namespace RPG.Weapons
{
    public abstract class Weapon
    {
        public Weapon()
        {
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}