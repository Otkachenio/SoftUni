namespace RPG.Characters
{
    using RPG.Weapons;

    public abstract class Character
    {
        private Weapon weapon;

        public Character(Weapon weapon)
        {
            this.Weapon = weapon;
        }

        public Weapon Weapon
        {
            get { return this.weapon; }

            set  { this.weapon = value; }
        }

        public override string ToString()
        {
            string result = string.Format("{0} wilds weapon {1}",
                this.GetType().Name, this.Weapon);

            return result;
        }
    }
}