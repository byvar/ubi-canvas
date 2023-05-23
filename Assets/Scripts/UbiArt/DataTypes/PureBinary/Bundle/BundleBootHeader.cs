namespace UbiArt.Bundle {
	public class BundleBootHeader : ICSerializable {
		public static uint staticSignature = 0x50EC12BA;
		public uint signature = staticSignature;
		public uint Version;
		public uint unk1;
		public uint unk_version8;
		public uint BaseOffset;
		public uint FilesCount;
		public bool unk2;
		public bool unk3;
		public bool unk4;
		public uint unk5;
		public uint EngineSignature; // Calculated by ITF::CSerializerObjectSignature::computeCRC. This calls Versioning:serializeAll - so a list of all modules' versions.
		public uint EngineVersion;
		public uint BlockSize;
		public uint BlockCompressedSize;

		public bool SupportsCompressedBlock => Version >= 6;

		public void Serialize(CSerializerObject s, string name) {
			signature = s.Serialize<uint>(signature, name: nameof(signature));
			Version = s.Serialize<uint>(Version, name: nameof(Version));
			unk1 = s.Serialize<uint>(unk1, name: nameof(unk1));
			if(Version >= 8)
				unk_version8 = s.Serialize<uint>(unk_version8, name: nameof(unk_version8));
			BaseOffset = s.Serialize<uint>(BaseOffset, name: nameof(BaseOffset));
			FilesCount = s.Serialize<uint>(FilesCount, name: nameof(FilesCount));
			unk2 = s.Serialize<bool>(unk2, name: nameof(unk2));
			unk3 = s.Serialize<bool>(unk3, name: nameof(unk3));
			unk4 = s.Serialize<bool>(unk4, name: nameof(unk4));
			unk5 = s.Serialize<uint>(unk5, name: nameof(unk5));
			EngineSignature = s.Serialize<uint>(EngineSignature, name: nameof(EngineSignature));
			EngineVersion = s.Serialize<uint>(EngineVersion, name: nameof(EngineVersion));
			if (SupportsCompressedBlock) {
				BlockSize = s.Serialize<uint>(BlockSize, name: nameof(BlockSize));
				BlockCompressedSize = s.Serialize<uint>(BlockCompressedSize, name: nameof(BlockCompressedSize));
			}
		}
		public BundleBootHeader() {
		}

		public BundleBootHeader(Context context) {
			if (context.Settings.game == Settings.Game.RL) {
				signature = staticSignature;
				Version = context.Settings.ipkVersion;
				unk1 = 0;
				unk2 = false;
				unk3 = true;
				unk4 = true;
				unk5 = 0;
				EngineSignature = context.Settings.engineSignature;
				EngineVersion = 0;
			}
		}
	}
}
