using System.IO;
using System.Threading.Tasks;

namespace UbiArt
{
    public interface IFileManager
    {
        bool DirectoryExists(string path);
        bool FileExists(string path);

        Stream GetFileReadStream(string path);
        Stream GetFileWriteStream(string path, bool recreateOnWrite = true);

        PathSeparatorChar SeparatorCharacter { get; }

        Task FillCacheForReadAsync(long length, Reader reader);
    }
}