namespace UbiArt
{
    /// <summary>
    /// Class for XOR operations with a multi-byte key
    /// </summary>
    public class XORArrayCalculator : IXORCalculator 
    {
        public XORArrayCalculator(byte[] key, int byteIndex = 0, int? maxLength = null)
        {
            Key = key;
            ByteIndex = byteIndex;
            MaxLength = maxLength;
        }

        public byte[] Key { get; }
        public int ByteIndex { get; set; }
        public int? MaxLength { get; }

        public byte XORByte(byte b) 
        {
            if (ByteIndex >= MaxLength)
            {
                ByteIndex++;
                return b;
            }

            byte key = Key[ByteIndex % Key.Length];
            ByteIndex++;
            return (byte)(b ^ key);
        }
    }
}