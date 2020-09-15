using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UbiArt.FileFormat {
    public abstract class FileWithPointers : IDisposable {
        public string name = "Unknown";
        public Reader reader;
        public Writer writer;
		public CSerializerObject serializer;
        public Dictionary<uint, Pointer> pointers = new Dictionary<uint, Pointer>();
		public Dictionary<string, object> extraData = new Dictionary<string, object>();
        public long baseOffset; // Base offset within file
        public long headerOffset = 0;
        public bool allowUnsafePointers = false;

        public void Dispose() {
            if (reader != null) reader.Close();
            if (writer != null) writer.Close();
        }

        public void AddPointer(uint offset, Pointer pointer) {
            pointers[offset] = pointer;
        }

        public void GotoHeader() {
            if (reader != null) {
                reader.BaseStream.Seek(headerOffset + baseOffset, SeekOrigin.Begin);
            }
        }

        public abstract void CreateWriter();
    }
}
