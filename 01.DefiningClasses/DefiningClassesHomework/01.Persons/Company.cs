using System;

class Company
{
    static void Main()
    {
        Person[] persons = new Person[2];
        persons[0] = new Person("Rick", 60, "rick.sanchez@gmail.com");
        persons[1] = new Person("Morty", 14);
        //Person noName = new Person("", 34, "emanonevahi@gmail.com");
        //Person oldPerson = new Person("Jerry", 110);
        //Person emptyEmailPerson = new Person("Mickey", 20, "micmic.com");
        
        foreach (var person in persons)
        {
            Console.WriteLine(person.ToString());
            if (!person.Equals(persons[persons.Length - 1]))
            {
                Console.WriteLine();
            }
        }
    }
}

