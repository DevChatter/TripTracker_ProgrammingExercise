namespace Core.IO
{
    public interface IFileSystem
    {
        bool Exists(string filePath);
    }
}
