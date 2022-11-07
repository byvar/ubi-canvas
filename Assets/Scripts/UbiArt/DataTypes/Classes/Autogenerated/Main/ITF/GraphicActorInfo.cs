namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GraphicActorInfo : CSerializable {
		public Path amvPath;
		public GFXMaterialSerializable material;
		public float scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
			material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
			scale = s.Serialize<float>(scale, name: "scale");
		}
	}
}

