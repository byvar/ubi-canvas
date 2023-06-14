using PlasticGui.WorkspaceWindow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UbiArt.FileFormat {
    public abstract class BinaryFile : UbiArtFile {

        public BinaryFile(Context context, string name, Endian? endianness = null) : base(context, name) {
			Endianness = endianness ?? context.Settings.Endian;
		}

		public override CSerializerObject Deserializer {
			get {
				if (CurrentSerializer != null) {
					switch (CurrentSerializer) {
						case CSerializerObjectBinary:
						case CSerializerObjectTagBinary:
							CurrentSerializer.ResetPosition();
							break;
						default:
							CurrentSerializer?.Dispose();
							CurrentSerializer = null;
							break;
					}
				}
				if (CurrentSerializer == null) {
					if (Context.Settings.serializerType == Settings.SerializerType.TagBinary && !Context.Loader.IsPureBinary(FilePath, Extension)) {
						CurrentSerializer = new CSerializerObjectTagBinary(Context, this);
					} else {
						CurrentSerializer = new CSerializerObjectBinary(Context, this);
					}
					Loader.ConfigureSerializeFlagsForExtension(ref CurrentSerializer.flags, ref CurrentSerializer.properties, Extension);
				}
				return CurrentSerializer;
			}
		}

		public virtual Reader CreateReader() {
			Stream s = ReadStream;
			Reader reader = new Reader(s, isLittleEndian: Endianness == Endian.Little);
			Context.SystemLogger?.LogTrace("Created reader for file {0}", FilePath);
			return reader;
		}

		public virtual Writer CreateWriter() {
			Stream s = WriteStream;
			Writer writer = new Writer(s, isLittleEndian: Endianness == Endian.Little);
			Context.SystemLogger?.LogTrace("Created writer for file {0}", FilePath);
			return writer;
		}

		/// <summary>
		/// The endianness to use when serializing the file
		/// </summary>
		public Endian Endianness { get; }

		public override CSerializerObject Serializer => throw new NotImplementedException();

		protected abstract Stream ReadStream { get; }
		protected abstract Stream WriteStream { get; }
	}
}
