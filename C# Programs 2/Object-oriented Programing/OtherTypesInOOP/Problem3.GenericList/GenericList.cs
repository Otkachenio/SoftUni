namespace Problem3.GenericList
{
    using System;
    using System.Text;

    [Version(1, 0)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int count = 0;

        // Creating new GenericList from T.
        public GenericList(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }

        // Count of elements in the GenericList.
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        // Adding new item in the GenericList.
        // And using Resize method which doubles the size
        public void Add(T element)
        {
            if (count >= this.elements.Length)
            {
                Resize();
            }
            this.elements[this.count] = element;
            this.count++;
        }

        // Accessing item by index.
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", index));
                }

                T result = this.elements[index];
                return result;
            }
        }

        // Removing element at specific index.
        public void Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", index));
            }

            T[] temp = new T[count - 1];
            int counter = 0;
            for (int i = 0; i < count; i++)
            {
                if (i == index)
                {
                    continue;
                }

                temp[counter] = elements[i];
                counter++;
            }

            temp.CopyTo(elements, 0);
            count--;
        }


        // Inserting element at specific index.
        public void Insert(T item, int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", index));
            }

            T[] temp = new T[count + 1];
            int counter = 0;
            for (int i = 0; i <= count; i++)
            {
                if (i == index)
                {
                    temp[i] = item;
                    continue;
                }

                temp[i] = elements[counter];
                counter++;
            }

            elements = new T[elements.Length + 1];
            temp.CopyTo(elements, 0);
            count++;
        }

        // Clearing the GenericList.
        public void Clear()
        {
            this.elements = new T[0];
            count = 0;
        }

        // Returns the index of the specific element in the GenericList,
        // if the GenericList does not contain the element it returns (-1).
        public int Find(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        // Return the biggest value in the GenericList
        public T Max()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The Generic list is empty!");
            }

            T max = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }

        //Return the smallest value in the GenericList
        public T Min()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The Generic list is empty!");
            }

            T min = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }


        // Allows the GenericList to be printed by overriding it ToString
        public override string ToString()
        {
            StringBuilder listToPrint = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                listToPrint.AppendLine(elements[i].ToString());
            }

            return listToPrint.ToString();
        }

        // If the list is full this method creates new list with double length 
        // and copies all element in it.
        public void Resize()
        {
            T[] temp = new T[this.elements.Length];
            this.elements.CopyTo(temp, 0);

            this.elements = new T[this.elements.Length * 2];
            temp.CopyTo(elements, 0);
        }
    }
}