namespace Document_System.Structures
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class CompositElement : Element
    {
        protected IList<Element> ChildElements { get; set; }

        public CompositElement()
        {
            this.ChildElements = new List<Element>();
        }

        public CompositElement(params Element[] elements)
            : this()
        {
            this.Add(elements);
        }

        public CompositElement Add(params Element[] elements)
        {
            foreach (var element in elements)
            {
                element.Parent = this;
                CheckForLoop(this, element);
                this.ChildElements.Add(element);
            }

            return this;
        }

        private void CheckForLoop(Element parent, Element child)
        {
            while (parent != null)
            {
                if (parent == child)
                {
                    throw new InvalidOperationException("Loop in the document structure are not alowed!");
                }
                parent = parent.Parent;
            }
        }

        public override void RenderHtml(TextWriter writer)
        {
            foreach (var element in this.ChildElements)
            {
                element.RenderHtml(writer);
            }
        }

        public override void RenderText(TextWriter writer)
        {
            foreach (var element in this.ChildElements)
            {
                element.RenderText(writer);
            }
        }
    }
}