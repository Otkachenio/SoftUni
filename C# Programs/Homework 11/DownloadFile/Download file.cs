using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please, enter the full direcotry of the file you want to donwload");
        Console.Write(": ");
        string remoteUri = Console.ReadLine();
        Console.WriteLine("Please, enter the directory name and file name you want for your file");
        Console.Write("(Drive:Directory\\FileName.extension): ");
        string fileName = Console.ReadLine();
        WebClient myWebClient = new WebClient();

        try
        {
            myWebClient.DownloadFile(remoteUri, fileName);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("ERROR: Null Address");
        }
        catch (WebException ex)
        {
            Console.WriteLine("ERROR: Unauthoraized Access, Bad URI, Filename = null or The file doesn't exist");
            Console.WriteLine(ex);
        }

    }
}

