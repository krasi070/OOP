namespace _03.BookStore.UI
{
    using System;
    using Interfaces;

    public class ConsoleRenderer : IRenderer
    {
        public void WriteLine(string message, params string[] outputParams)
        {
            Console.WriteLine(message, outputParams);
        }
    }
}
