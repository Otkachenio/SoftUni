namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;

    public class Tail : EnvironmentObject
    {
        private const char DefaultTailChar = '*';

        private int lifeTime;

        public Tail(int x, int y, int lifeTime = 1) : base (x, y, 1, 1)
        {
            this.ImageProfile = new char[,] { { DefaultTailChar } };
            this.lifeTime = lifeTime;
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
        }

        public override void Update()
        {
            this.lifeTime--;
            if (lifeTime <= 0)
            {
                this.Exists = false;
            }
        }
    }
}