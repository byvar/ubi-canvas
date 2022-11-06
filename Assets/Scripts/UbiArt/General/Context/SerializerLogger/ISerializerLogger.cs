using System;

namespace UbiArt
{
    public interface ISerializerLogger : IDisposable
    {
        bool IsEnabled { get; }
        void Log(object obj);
    }
}