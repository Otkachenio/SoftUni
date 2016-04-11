using System;
using System.IO;

using Document_System.Structures;

public class Program
{
    static void Main()
    {
        Document doc = new Document();
        doc.Title = "My First Document";
        doc.Author = "Aleksandrov";
        doc.Add(new Paragraph("I am a paragraph"));
        doc.Add(new Hyperlink("https://www.google.bg/")
            .Add(Image.CreateFromFile("../../logo.png")));
        doc.Add(new Paragraph("I am another paragraph"));
        doc.Add(new Heading("The heading"));
        Paragraph paragraph = new Paragraph();
        paragraph.Add(new TextElement("Default Font, ", Font.DefaultFont));
        paragraph.Add(new TextElement("Second Red, ", new Font(color: Color.Red)));
        paragraph.Add(new TextElement("Green Italic, ", 
            new Font(color: Color.Green, style: FontStyle.Italic)));
        paragraph.Add(new Paragraph());
        paragraph.Add(new TextElement("Consolas Bold Blue Italic ",
            new Font(
                color: Color.Blue,
                style: FontStyle.BoldItalic,
                name: "Consolas")));

        doc.Add(new Heading("Picture: ", 2));

        paragraph.Add(new TextElement("Green Italic, ",
            new Font(color: Color.Green, style: FontStyle.Italic)));
        paragraph.Add(new Paragraph());
        paragraph.Add(new TextElement("Consolas Bold Blue Italic ",
            new Font(
                color: Color.Blue,
                style: FontStyle.BoldItalic,
                name: "Consolas")));

        doc.Add(paragraph);
            
        File.WriteAllText("document.xtml", doc.AsHtml);
        File.WriteAllText("document.text", doc.AsText);

        Console.WriteLine(doc.AsText);
    }
}