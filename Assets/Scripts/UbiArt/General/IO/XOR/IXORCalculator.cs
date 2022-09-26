namespace UbiArt
{
    /// <summary>
    /// Base interface for any class that XORs bytes
    /// </summary>
    public interface IXORCalculator
    {
        byte XORByte(byte b);
    }
}