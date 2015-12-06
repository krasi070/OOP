namespace _03.GenericList
{
    using System;

    [AttributeUsage(AttributeTargets.Struct
        | AttributeTargets.Class
        | AttributeTargets.Method
        | AttributeTargets.Interface
        | AttributeTargets.Enum)]
    public class VersionAttribute : Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major
        {
            get
            {
                return this.major;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Major cannot be negative");
                }

                this.major = value;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Minor cannot be negative");
                }

                this.minor = value;
            }
        }
    }
}
