using System.IO;

namespace UbiArt
{
    public class Base64Encoder : IStreamEncoder
    {
        public Base64Encoder(long length)
        {
			Length = length;
		}

		public long Length { get; protected set; }
        public string Name => $"Base64";


		public void DecodeStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[Length];
            input.Read(buffer, 0, buffer.Length);

			var utf8 = System.Text.Encoding.UTF8.GetString(buffer);
			buffer = System.Convert.FromBase64String(utf8);
			output.Write(buffer, 0, buffer.Length);
		}

		public void EncodeStream(Stream input, Stream output) {
			byte[] buffer = new byte[Length];
			input.Read(buffer, 0, buffer.Length);

			string utf8 = System.Convert.ToBase64String(buffer);
			buffer = System.Text.Encoding.UTF8.GetBytes(utf8);
			output.Write(buffer, 0, buffer.Length);
		}
    }
}