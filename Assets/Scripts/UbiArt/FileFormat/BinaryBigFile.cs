using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UbiArt.FileFormat {
    public class BinaryBigFile : FileWithPointers {
		Path path;
        long length;

        public BinaryBigFile(string name, Path path) : this(name, FileSystem.GetFileReadStream((MapLoader.Loader.gameDataBinFolder + "/" + path.folder + path.filename))) {
            this.path = path;
        }

        public BinaryBigFile(string name, Stream stream) {
            this.name = name;
            length = stream.Length;
            reader = new Reader(stream, Settings.s.IsLittleEndian);
			string extension = null;
			if (name.Contains(".")) {
				extension = name.Substring(name.LastIndexOf(".") + 1);
			}
			MapLoader l = MapLoader.Loader;
			if (Settings.s.serializerType == Settings.SerializerType.TagBinary && !l.IsPureBinary(name, extension)) {
				serializer = new CSerializerObjectTagBinary(reader);
			} else {
				serializer = new CSerializerObjectBinary(reader);
			}
			MapLoader.ConfigureSerializeFlagsForExtension(ref serializer.flags, ref serializer.flagsOwn, extension);
			baseOffset = -headerOffset;
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
        }

        public override void CreateWriter() {
            return; // No writing support yet
        }

        public override void WritePointer(Pointer pointer) {
            if (writer != null) {
                if (pointer == null) {
                    writer.Write((uint)0);
                } else {
                    writer.Write(pointer.offset);
                }
            }
        }
    }
}
