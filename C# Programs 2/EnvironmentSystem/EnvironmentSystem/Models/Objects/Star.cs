namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;

    public class Star : EnvironmentObject
    {
        private const char DefaultStarImageChar = 'O';
        public const int StarUpdateFrequency = 10;

        private static readonly Random randomizer = new Random();
        private static char[] starsImageChars = new char[] { 'O', '0', '@' };
        private int updateCount = 0;

        public Star(int x, int y) : base(x, y, 1, 1)
        {
            this.ImageProfile = new char[,] { { DefaultStarImageChar } };
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObject = collisionInfo.HitObject;
            if (hitObject is Explosion)
            {
                Exists = false;
            }
        }

        public override void Update()
        {
            updateCount++;
            if (this.updateCount == StarUpdateFrequency)
            {
                int index = randomizer.Next(0, starsImageChars.Length);
                this.ImageProfile = new char[,] { { starsImageChars[index] } };
                this.updateCount = 0;
            }
        }
    }
}