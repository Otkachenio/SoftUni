namespace Problem3.GenericList
{
    using System;

    class Test
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();

            intList.Add(5);
            intList.Add(4);
            intList.Add(3);
            intList.Add(2);
            intList.Add(1);

            Console.WriteLine(intList);

            GenericList<string> stringList = new GenericList<string>();

            stringList.Add("Pesho");
            stringList.Add("Gosho");
            stringList.Add("Penka");
            stringList.Add("Ivan");
            stringList.Add("Gergana");         

            Console.WriteLine(stringList);

            intList.Remove(4);

            Console.WriteLine(intList);

            stringList.Insert("Nakov", 3);

            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }

            GenericList<long> clearTest = new GenericList<long>();

            clearTest.Add(5222);
            clearTest.Add(9999);
            clearTest.Add(5861);

            Console.WriteLine();
            Console.WriteLine("Clear list count before: {0}", clearTest.Count);
            clearTest.Clear();
            Console.WriteLine("Clear list count after: {0}", clearTest.Count);

            Console.WriteLine("Max int: {0}", intList.Max());
            Console.WriteLine("Min int: {0}", intList.Min());
        }
    }
}