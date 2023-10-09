using System;
using System.Runtime.InteropServices;
namespace PVRImageWrapper {
	public class PVRImage {
		public static readonly UInt32 headerVersion = 0x03525650;
		private static readonly UInt32 badEndianess = 0x50565203;
		private static readonly int HeaderSize = 52;
		private byte[] rawData;
		private PVRHeader header;
		public PVRHeader RawHeaderData { get { return header; } }
		/// <summary>
		/// Checks to see if the header matches big or little endianness.
		/// If it matches neither, the file is not a valid PVR file or the PVR Header spec has updated.
		/// </summary>
		/// <value></value>
		public bool IsValid {
			get {
				return (header.Version == headerVersion || header.Version == badEndianess);
			}
		}
		public bool EndianMatch {
			get { return header.Version == headerVersion; }
		}
		public TextureFlags Flags { get { return (TextureFlags)header.Flags; } }
		public PixelFormat pixelFormat { get { return (PixelFormat)header.PixelFormat; } }
		public bool isLinear { get { return header.ColorSpace == 0; } }
		public ChannelType channelType { get { return (ChannelType)header.ChannelType; } }
		public int Height { get { return (int)header.Height; } }
		public int Width { get { return (int)header.Width; } }
		public int NumSurfaces { get { return (int)header.NumSurfaces; } }
		public int NumFaces { get { return (int)header.NumFaces; } }
		public int MipMapCount { get { return (int)header.MipMapCount; } }
		public int MetaDataSize { get { return (int)header.MetaDataSize; } }
		public int MetaDataOffset { get { return HeaderSize; } }
		public int TextureDataOffset { get { return MetaDataOffset + MetaDataSize; } }
		/*
		Convenience methods for getting a byte[] of specific parts of the file.
		 */
		public byte[] GetMetaData() {
			byte[] metaData = new byte[MetaDataSize];
			GetMetaData(metaData);
			return metaData;
		}
		public void GetMetaData(byte[] metaData) {
			System.Buffer.BlockCopy(rawData, MetaDataOffset, metaData, 0, MetaDataSize);
		}
		public byte[] GetTextureData() {
			byte[] rgbData = new byte[rawData.Length - TextureDataOffset];
			GetRGBData(rgbData);
			return rgbData;
		}
		public void GetRGBData(byte[] rgbData) {
			System.Buffer.BlockCopy(rawData, TextureDataOffset, rgbData, 0, rgbData.Length);
		}
		private PVRImage() { }
		public PVRImage(byte[] allBytes) {
			rawData = allBytes;
			header = ByteArrayToStructure<PVRHeader>(rawData);
		}

		static T ByteArrayToStructure<T>(byte[] bytes) where T : struct {
			var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
			try {
				return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
			} finally {
				handle.Free();
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PVRHeader {
			public UInt32 Version;
			public UInt32 Flags;
			public UInt64 PixelFormat;
			public UInt32 ColorSpace;
			public UInt32 ChannelType;
			public UInt32 Height;
			public UInt32 Width;
			public UInt32 Depth;
			public UInt32 NumSurfaces;
			public UInt32 NumFaces;
			public UInt32 MipMapCount;
			public UInt32 MetaDataSize;
		}

		public enum TextureFlags {
			No_Flag = 0,
			Pre_Multiplied = 0x2
		}
		public enum PixelFormat {
			PVRTC_2bpp_RGB = 0,
			PVRTC_2bpp_RGBA = 1,
			PVRTC_4bpp_RGB = 2,
			PVRTC_4bpp_RGBA = 3,
			PVRTCII_2bpp = 4,
			PVRTCII_4bpp = 5,
			ETC1 = 6,
			DXT1 = 7,
			DXT2 = 8,
			DXT3 = 9,
			DXT4 = 10,
			DXT5 = 11,
			BC1 = 7,
			BC2 = 9,
			BC3 = 11,
			BC4 = 12,
			BC5 = 13,
			BC6 = 14,
			BC7 = 15,
			UYVY = 16,
			YUY2 = 17,
			BW1bpp = 18,
			R9G9B9E5_Shared_Exponent = 19,
			RGBG8888 = 20,
			GRGB8888 = 21,
			ETC2_RGB = 22,
			ETC2_RGBA = 23,
			ETC2_RGB_A1 = 24,
			EAC_R11 = 25,
			EAC_RG11 = 26,
			ASTC_4x4 = 27,
			ASTC_5x4 = 28,
			ASTC_5x5 = 29,
			ASTC_6x5 = 30,
			ASTC_6x6 = 31,
			ASTC_8x5 = 32,
			ASTC_8x6 = 33,
			ASTC_8x8 = 34,
			ASTC_10x5 = 35,
			ASTC_10x6 = 36,
			ASTC_10x8 = 37,
			ASTC_10x10 = 38,
			ASTC_12x10 = 39,
			ASTC_12x12 = 40,
			ASTC_3x3x3 = 41,
			ASTC_4x3x3 = 42,
			ASTC_4x4x3 = 43,
			ASTC_4x4x4 = 44,
			ASTC_5x4x4 = 45,
			ASTC_5x5x4 = 46,
			ASTC_5x5x5 = 47,
			ASTC_6x5x5 = 48,
			ASTC_6x6x5 = 49,
			ASTC_6x6x6 = 50,
		}

		public enum ChannelType {
			UByte_Norm = 0,
			SByte_Norm = 1,
			UByte = 2,
			SByte = 3,
			UShort_Norm = 4,
			Short_Norm = 5,
			UShort = 6,
			Short = 7,
			UInt_Norm = 8,
			Int_Norm = 9,
			UInt = 10,
			Int = 11,
			Float = 12,
		}
	}
}