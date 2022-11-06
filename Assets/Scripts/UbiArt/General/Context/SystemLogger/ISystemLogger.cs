#nullable enable
using JetBrains.Annotations;

namespace UbiArt
{
    public interface ISystemLogger
    {
        [StringFormatMethod("log")]
        void Log(LogLevel logLevel, object? log, params object[] args);
    }
}