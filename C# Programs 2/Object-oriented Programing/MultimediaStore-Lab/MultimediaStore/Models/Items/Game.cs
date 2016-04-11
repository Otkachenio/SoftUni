namespace MultimediaStore.Models.Items
{
    using System;
    using System.Collections.Generic;

    public class Game : Item
    {
        private const AgeRestriction DefaultAgeRestriction = AgeRestriction.Minor;

        public Game(string id, string title, decimal price, IList<string> genres, 
            AgeRestriction ageRestriction = DefaultAgeRestriction) 
            : base(id, title, price, genres)
        {
            this.AgeRestriction = ageRestriction;
        }

        public Game(string id, string title, decimal price, string genre,
            AgeRestriction ageRestriction = DefaultAgeRestriction)
            : this(id, title, price, new List<string> { genre }, ageRestriction)
        {
        }

        public AgeRestriction AgeRestriction { get; private set; }

        public override string ToString()
        {
            string result = String.Format("Age restriction: {0}", this.AgeRestriction);

            return base.ToString() + result;
        }
    }
}