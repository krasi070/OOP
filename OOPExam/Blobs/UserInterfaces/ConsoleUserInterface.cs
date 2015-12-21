namespace Blobs.UserInterfaces
{
    using System;
    using Interfaces;

    public class ConsoleUserInterface : IUserInterface
    {
        public string ReadLine()
        {
            string input = Console.ReadLine();

            return input;
        }

        public void WriteLine(string output, params string[] parameters)
        {
            Console.WriteLine(output, parameters);
        }

        public void Write(string output, params string[] parameters)
        {
            Console.Write(output, parameters);
        }
    }
}
