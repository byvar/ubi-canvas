using PlasticGui.WorkspaceWindow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UbiArt.FileFormat {
    public class BinaryStreamFile : BinaryFile {
        public BinaryStreamFile(Context context, string name, Stream stream, Endian? endianness = null) : base(context, name, endianness: endianness) {
			Stream = stream;
		}

		public Stream Stream { get; set; }

		protected override Stream ReadStream => Stream;
		protected override Stream WriteStream => throw new NotImplementedException();
	}
}
