namespace WebScraper
{
    using System.Collections.Generic;

    public class WebPageRepository
    {
        private static WebPageRepository repository;
        private Queue<string> addresses;
        private static object syncLock = new object();

        protected WebPageRepository()
        {
            this.addresses = new Queue<string>();
            this.Seed();
        }

        public bool IsEmpty
        {
            get
            {
                return this.addresses.Count == 0;
            }
        }

        public void Add(string address)
        {
            this.addresses.Enqueue(address);
        }

        public string Remove()
        {
            return this.addresses.Dequeue();
        }

        private void Seed()
        {
            this.addresses.Enqueue("https://softuni.bg/");
            this.addresses.Enqueue("http://stackoverflow.com/");
            this.addresses.Enqueue("https://www.youtube.com/");
            this.addresses.Enqueue("https://www.google.bg/");
        }

        public static WebPageRepository Instance
        {
            get
            {
                if (repository == null)
                {
                    lock (syncLock)
                    {
                        if (repository == null)
                        {
                            repository = new WebPageRepository();
                        }
                    }
                }

                return repository;
            }           
        }
    }
}