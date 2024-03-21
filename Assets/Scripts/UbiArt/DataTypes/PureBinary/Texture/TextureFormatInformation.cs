namespace UbiArt {
	public class TextureFormatInformation : CSerializable {
		public uint Version { get; set; }
		public CListO<Entry> Entries { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			Version = s.Serialize<uint>(Version, name: nameof(Version));
			Entries = s.SerializeObject<CListO<Entry>>(Entries, name: nameof(Entries));
		}

		public class Entry : CSerializable {
			public Path Texture { get; set; }
			public string CompressionMode { get; set; }
			public string WrapModeU { get; set; }
			public string WrapModeV { get; set; }
			public string Filter { get; set; }
			public uint UInt0 { get; set; }
			public uint UInt1 { get; set; }
			public uint UInt2 { get; set; }
			public uint UInt3 { get; set; }
			public uint UInt4 { get; set; }
			public uint UInt5 { get; set; }

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Texture = s.SerializeObject<Path>(Texture, name: nameof(Texture));
				CompressionMode = s.Serialize<string>(CompressionMode, name: nameof(CompressionMode));
				WrapModeU = s.Serialize<string>(WrapModeU, name: nameof(WrapModeU));
				WrapModeV = s.Serialize<string>(WrapModeV, name: nameof(WrapModeV));
				Filter = s.Serialize<string>(Filter, name: nameof(Filter));
				UInt0 = s.Serialize<uint>(UInt0, name: nameof(UInt0));
				UInt1 = s.Serialize<uint>(UInt1, name: nameof(UInt1));
				UInt2 = s.Serialize<uint>(UInt2, name: nameof(UInt2));
				UInt3 = s.Serialize<uint>(UInt3, name: nameof(UInt3));
				UInt4 = s.Serialize<uint>(UInt4, name: nameof(UInt4));
				UInt5 = s.Serialize<uint>(UInt5, name: nameof(UInt5));
			}
		}
	}
}
