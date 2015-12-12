namespace _04.StudentClass
{
    using System;

    public class PropertyChangedEventArgs
    {
        public PropertyChangedEventArgs(string propertyName, string oldValue, string newValue)
        {
            this.PropertyName = propertyName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; private set; }

        public string OldValue { get; private set; }

        public string NewValue { get; private set; }
    }
}
