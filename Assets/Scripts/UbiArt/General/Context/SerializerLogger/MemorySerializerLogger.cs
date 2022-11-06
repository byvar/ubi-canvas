using System;
using System.Text;

namespace UbiArt
{
    /// <summary>
    /// A serializer logger which logs to memory, allowing the entire log to be retrieved as a string. This is not recommended
    /// for larger serializations as it can use a lot of memory.
    /// </summary>
    public class MemorySerializerLogger : ISerializerLogger
    {
        public bool IsEnabled { get; set; } = true;

        private StringBuilder _stringBuilder;
        protected StringBuilder StringBuilder => _stringBuilder ??= new StringBuilder();

        public string GetString() => StringBuilder.ToString();
        public void Clear() => StringBuilder.Clear();
        public void Log(object obj) => StringBuilder.AppendLine(obj != null ? obj.ToString() : String.Empty);
        public void Dispose() => _stringBuilder = null;
    }
}