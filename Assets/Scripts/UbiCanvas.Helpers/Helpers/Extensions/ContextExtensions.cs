using Cysharp.Threading.Tasks;
using System.IO;

namespace UbiCanvas.Helpers {
    /*public static class ContextExtensions {
        public static async UniTask<LinearFile> AddLinearFileAsync(this Context context, string filePath, Endian endianness = Endian.Little, bool recreateOnWrite = true, int? bigFileCacheLength = null) {
            var absolutePath = context.GetAbsoluteFilePath(filePath);

            if (bigFileCacheLength.HasValue) {
                await FileSystem.PrepareBigFile(absolutePath, bigFileCacheLength.Value);
            } else {
                await FileSystem.PrepareFile(absolutePath);
            }

            if (!FileSystem.FileExists(absolutePath))
                return null;

            var file = new LinearFile(context, filePath, endianness) {
                RecreateOnWrite = recreateOnWrite
            };

            context.AddFile(file);

            return file;
        }
        public static StreamFile AddStreamFile(this Context context, string name, Stream stream, Endian endianness = Endian.Little) {
            var file = new StreamFile(context, name, stream, endianness);

            context.AddFile(file);

            return file;
        }
        public static StreamFile AddStreamFile(this Context context, string name, byte[] bytes, Endian endianness = Endian.Little) {
            var file = new StreamFile(context, name, new MemoryStream(bytes), endianness);

            context.AddFile(file);

            return file;
        }
	}*/
}