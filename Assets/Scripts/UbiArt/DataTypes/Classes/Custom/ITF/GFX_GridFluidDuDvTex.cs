namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GFX_GridFluidDuDvTex : CSerializable {
		public Path Texture;
		public float Intensity;
		public float SpeedX1;
		public float SpeedY1;
		public float ScaleX1;
		public float ScaleY1;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Texture = s.SerializeObject<Path>(Texture, name: "Texture");
				Intensity = s.Serialize<float>(Intensity, name: "Intensity");
				SpeedX1 = s.Serialize<float>(SpeedX1, name: "SpeedX1");
				SpeedY1 = s.Serialize<float>(SpeedY1, name: "SpeedY1");
				ScaleX1 = s.Serialize<float>(ScaleX1, name: "ScaleX1");
				ScaleY1 = s.Serialize<float>(ScaleY1, name: "ScaleY1");
			}
		}
		public override uint? ClassCRC => 0x3E03E120;
	}
}

