namespace Document_System.Readerers
{
    using System.IO;

    public interface IHtmlRenderer
    {
        void RenderHtml(TextWriter writer);
    }
}