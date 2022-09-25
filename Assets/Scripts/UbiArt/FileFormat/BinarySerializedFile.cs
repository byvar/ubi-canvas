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
        //byte[] data = null;

        public BinarySerializedFile(MapLoader context, string name, Path path, bool ckd) : this(context, name, context.GetGameFileStream(path, ckd)) {
            this.path = path;
			this.ckd = ckd;
        }

        public BinarySerializedFile(MapLoader context, string name, Stream stream) {
            this.name = name;
            length = stream.Length;
            /*using (Reader fileReader = new Reader(stream, Settings.s.IsLittleEndian)) {
                data = fileReader.ReadBytes((int)stream.Length);
            }*/
            reader = new Reader(stream/*new MemoryStream(data)*/, context.Settings.IsLittleEndian);
			string extension = null;
			if (name.Contains(".")) {
				extension = name.Substring(name.LastIndexOf(".") + 1);
			}
			if (context.Settings.serializerType == Settings.SerializerType.TagBinary && !context.IsPureBinary(name, extension)) {
				serializer = new CSerializerObjectTagBinary(context, reader);
			} else {
				serializer = new CSerializerObjectBinary(context, reader);
			}
			MapLoader.ConfigureSerializeFlagsForExtension(ref serializer.flags, ref serializer.flagsOwn, extension);
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
