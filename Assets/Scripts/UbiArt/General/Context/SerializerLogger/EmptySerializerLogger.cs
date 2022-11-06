namespace UbiArt
{
    /// <summary>
    /// An empty serializer logger which is always disabled
    /// </summary>
    public class EmptySerializerLogger : ISerializerLogger
    {
        public bool IsEnabled => false;

        public void Log(object obj) { }
        public void Dispose() { }
    }
}