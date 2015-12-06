namespace _03.GenericList
{
    using System;
    using System.Linq;
    
    [Version(1, 23)]
    public class GenericList<T>
        where T : IComparable
    {
        private const int DefaultCapacity = 16;
        private T[] arr;
        private int index;
        private int capacity;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.arr = new T[capacity];
            this.index = -1;
            this.capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity cannot be less than 1");
                }

                this.capacity = value;
            }
        }

        public void Add(T element)
        {
            this.index++;

            if (this.index == this.Capacity)
            {
                this.arr = this.Resize(this.arr);
            }

            this.arr[this.index] = element;
        }

        public T Access(int i)
        {
            this.CheckIfIndexIsInRange(i);

            return this.arr[i];
        }

        public void Remove(int i)
        {
            this.CheckIfIndexIsInRange(i);

            for (int j = i; j < this.index; j++)
            {
                this.arr[j] = this.arr[j + 1]; 
            }

            this.index--;
        }

        public void Insert(int i, T element)
        {
            this.CheckIfIndexIsInRange(i);

            this.index++;

            if (this.index == this.Capacity)
            {
                this.arr = this.Resize(this.arr);
            }

            for (int j = i + i; j <= this.index; j++)
            {
                this.arr[j] = this.arr[j - 1];
            }

            this.arr[i] = element;
        }

        public void Clear()
        {
            this.index = -1;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i <= this.index; i++)
            {
                if (this.arr[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T element)
        {
            foreach (var item in this.arr)
            {
                if (item.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public T Max()
        {
            if (this.index == -1)
            {
                throw new InvalidOperationException("Cannot find max element");
            }

            T max = this.arr[0];

            for (int i = 1; i <= this.index; i++)
            {
                if (max.CompareTo(this.arr[i]) < 0)
                {
                    max = this.arr[i];
                }
            }

            return max;
        }

        public T Min()
        {
            if (this.index == -1)
            {
                throw new InvalidOperationException("Cannot find min element");
            }

            T min = this.arr[0];

            for (int i = 1; i <= this.index; i++)
            {
                if (min.CompareTo(this.arr[i]) > 0)
                {
                    min = this.arr[i];
                }
            }

            return min;
        }

        public string Version()
        {
            string version = "";
            var type = typeof(GenericList<T>);
            var attributes = type.GetCustomAttributes(false);

            attributes
                .Where(a => a is VersionAttribute)
                .Select(a => a as VersionAttribute)
                .ToList()
                .ForEach(a => version = string.Format("GenericList Version: {0}.{1}",
                    a.Major, a.Minor));

            return version;
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i <= this.index; i++)
            {
                if (i == this.index)
                {
                    result += this.arr[i];
                }
                else
                {
                    result += this.arr[i] + ", ";
                }
            }

            return result;
        }

        private T[] Resize(T[] arr)
        {
            T[] newArr = new T[arr.Length * 2];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            this.Capacity = newArr.Length;

            return newArr;
        }

        private void CheckIfIndexIsInRange(int i)
        {
            if (i > this.index || i < 0)
            {
                throw new ArgumentOutOfRangeException("Index was out of range");
            }
        }
    }
}
