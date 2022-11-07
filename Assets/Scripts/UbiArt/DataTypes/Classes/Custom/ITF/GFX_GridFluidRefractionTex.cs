namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GFX_GridFluidRefractionTex : CSerializable {
		public Path Texture;
		public float NoiseIntensity;
		public float SpeedX1;
		public float SpeedY1;
		public float ScaleX1;
		public float ScaleY1;
		public float SpeedTexFactor;
		public float FlatenDensity;
		public float FlatenSpeed;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Texture = s.SerializeObject<Path>(Texture, name: "Texture");
				NoiseIntensity = s.Serialize<float>(NoiseIntensity, name: "NoiseIntensity");
				SpeedX1 = s.Serialize<float>(SpeedX1, name: "SpeedX1");
				SpeedY1 = s.Serialize<float>(SpeedY1, name: "SpeedY1");
				ScaleX1 = s.Serialize<float>(ScaleX1, name: "ScaleX1");
				ScaleY1 = s.Serialize<float>(ScaleY1, name: "ScaleY1");
				SpeedTexFactor = s.Serialize<float>(SpeedTexFactor, name: "SpeedTexFactor");
				FlatenDensity = s.Serialize<float>(FlatenDensity, name: "FlatenDensity");
				FlatenSpeed = s.Serialize<float>(FlatenSpeed, name: "FlatenSpeed");
			}
		}
		public override uint? ClassCRC => 0x3B08DB7A;
	}
}

