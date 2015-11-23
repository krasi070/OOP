using System;
using System.Numerics;

class BitArray
{
    private int[] arr;

    public BitArray(int numberOfBits)
    {
        if (numberOfBits < 1 || numberOfBits > 100000)
        {
            throw new ArgumentOutOfRangeException("BitArray can only be in the range [1...100000]!");
        }
        this.arr = new int[numberOfBits];
    }

    public int this[int index]
    {
        get
        {
            return this.arr[index];
        }
        set
        {
            if (index < 0 || index >= this.arr.Length)
            {
                throw new ArgumentOutOfRangeException("BitArray was out of range!");
            }
            if (value != 0 && value != 1)
            {
                throw new ArgumentException("BitArray can only contain 0 and 1 as values!");
            }
            this.arr[index] = value; 
            //this.setBit(index, value);
        }
    }

    //private void setBit(int index, int value)
    //{
    //    this[index] = value;
    //}

    public override string ToString()
    {
        BigInteger decimalValue = new BigInteger();
        decimalValue = 0;
        for (int i = 0; i < this.arr.Length; i++)
        {
            decimalValue += (BigInteger)Math.Pow(2 * this.arr[i], i);
            if (this.arr[i] == 0 && i == 0)
            {
                decimalValue = 0;
            }
        }
        return decimalValue + "";
    }
}

