namespace Problem3.StudentClass
{
    using System;

    public class PropertyChangedEventArgs<T> : EventArgs
    {
        public PropertyChangedEventArgs(string propertyName, T oldValue, T newValue)
        {
            this.PropertyName = propertyName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; set; }
        public T OldValue { get; set; }
        public T NewValue { get; set; }
    }
}