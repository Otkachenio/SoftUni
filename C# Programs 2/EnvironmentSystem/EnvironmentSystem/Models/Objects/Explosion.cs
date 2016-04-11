namespace EnvironmentSystem.Models.Objects
{
    public class Explosion : Tail
    {
        public Explosion(int x, int y) : base(x, y, 2)
        {
            this.CollisionGroup = CollisionGroup.Explosion;
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObjectGroup = collisionInfo.HitObject.CollisionGroup;
            if (hitObjectGroup == CollisionGroup.FallingStart);
        }
    }
}