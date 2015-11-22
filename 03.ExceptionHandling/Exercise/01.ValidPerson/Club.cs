using System;

class Club
{
    static void Main()
    {
        try
        {
            Person rick = new Person("Rick", "Sanchez", 60);
            Person minusAge = new Person("Howard", "Richardson", -34);
            Person noLastName = new Person("Harry", string.Empty, 23);
            Person nullFirstName = new Person(null, "Smith", 0);

            Console.WriteLine("Name: {0} {1}\nAge: {2}", rick.FirstName, rick.LastName, rick.Age);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("Name cannot be null value!");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Age must be between 0 and 120!");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Name cannot be empty space!");
        }
    }
}

