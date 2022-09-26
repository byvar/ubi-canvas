namespace UbiArt
{
    /// <summary>
    /// Interface for a checksum calculator with the generic value
    /// </summary>
    public interface IChecksumCalculator<out T> : IChecksumCalculator
    {
        /// <summary>
        /// The current checksum value
        /// </summary>
        T ChecksumValue { get; }
    }

    /// <summary>
    /// Base interface for a checksum calculator
    /// </summary>
    public interface IChecksumCalculator
    {
        /// <summary>
        /// Indicates if the checksum should be calculated for the decrypted data. This is ignored if the data is not encrypted.
        /// </summary>
        bool CalculateForDecryptedData { get; }

        /// <summary>
        /// Adds a byte to the checksum
        /// </summary>
        /// <param name="b">The byte to add</param>
        void AddByte(byte b);

        /// <summary>
        /// Adds an array of bytes to the checksum
        /// </summary>
        /// <param name="bytes">The bytes to add</param>
        /// <param name="offset">The offset in the array to start reading from</param>
        /// <param name="count">The amount of bytes to read from the array</param>
        void AddBytes(byte[] bytes, int offset, int count);
    }
}