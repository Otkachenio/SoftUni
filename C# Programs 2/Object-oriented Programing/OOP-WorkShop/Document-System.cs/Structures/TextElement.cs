namespace Document_System.Structures
{
    using System.IO;

    using Document_System.Utils;

    public class TextElement : Element
    {
        public string Text { get; set; }
        public Font Font { get; set; }

        public TextElement(string text, Font font = null)
        {
            this.Text = text;
            this.Font = font;
        }

        public override void RenderHtml(TextWriter writer)
        {
            if (this.Font != null)
            {
                writer.Write("<span style='");
                this.Font.RenderHtml(writer);
                writer.Write("'>");
            }
            writer.Write(this.Text.HtmlEncode());
            if (this.Font != null)
            {
                writer.Write("</span>");
            }
        }

        public override void RenderText(TextWriter writer)
        {
            writer.Write(this.Text);
        }
    }
}