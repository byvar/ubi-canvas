namespace UbiArt
{
    /// <summary>
    /// An empty serializer log which is always disabled
    /// </summary>
    public class EmptySerializerLog : ISerializerLog
    {
        public bool IsEnabled => false;

        public void Log(object obj) { }
        public void Dispose() { }
    }
}