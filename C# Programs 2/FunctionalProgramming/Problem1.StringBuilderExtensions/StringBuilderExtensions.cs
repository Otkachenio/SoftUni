namespace Problem1.StringBuilderExtensions
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder strBuilder, int startIndex, int length)
        {
            string result;

            try
            {
                result = strBuilder.ToString().Substring(startIndex, length);
            }
            catch (Exception ex)
            {
                throw new IndexOutOfRangeException("ERROR: Index out of range:" + "\r\n" + ex);
            }
            
            return result;
        }

        public static StringBuilder RemoveText(this StringBuilder strBuilder, string text)
        {
            int startIndex = strBuilder.ToString()
                .IndexOf(text, StringComparison.OrdinalIgnoreCase);

            if (startIndex < 0)
            {
                throw new ArgumentException(
                    "The StringBuilder does not contains the text you are trying to remove!");
            }

            int length = text.Length;

            string result = strBuilder.ToString().Remove(startIndex, length);

            strBuilder.Clear();
            strBuilder.Append(result);

            return strBuilder;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder strBuilder, IEnumerable<T> items)
        {
            string result = "";

            try
            {
                foreach (var item in items)
                {
                    result += item.ToString() + " ";
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(
                    "ERROR: Converting to string not possible." + "/r/n" + ex);
            }

            return strBuilder.Append(" " + result);
        }
    }
}