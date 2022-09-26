using System.IO;
using System.Threading.Tasks;

namespace UbiArt
{
    public class DefaultFileManager : IFileManager
    {
        public virtual bool DirectoryExists(string path) => Directory.Exists(path);
        public virtual bool FileExists(string path) => File.Exists(path);

        public virtual Stream GetFileReadStream(string path) => File.OpenRead(path);
        public virtual Stream GetFileWriteStream(string path, bool recreateOnWrite = true) => recreateOnWrite ? File.Create(path) : File.OpenWrite(path);

        public virtual PathSeparatorChar SeparatorCharacter => PathSeparatorChar.ForwardSlash;

        public virtual Task FillCacheForReadAsync(long length, Reader reader) => Task.CompletedTask;
    }
}