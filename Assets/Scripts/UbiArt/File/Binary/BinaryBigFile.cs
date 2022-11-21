using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using UbiCanvas.Helpers;

namespace UbiArt.FileFormat {
    public class BinaryBigFile : BinaryFile {

		public BinaryBigFile(Context context, string path, Endian? endianness = null) : base(context, path, endianness: endianness) {
			DestinationPath = path;
		}

		public string DestinationPath { get; set; }
		protected override Stream ReadStream => FileManager.GetFileReadStream(Context.GetAbsoluteFilePath(Context.NormalizePath(FilePath, false)));
		protected override Stream WriteStream => FileManager.GetFileWriteStream(DestinationPath, true);
	}
}
