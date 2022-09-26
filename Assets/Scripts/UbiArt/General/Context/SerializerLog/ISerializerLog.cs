using System;

namespace UbiArt
{
    public interface ISerializerLog : IDisposable
    {
        bool IsEnabled { get; }
        void Log(object obj);
    }
}