namespace _04.StudentClass
{
    using System;

    public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs eventArgs);

    public class Student
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Name must have at least 3 characters");
                }

                this.OnPropertChanged("Name", this.name, value);

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than 0");
                }

                this.OnPropertChanged("Age", this.age.ToString(), value.ToString());

                this.age = value;
            }
        }

        private void OnPropertChanged(string propertyName, string oldValue, string newValue)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName, oldValue, newValue));
            }
        }
    }
}
