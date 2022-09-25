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

        public void Dispose() {
            if (reader != null) reader.Close();
            if (writer != null) writer.Close();
            if (serializer != null) serializer.Disposed = true;
        }

        public virtual Pointer GetUnsafePointer(long value) {
            return new Pointer(value, this);
        }

        public abstract void WritePointer(Pointer pointer);

        public abstract void CreateWriter();
    }
}
