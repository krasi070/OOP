namespace _03.BookStore.Interfaces
{
    public interface IRenderer
    {
        void WriteLine(string message, params string[] outputParams);
    }
}
