using System;

class BitArrayTest
{
    static void Main()
    {
        BitArray bitArr = new BitArray(16);
        bitArr[12] = 1;
        bitArr[14] = 1;
        bitArr[15] = 1;
        //bitArr[16] = 1;
        Console.WriteLine(bitArr.ToString());
    }
}

