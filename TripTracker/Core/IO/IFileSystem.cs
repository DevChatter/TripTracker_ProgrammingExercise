namespace Core.IO
{
    public interface IFileSystem
    {
        bool Exists(string filePath);
        string[] ReadAllLines(string filePath);
    }
}
