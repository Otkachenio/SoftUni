namespace Document_System.Readerers
{
    using System.IO;

    public interface IMSWordRenderer
    {
        void RenderMsWord(Stream stream);
    }
}