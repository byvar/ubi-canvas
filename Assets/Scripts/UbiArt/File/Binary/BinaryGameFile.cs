using PlasticGui.WorkspaceWindow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UbiArt.FileFormat {
    public class BinaryGameFile : BinaryFile {
		public Path Path { get; protected set; }
		public bool Cooked { get; protected set; }

        public BinaryGameFile(Context context, string name, Path path, bool cooked, Endian? endianness = null) : base(context, name, endianness: endianness) {
            Path = path;
			Cooked = cooked;
		}

		protected override Stream ReadStream => Context.GetGameFileStream(Path, Cooked);
		protected override Stream WriteStream => throw new NotImplementedException();

		public override string DisplayName => Alias ?? Path?.filename ?? FilePath;
	}
}
