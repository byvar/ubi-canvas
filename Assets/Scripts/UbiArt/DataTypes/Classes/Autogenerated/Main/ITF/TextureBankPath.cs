namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class TextureBankPath : CSerializable {
		public StringID id;
		public Path patchBank;
		public Path texture;
		public GFXMaterialTexturePathSet textureSet;
		public Path materialShader;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<StringID>(id, name: "id");
			patchBank = s.SerializeObject<Path>(patchBank, name: "patchBank");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				texture = s.SerializeObject<Path>(texture, name: "texture");
			}
			textureSet = s.SerializeObject<GFXMaterialTexturePathSet>(textureSet, name: "textureSet");
			materialShader = s.SerializeObject<Path>(materialShader, name: "materialShader");
		}
	}
}

