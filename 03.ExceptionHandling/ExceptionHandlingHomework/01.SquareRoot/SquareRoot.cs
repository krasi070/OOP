using System;

class SquareRoot
{
    static void Main(string[] args)
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                throw new ArgumentException();
            }
            Console.WriteLine(Math.Sqrt(n));
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}

