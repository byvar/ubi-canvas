using System.IO;

namespace UbiArt
{
    /// <summary>
    /// Encodes/decodes data from streams
    /// </summary>
    public interface IStreamEncoder
    {
        /// <summary>
        /// The name of the encoder, for use in logging
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Decodes the data from the input stream to the output stream
        /// </summary>
        /// <param name="input">The input data stream</param>
        /// <param name="output">The output data stream</param>
        void DecodeStream(Stream input, Stream output);

        /// <summary>
        /// Encodes the data from the input stream to the output stream
        /// </summary>
        /// <param name="input">The input data stream</param>
        /// <param name="output">The output data stream</param>
        void EncodeStream(Stream input, Stream output);
    }
}