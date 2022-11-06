using System.IO;
using System.Threading.Tasks;
using UbiArt;
using UbiCanvas.Helpers;

namespace UbiCanvas {

	public class MapViewerFileManager : IFileManager
	{
		public PathSeparatorChar SeparatorCharacter => PathSeparatorChar.ForwardSlash;

		public bool DirectoryExists(string path) => FileSystem.DirectoryExists(path);

		public bool FileExists(string path) => FileSystem.FileExists(path);

		public Stream GetFileReadStream(string path) => FileSystem.GetFileReadStream(path);

		public Stream GetFileWriteStream(string path, bool recreateOnWrite = true) => FileSystem.GetFileWriteStream(path, recreateOnWrite);

		public async Task FillCacheForReadAsync(long length, Reader reader)
		{
			if (reader.BaseStream.InnerStream is PartialHttpStream httpStream)
				await httpStream.FillCacheForRead(length);
		}

		public async Task PrepareFile(string path) => await FileSystem.PrepareFile(path);

		public async Task PrepareBigFile(string path, int cacheLength) => await FileSystem.PrepareBigFile(path, cacheLength);
	}
}