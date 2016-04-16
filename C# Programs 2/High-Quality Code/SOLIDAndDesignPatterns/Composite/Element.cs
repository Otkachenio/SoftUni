namespace DOMBuilder
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;  

    public class Element
    {
        private int spaces;
        private string type;
        private readonly IList<Element> children;

        public Element(string element, params Element[] children)
        {
            this.children = children.Length > 0 ? children.ToList() : new List<Element>();
            this.type = element;
        }

        private int Spaces
        {
            get
            {
                return this.spaces;
            }

            set
            {
                this.spaces = value;
            }
        }

        public void Add (Element element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("You cannot add null element.");
            }

            this.children.Add(element);
        }

        public void Remove (Element element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("You cannot remove null element.");
            }

            this.children.Remove(element);
        }

        public string Display()
        {
            
            var displayResult = new StringBuilder();

            string openTag = string.Format("{0}<{1}>", new string(' ', spaces), this.type);
            displayResult.AppendLine(openTag);
            foreach (var child in this.children)
            {
                child.Spaces += spaces + 2;
                displayResult.Append(child.Display());           
            }
            string closeTag = string.Format("{0}</{1}>", new string(' ', spaces), this.type);
            displayResult.AppendLine(closeTag);

            return displayResult.ToString();
        }
    }
}