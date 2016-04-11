namespace Document_System.Readerers
{
    using System.IO;

    public interface ITextRenderer
    {
        void RenderText(TextWriter writer);
    }
}