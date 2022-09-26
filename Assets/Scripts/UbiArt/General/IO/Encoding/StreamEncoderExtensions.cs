using System.IO;

namespace UbiArt
{
    /// <summary>
    /// Extension methods for <see cref="IStreamEncoder"/>
    /// </summary>
    public static class StreamEncoderExtensions
    {
        /// <summary>
        /// Decodes data from a byte array
        /// </summary>
        /// <param name="encoder">The encoder</param>
        /// <param name="data">The data to decode</param>
        /// <returns>The decoded data</returns>
        public static byte[] DecodeBuffer(this IStreamEncoder encoder, byte[] data)
        {
            // Create memory streams
            using MemoryStream inputStream = new MemoryStream(data);
            using MemoryStream outputStream = new MemoryStream();

            // Decode the data
            encoder.DecodeStream(inputStream, outputStream);

            // Return the output
            return outputStream.ToArray();
        }

        /// <summary>
        /// Encodes data from a byte array
        /// </summary>
        /// <param name="encoder">The encoder</param>
        /// <param name="data">The data to encode</param>
        /// <returns>The encoded data</returns>
        public static byte[] EncodeBuffer(this IStreamEncoder encoder, byte[] data)
        {
            // Create memory streams
            using MemoryStream inputStream = new MemoryStream(data);
            using MemoryStream outputStream = new MemoryStream();

            // Encode the data
            encoder.EncodeStream(inputStream, outputStream);

            // Return the output
            return outputStream.ToArray();
        }
    }
}