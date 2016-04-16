namespace Skyrim.Units
{
    using System.Collections.Generic;

    using Skyrim.Items;

    public class Dragon : Unit
    {
        private IList<Warrior> listeners;

        public Dragon(string name, int attackPoints, int healthPoints) 
            : base(name, attackPoints, healthPoints)
        {
            listeners = new List<Warrior>();
        }

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }

            set
            {
                if (value <= 0)
                {
                    this.Notify();
                }

                base.HealthPoints = value;
            }
        }

        public void Attach(Warrior unit)
        {
            this.listeners.Add(unit);
        }

        public void Detach(Warrior unit)
        {
            this.listeners.Remove(unit);
        }

        public void Notify()
        {
            foreach (var listener in this.listeners)
            {
                listener.Update(new Weapon(10, 10));
            }
        }
    }
}