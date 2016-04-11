namespace MultimediaStore.Models.Items
{
    using System;
    using System.Collections.Generic;
    using MultimediaStore.Interfaces;
    using System.Text;

    public abstract class Item : IItem
    {
        private string id;
        private string title;
        private decimal price;

        public Item(string id, string title, decimal price, IList<string> genres)
        {
            this.Id = id;
            this.Title = title;
            this.Price = price;
            this.Genres = genres;
        }

        protected Item(string id, string title, decimal price)
            : this(id, title, price, new List<string>())
        {
        }

        public string Id
        {
            get { return this.id; }

            set
            {
                if (value.Trim().Length < 4)
                {
                    throw new ArgumentException("ID must be at least 4 character long!");
                }

                this.id = value;
            }
        }

        public string Title
        {
            get { return this.title; }

            set
            {
                if (String.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentException("Title cannot be null or empty!");
                }

                this.title = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative number!");
                }

                this.price = value;
            }
        }

        public IList<string> Genres { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(String.Format("{0} {1}", this.GetType().Name, this.Id));
            result.AppendLine(String.Format("Title: {0}", this.Title));
            result.AppendLine(String.Format("Price: {0}", this.Price));
            result.AppendLine(String.Format("Genres: {0}", string.Join(", ", this.Genres)));

            return result.ToString();
        }
    }
}