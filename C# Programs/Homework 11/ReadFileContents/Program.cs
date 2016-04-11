using System;
using System.Text;
using System.IO;

namespace ReadFileContents
{
    class Program
    {
        static void Main()
        {
            {
                Console.Write("Please, enter the full path to the file: ");
                string path = Console.ReadLine();
                try
                {
                    string readText = File.ReadAllText(path);
                    Console.WriteLine(readText);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("ERROR: Invalid path entered!");
                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("ERROR: The path to the file is to long!");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("ERROR: The specified path is invalid (posible unmapped drive)!");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("ERROR: (Read only file), (path specified directory) or" +
                        " (don't have permission to this file)!");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("ERROR: Path is not in a valid format!");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("ERROR: File not found!");
                } 
            }
        }
    }
}
