using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People
{
    public abstract class Person : IPerson
    {
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int ID { get; private set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("First name cannot be null");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last name cannot be null");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}\nLast Name: {1}\nID: {2}",
                this.FirstName, this.LastName, this.ID);
        }
    }
}

