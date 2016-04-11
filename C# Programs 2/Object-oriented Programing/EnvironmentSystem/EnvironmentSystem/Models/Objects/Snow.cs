namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;

    public class Snow : EnvironmentObject
    {
        private const char SnowImageChar = '~';

        public Snow(int x, int y) : base(x, y, 1, 1)
        {
            this.CollisionGroup = CollisionGroup.Snow;
            this.ImageProfile = new char[,] { { SnowImageChar } };
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
        }
    }
}