namespace Problem1.StringBuilderExtensions
{
    using System;
    using System.Text;

    class Test
    {
        static void Main(string[] args)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Who is Pesho The Pruch?");
            string test = strBuilder.Substring(7, 15);
            Console.WriteLine(test);

            strBuilder.RemoveText("Pesho");
            Console.WriteLine(strBuilder);

            int[] testArray = new int[] { 1, 3, 5, 7 };
            strBuilder.AppendAll(testArray);
            Console.WriteLine(strBuilder);

            string[] testArrayStr = new string[] { "test", "asd", "qaz" };
            strBuilder.AppendAll(testArrayStr);
            Console.WriteLine(strBuilder);
        }
    }
}