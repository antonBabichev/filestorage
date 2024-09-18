using FileStorage.Models;

namespace FileStorage.Repository
{
    public interface IFileStorage
    {
        Dictionary<string, string> Config { get; set; }
        Folder GetFolder(string path);
    }
}
