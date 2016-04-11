namespace Document_System.Structures
{
    using System;

    [Flags]
    public enum FontStyle
    {
        Normal = 0,
        Bold = 1,
        Italic = 2,
        BoldItalic = Bold | Italic
    }
}