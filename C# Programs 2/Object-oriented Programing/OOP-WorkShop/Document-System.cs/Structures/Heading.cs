namespace Document_System.Structures
{
    using System;
    using System.IO;

    using Document_System.Utils;

    public class Heading : Element
    {
        public string Text { get; set; }
        private int size;

        public Heading(string text, int size = 1)
        {

            this.Size = size;
            this.Text = text;
        }

        public int Size
        {
            get { return this.size; }

            set
            {
                if (value <= 0 || value > 6)
                {
                    throw new ArgumentOutOfRangeException(
                        "The heading size should be in range from 1 to 6");
                }

                this.size = value;
            }
        }

        public override void RenderHtml(TextWriter writer)
        {
            writer.Write("<h{0}>{1}</h{0}>", this.Size, this.Text.HtmlEncode());
        }

        public override void RenderText(TextWriter writer)
        {
            writer.WriteLine();
            writer.WriteLine(this.Text.ToUpper());
        }
    }
}