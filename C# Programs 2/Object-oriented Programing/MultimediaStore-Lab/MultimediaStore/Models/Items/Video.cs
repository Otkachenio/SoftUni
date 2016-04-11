namespace MultimediaStore.Models.Items
{
    using System.Collections.Generic;

    public class Video: Item
    {
        public Video(string id, string title, decimal price, int length, IList<string> genres)
            : base(id, title, price, genres)
        {
            this.Length = length;
        }

        public Video(string id, string title, decimal price, int length, string genre)
            : this(id, title, price, length, new List<string> { genre })
        {
        }

        public int Length { get; private set; }

        public override string ToString()
        {
            string result = string.Format("Length: {0}", this.Length);

            return base.ToString() + result;
        }
    }
}