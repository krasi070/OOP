namespace Blobs
{
    using Interfaces;
    using UserInterfaces;
    using Engine;

    public class Program
    {
        public static void Main()
        {
            IUserInterface userInterface = new ConsoleUserInterface();
            IEngine engine = new BlobEngine(userInterface);

            engine.Run();
        }
    }
}
