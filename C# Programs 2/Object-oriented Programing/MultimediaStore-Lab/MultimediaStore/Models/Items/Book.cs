namespace MultimediaStore.Models.Items
{
    using System;
    using System.Collections.Generic;

    public class Book : Item
    {
        private string author;

        public Book(string id, string title, decimal price, string author, IList<string> genres)
            : base (id, title, price, genres)
        {
            this.Author = author;
        }

        public Book(string id, string title, decimal price, string genre, string author)
            : this(id, title, price, author, new List<string> { genre })
        {
        }

        public string Author
        {
            get { return this.author; }

            set
            {
                if (value.Trim().Length < 3)
                {
                    throw new ArgumentException(
                        "The author's name must be at least 3 chars long!");
                }

                this.author = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("Author: {0}", this.Author);

            return base.ToString() + result;
        }
    }
}