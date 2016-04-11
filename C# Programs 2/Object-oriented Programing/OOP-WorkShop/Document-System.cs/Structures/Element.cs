namespace Document_System.Structures
{
    using System.IO;

    using Document_System.Readerers;

    public abstract class Element : IHtmlRenderer, ITextRenderer
    {
        public abstract void RenderHtml(TextWriter writer);
        public abstract void RenderText(TextWriter writer);

        public Element Parent { get; set; }
        public string AsHtml
        {
            get
            {
                StringWriter writer = new StringWriter();
                this.RenderHtml(writer);
                return writer.ToString();
            }              
        }

        public string AsText
        {
            get
            {
                StringWriter writer = new StringWriter();
                this.RenderText(writer);
                return writer.ToString();
            }
        }

        public override string ToString()
        {
            return this.AsText;
        }
    }
}