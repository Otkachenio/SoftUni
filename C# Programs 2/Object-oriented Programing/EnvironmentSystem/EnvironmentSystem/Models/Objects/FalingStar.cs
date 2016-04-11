namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;

    public class FalingStar : MovingObject
    {
        private const char DefaultFallingStarChar = 'O';

        public FalingStar(int x, int y, Point direction) : base(x, y, 1, 1, direction)
        {
            this.ImageProfile = new char[,] { { DefaultFallingStarChar } };
            this.CollisionGroup = CollisionGroup.FallingStart;
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> producedObjects = new List<EnvironmentObject>();
            producedObjects.Add(new Tail(this.Bounds.TopLeft.X - this.Direction.X,
                this.Bounds.TopLeft.Y - this.Direction.Y));
            producedObjects.Add(new Tail(this.Bounds.TopLeft.X - 2 * this.Direction.X,
                this.Bounds.TopLeft.Y - 2 * this.Direction.Y));
            producedObjects.Add(new Tail(this.Bounds.TopLeft.X - 3 * this.Direction.X,
                this.Bounds.TopLeft.Y - 3 * this.Direction.Y));

            return producedObjects;
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObject = collisionInfo.HitObject.CollisionGroup;
            if (hitObject == CollisionGroup.Ground || hitObject == CollisionGroup.Explosion)
            {
                this.Exists = false;
            }
        }   
    }
}