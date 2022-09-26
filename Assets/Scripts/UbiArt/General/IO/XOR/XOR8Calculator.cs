namespace UbiArt
{
    /// <summary>
    /// Class for basic XOR operations with a single byte key
    /// </summary>
    public class XOR8Calculator : IXORCalculator 
    {
        public XOR8Calculator(byte key)
        {
            Key = key;
        }

        public byte Key { get; set; }

        public byte XORByte(byte b) => (byte)(b ^ Key);
    }
}