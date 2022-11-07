namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_RefractionPrimitive : CSerializable {
		public GFXPrimitiveParam PrimitiveParam;
		public float Intensity;
		public bool ShowRefracBuffer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				PrimitiveParam = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParam, name: "PrimitiveParam");
				Intensity = s.Serialize<float>(Intensity, name: "Intensity");
				ShowRefracBuffer = s.Serialize<bool>(ShowRefracBuffer, name: "ShowRefracBuffer");
			}
		}
		public override uint? ClassCRC => 0x9F2C5076;
	}
}

