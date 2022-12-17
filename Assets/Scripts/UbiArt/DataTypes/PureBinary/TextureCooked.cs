namespace UbiArt {
	public class TextureCooked : ICSerializable {
		public static uint staticSignature = 0x54455800; // TEX\0
		public uint version; // 0xD for legends, 0x11 for adventures
		public uint signature;
		public uint hdrSize;
		public uint texSize;
		public ushort width;
		public ushort height;
		public ushort unk_factor; // unk1 & unk2 are both divided by (width * height * unk_factor) to determine something
		public ushort unk_y; // ???
		public uint unkAdventures;
		public uint texSize2;
		public uint unk0;
		public uint unk1;
		public uint unk2;
		public uint unk3;
		public uint unk4;
		public uint unk5 = 0x00010203;
		public byte[] texData;
		
		public UV.UVAtlas atlas = null;

		public void Serialize(CSerializerObject s, string name) {
			Reinit(s.Settings);
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				version = s.Serialize<uint>(version);
				signature = s.Serialize<uint>(signature);
				hdrSize = s.Serialize<uint>(hdrSize);
				texSize = s.Serialize<uint>(texSize);
				width = s.Serialize<ushort>(width);
				height = s.Serialize<ushort>(height);
				unk_factor = s.Serialize<ushort>(unk_factor);
				unk_y = s.Serialize<ushort>(unk_y);
				if (version >= 16) {
					unkAdventures = s.Serialize<uint>(unkAdventures);
				}
				texSize2 = s.Serialize<uint>(texSize2);
				unk0 = s.Serialize<uint>(unk0);
				unk1 = s.Serialize<uint>(unk1);
				unk2 = s.Serialize<uint>(unk2);
				unk3 = s.Serialize<uint>(unk3);
				unk4 = s.Serialize<uint>(unk4);
				unk5 = s.Serialize<uint>(unk5);
			} else {
				texSize = s.SerializeFileSize(texSize);
			}
			texData = s.SerializeBytes(texData, (int)texSize);
		}

		public void Reinit(Settings settings) {
			if (settings.game == Settings.Game.RL && version >= 16) {
				version = 13;
				hdrSize = 0x34;
			}
		}
	}
}
