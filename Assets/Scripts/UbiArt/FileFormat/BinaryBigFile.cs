﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UbiCanvas.Helpers;

namespace UbiArt.FileFormat {
    public class BinaryBigFile : FileWithPointers {
		Path path;
        long length;

        public BinaryBigFile(Context context, string name, Path path) : this(context, name, FileSystem.GetFileReadStream((context.gameDataBinFolder + "/" + path.folder + path.filename))) {
            this.path = path;
        }

        public BinaryBigFile(Context context, string name, Stream stream) {
            this.name = name;
            length = stream.Length;
            reader = new Reader(stream, context.Settings.IsLittleEndian);
			string extension = null;
			if (name.Contains(".")) {
				extension = name.Substring(name.LastIndexOf(".") + 1);
			}
			if (context.Settings.serializerType == Settings.SerializerType.TagBinary && !context.IsPureBinary(name, extension)) {
				serializer = new CSerializerObjectTagBinary(context, reader);
			} else {
				serializer = new CSerializerObjectBinary(context, reader);
			}
			Context.ConfigureSerializeFlagsForExtension(ref serializer.flags, ref serializer.flagsOwn, extension);
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
