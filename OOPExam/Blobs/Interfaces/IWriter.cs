namespace Blobs.Interfaces
{
    public interface IWriter
    {
        void WriteLine(string output, params string[] parameters);

        void Write(string output, params string[] parameters);
    }
}
