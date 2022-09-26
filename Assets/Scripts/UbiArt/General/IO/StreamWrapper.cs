using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace UbiArt
{
    /// <summary>
    /// A <see cref="Stream"/> wrapper with support for XOR and checksum calculation when reading/writing bytes
    /// </summary>
    public class StreamWrapper : Stream
    {
        #region Constructor

        public StreamWrapper(Stream innerStream)
        {
            InnerStream = innerStream;
        }

        #endregion

        #region Public Properties

        public Stream InnerStream { get; }

        public IXORCalculator XORCalculator { get; set; }
        public IChecksumCalculator ChecksumCalculator { get; set; }

        #endregion

        #region Protected Methods

        protected virtual void ProcessReadBytes(byte[] buffer, int offset, int count)
        {
            if (ChecksumCalculator?.CalculateForDecryptedData == false)
                ChecksumCalculator?.AddBytes(buffer, offset, count);

            if (XORCalculator != null)
                for (int i = 0; i < count; i++)
                    buffer[offset + i] = XORCalculator.XORByte(buffer[offset + i]);

            if (ChecksumCalculator?.CalculateForDecryptedData == true)
                ChecksumCalculator?.AddBytes(buffer, offset, count);
        }
        protected virtual byte ProcessReadByte(byte b)
        {
            if (ChecksumCalculator?.CalculateForDecryptedData == false)
                ChecksumCalculator?.AddByte(b);

            if (XORCalculator != null)
                b = XORCalculator.XORByte(b);

            if (ChecksumCalculator?.CalculateForDecryptedData == true)
                ChecksumCalculator?.AddByte(b);

            return b;
        }

        protected virtual (byte[], int) ProcessWriteBytes(byte[] buffer, int offset, int count)
        {
            var data = buffer;

            if (ChecksumCalculator?.CalculateForDecryptedData == true)
                ChecksumCalculator?.AddBytes(data, offset, count);

            var newOffset = offset;

            if (XORCalculator != null)
            {
                // Avoid changing data in array, so create a copy
                data = new byte[count];

                Array.Copy(buffer, offset, data, 0, count);

                newOffset = 0;

                for (int i = 0; i < count; i++)
                    data[i] = XORCalculator.XORByte(data[i]);
            }

            if (ChecksumCalculator?.CalculateForDecryptedData == false)
                ChecksumCalculator?.AddBytes(data, newOffset, count);

            return (data, newOffset);
        }
        protected virtual byte ProcessWriteByte(byte b)
        {
            if (ChecksumCalculator?.CalculateForDecryptedData == true)
                ChecksumCalculator?.AddByte(b);

            if (XORCalculator != null)
                b = XORCalculator.XORByte(b);

            if (ChecksumCalculator?.CalculateForDecryptedData == false)
                ChecksumCalculator?.AddByte(b);

            return b;
        }

        #endregion

        #region Stream Modifications

        // Read
        public override int Read(byte[] buffer, int offset, int count)
        {
            var readBytes = InnerStream.Read(buffer, offset, count);

            if (readBytes != 0)
                ProcessReadBytes(buffer, offset, readBytes);

            return readBytes;
        }
        public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            var readBytes = await InnerStream.ReadAsync(buffer, offset, count, cancellationToken);

            if (readBytes != 0)
                ProcessReadBytes(buffer, offset, readBytes);

            return readBytes;
        }
        public override int ReadByte()
        {
            var v = InnerStream.ReadByte();

            if (v == -1)
                return v;
            else
                return ProcessReadByte((byte)v);
        }

        // Write
        public override void Write(byte[] buffer, int offset, int count)
        {
            var (data, newOffset) = ProcessWriteBytes(buffer, offset, count);

            InnerStream.Write(data, newOffset, count);
        }
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            var (data, newOffset) = ProcessWriteBytes(buffer, offset, count);

            return InnerStream.WriteAsync(data, newOffset, count, cancellationToken);
        }
        public override void WriteByte(byte value)
        {
            var b = ProcessWriteByte(value);

            InnerStream.WriteByte(b);
        }

        #endregion

        #region Stream Redirects

        // Seek and length
        public override long Seek(long offset, SeekOrigin origin) => InnerStream.Seek(offset, origin);
        public override void SetLength(long value) => InnerStream.SetLength(value);

        // Properties
        public override bool CanRead => InnerStream.CanRead;
        public override bool CanSeek => InnerStream.CanSeek;
        public override bool CanTimeout => InnerStream.CanTimeout;
        public override bool CanWrite => InnerStream.CanWrite;
        public override long Length => InnerStream.Length;
        public override long Position
        {
            get => InnerStream.Position;
            set => InnerStream.Position = value;
        }
        public override int ReadTimeout
        {
            get => InnerStream.ReadTimeout;
            set => InnerStream.ReadTimeout = value;
        }
        public override int WriteTimeout
        {
            get => InnerStream.WriteTimeout;
            set => InnerStream.WriteTimeout = value;
        }

        // Other
        public override object InitializeLifetimeService() => InnerStream.InitializeLifetimeService();
        public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) => InnerStream.CopyToAsync(destination, bufferSize, cancellationToken);

        // Common override methods
        public override bool Equals(object obj) => InnerStream.Equals(obj);
        public override int GetHashCode() => InnerStream.GetHashCode();
        public override string ToString() => InnerStream.ToString();

        // Dispose and flush
        public override void Close() => InnerStream.Close();
        protected override void Dispose(bool disposing) => InnerStream.Dispose();
        public override void Flush() => InnerStream.Flush();
        public override Task FlushAsync(CancellationToken cancellationToken) => InnerStream.FlushAsync(cancellationToken);

        #endregion
    }
}