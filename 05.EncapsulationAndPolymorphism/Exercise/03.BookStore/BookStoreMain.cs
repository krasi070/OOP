namespace _03.BookStore
{
    using Engine;
    using UI;

    public class BookStoreMain
    {
        public static void Main()
        {
            ConsoleInputHandler cih = new ConsoleInputHandler();
            ConsoleRenderer cr = new ConsoleRenderer();

            BookStoreEngine engine = new BookStoreEngine(cr, cih);

            engine.Run();
        }
    }
}
