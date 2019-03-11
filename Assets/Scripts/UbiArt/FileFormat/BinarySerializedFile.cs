using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UbiArt.FileFormat {
    public class BinarySerializedFile : FileWithPointers {
		bool ckd;
		Path path;
        long length;
        byte[] data = null;

        public BinarySerializedFile(string name, Path path, bool ckd) : this(name, FileSystem.GetFileReadStream((MapLoader.Loader.gameDataBinFolder + "/" + path.folder + path.filename + (ckd? ".ckd" : "")))) {
            this.path = path;
			this.ckd = ckd;
        }

        public BinarySerializedFile(string name, Stream stream) {
            this.name = name;
            length = stream.Length;
            using (Reader fileReader = new Reader(stream, Settings.s.IsLittleEndian)) {
                data = fileReader.ReadBytes((int)stream.Length);
            }
            reader = new Reader(new MemoryStream(data), Settings.s.IsLittleEndian);
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
