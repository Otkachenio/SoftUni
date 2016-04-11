namespace Problem2.StringDisperser
{
    using System;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        private StringBuilder fullString;

        public StringDisperser(params string[] strings)
        {
            this.FullString = new StringBuilder();
            foreach(var str in strings)
            {
                this.FullString.Append(str);
            }
        }

        public StringBuilder FullString
        {
            get { return this.fullString; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Value cannot be null!");
                }

                this.fullString = value;
            }
        }

        public object Clone()
        {
            StringDisperser newStrDisperser = new StringDisperser();
            newStrDisperser.FullString = new StringBuilder().Append(FullString.ToString());

            return newStrDisperser;
        }

        public int CompareTo(StringDisperser other)
        {
            return this.FullString.ToString().CompareTo(other.FullString.ToString());
        }

        public override bool Equals(object param)
        {
            StringDisperser strDisperser = param as StringDisperser;

            if (strDisperser == null)
            {
                return false;
            }
            if (!(strDisperser.FullString.ToString().Equals(this.FullString.ToString())))
            {
                return false;
            }

            return true;
        }

        public IEnumerator<char> GetEnumerator()
        {
            foreach (char ch in FullString.ToString())
            {
                yield return ch;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override int GetHashCode()
        {
            return FullString.GetHashCode();
        }

        public override string ToString()
        {
            return this.FullString.ToString();
        }

        public static bool operator == (
            StringDisperser firstStrDisperser, StringDisperser secondStrDisperser)
        {
            return firstStrDisperser.Equals(secondStrDisperser);
        }

        public static bool operator !=(
            StringDisperser firstStrDisperser, StringDisperser secondStrDisperser)
        {
            return !(firstStrDisperser.Equals(secondStrDisperser));
        }      
    }
}