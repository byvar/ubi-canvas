using System.Collections.Generic;

namespace UbiArt {
	public class TextureCooked : ICSerializable {
		public static uint ExpectedSignature = 0x54455800; // TEX\0
		public uint Version { get; set; } // 0xD for legends, 0x11 for adventures
		public uint Signature { get; set; } = ExpectedSignature;
		public uint HeaderSize { get; set; }
		public uint DataSize { get; set; }
		public ushort Width { get; set; }
		public ushort Height { get; set; }
		public ushort unk_factor { get; set; } = 1; // unk1 & unk2 are both divided by (width * height * unk_factor) to determine something. Always 1 in Legends? Mip levels maybe?
		public byte BPP { get; set; } = 32;
		public byte CompressionType { get; set; } = 0; // Unused on PC? On Android: 3 - PVRTC, 4 - ATC
		public byte V16_Byte0 { get; set; } // Only first byte seems used?
		public byte V16_Byte1 { get; set; }
		public byte V16_Byte2 { get; set; }
		public byte V16_Byte3 { get; set; }
		public uint DataSize2 { get; set; }
		public uint unk0 { get; set; } // Always 0 in Legends?
		public uint PixelsCountAlpha1 { get; set; } // Pixels where alpha == 1, before compression.Verified with uncompressed RL PS4 textures
		public uint PixelsCountAlpha0 { get; set; } // Pixels where alpha == 0, before compression.Verified with uncompressed RL PS4 textures
		public uint UnknownCRC { get; set; } // Seems to be a CRC. Doesn't seem to be used at all by the game. Some kind of tag, only for the editor?
		public WrapMode WrapModeU { get; set; } = WrapMode.Repeat;
		public WrapMode WrapModeV { get; set; } = WrapMode.Repeat;
		public byte Padding1 { get; set; } // 0xCC in Legends, 0 in Adventures
		public byte Padding2 { get; set; }
		public uint HeaderEndCode { get; set; } = 0x00010203; // 0 1 2 3
		public byte[] texData { get; set; }

		public UV.UVAtlas atlas = null;

		public string filename;

		public void Serialize(CSerializerObject s, string name) {
			filename = s.CurrentPointer.File.DisplayName;
			Reinit(s.Settings);
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				Version = s.Serialize<uint>(Version);
				Signature = s.Serialize<uint>(Signature);
				HeaderSize = s.Serialize<uint>(HeaderSize);
				DataSize = s.Serialize<uint>(DataSize);
				Width = s.Serialize<ushort>(Width);
				Height = s.Serialize<ushort>(Height);
				unk_factor = s.Serialize<ushort>(unk_factor);
				BPP = s.Serialize<byte>(BPP, name: nameof(BPP));
				CompressionType = s.Serialize<byte>(CompressionType, name: nameof(CompressionType));
				if (Version >= 16) {
					V16_Byte0 = s.Serialize<byte>(V16_Byte0, name: nameof(V16_Byte0));
					V16_Byte1 = s.Serialize<byte>(V16_Byte1, name: nameof(V16_Byte1));
					V16_Byte2 = s.Serialize<byte>(V16_Byte2, name: nameof(V16_Byte2));
					V16_Byte3 = s.Serialize<byte>(V16_Byte3, name: nameof(V16_Byte3));
				}
				DataSize2 = s.Serialize<uint>(DataSize2);
				unk0 = s.Serialize<uint>(unk0);
				PixelsCountAlpha1 = s.Serialize<uint>(PixelsCountAlpha1, name: nameof(PixelsCountAlpha1));
				PixelsCountAlpha0 = s.Serialize<uint>(PixelsCountAlpha0, name: nameof(PixelsCountAlpha0));
				UnknownCRC = s.Serialize<uint>(UnknownCRC);
				WrapModeU = (WrapMode)s.Serialize<byte>((byte)WrapModeU, name: nameof(WrapModeU));
				WrapModeV = (WrapMode)s.Serialize<byte>((byte)WrapModeV, name: nameof(WrapModeV));
				Padding1 = s.Serialize<byte>(Padding1, name: nameof(Padding1));
				Padding2 = s.Serialize<byte>(Padding2, name: nameof(Padding2));
				HeaderEndCode = s.Serialize<uint>(HeaderEndCode, name: nameof(HeaderEndCode));
			} else {
				DataSize = s.SerializeFileSize(DataSize);
			}
			texData = s.SerializeBytes(texData, (int)DataSize);
		}

		public void Reinit(Settings settings) {
			if (settings.game == Settings.Game.RL && Version >= 16) {
				Version = 13;
				HeaderSize = 0x34;
			}
		}

		public TextureCooked() { }
		public TextureCooked(Context context) {
			if (context.Settings.game == Settings.Game.RL) {
				Version = 13;
				HeaderSize = 0x34;
			}
		}

		public enum WrapMode : byte {
			Repeat = 0,
			Mirror = 1,
			Clamp = 2,
		}
	}
}
