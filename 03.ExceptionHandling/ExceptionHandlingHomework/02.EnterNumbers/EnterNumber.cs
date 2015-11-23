using System;

class EnterNumber
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            ReadNumber(1, 100);  
        }
    }

    private static void ReadNumber(int start, int end)
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            if (start > n || end < n)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Please enter number again");
            ReadNumber(start, end);
        }
        catch (ArgumentOutOfRangeException ae)
        {
            Console.WriteLine("Please enter number again");
            ReadNumber(start, end);
        }
    }
}

